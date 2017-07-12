using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CNC
{
    /// <summary>
    /// Class which realises meta-language to simplify representation of G Code in C#
    /// </summary>
    public class CNCWriter
    {
        /// <summary>
        /// Stream where meta-codes will be written
        /// </summary>
        private StreamWriter _stream;
        private String _ending
        {
            get
            {
                if (isInline)
                    return " ";
                else
                {
                    return "\r\n";
                }
            }
        }
        private String _tab
        {
            get
            {
                String tabulation = String.Empty;
                if(!isInline)
                    for (int i = 1; i < _tabCounter; i++) //GOVNOKOD
                        tabulation += '\t';
                return tabulation;
            }
        }
        private int _tabCounter = 0;
        private bool _isInline = false;

        /// <summary>
        /// Defines will the command switch to the next string after being writed
        /// </summary>
        public bool isInline
        {
            get
            {
                return _isInline;
            }
        }
                        
        public CNCWriter(StreamWriter stream)
        {
            _stream = stream;
        }

        public CNCWriter(String path)
        {
            _stream = new StreamWriter(path);
        }

        /// <summary>
        /// After set to 'true' all commands will no longer switch to the next string until it will be setted to 'false'
        /// </summary>
        /// <param name="inline"></param>
        public void Inline()
        {
            if (!isInline)
                _stream.Write(_tab);
            else
                _stream.Write("\r\n");
            _isInline = !_isInline;
        }
        /// <summary>
        /// Define REAL variable
        /// </summary>
        /// <param name="var">Variable name</param>
        public void DefReal(String var)
        {
            _Write("DEF REAL " + var);
        }

        //-------------------------------Append and overloads
        /// <summary>
        /// Writes code which append string to variable
        /// </summary>
        /// <param name="var">Variable name</param>
        /// <param name="value">String to append</param>
        public void Append(String var, String value)
        {
            _Write(var.ToUpper() + "=" + _FormatString(value));            
        }

        /// <summary>
        /// Writes code which append value to variable
        /// </summary>
        /// <param name="var">Variable name</param>
        /// <param name="value">Value to append (auto-formatted)</param>
        public void Append(String var, object value)
        {
            value = _FormatValue(value);
            _Write(var.ToUpper() + "=" + value.ToString());
        }
        //-------------------------------

        /// <summary>
        /// Increments specified variable
        /// </summary>
        /// <param name="var">Variable name</param>
        /// <param name="value">Value to append (auto-formatted)</param>
        public void Increment(String var)
        {
            _Write(var.ToUpper() + "=" + var.ToUpper() + "+1");
        }

        //-------------------------------MCode, Gcode and overloads
        /// <summary>
        /// Writes M-code in format "M+'number'"
        /// </summary>
        public void MCode(object number)
        {
            _Write("M" + number.ToString());
        }

        /// <summary>
        /// Writes series of M-codes
        /// </summary>
        /// <param name="number"></param>
        public void MCode(object[] number)
        {
            String buf = String.Empty;
            for (int i = 0; i < number.Length; i++)
                buf += "M" + number[i].ToString() + " ";
            _Write(buf);
        }
        
        /// <summary>
        /// Writes G-code in format "G+'number'"
        /// </summary>
        public void GCode(object number)
        {
            _Write("G" + number.ToString());
        }

        /// <summary>
        /// Writes series of G-codes
        /// </summary>
        /// <param name="number"></param>
        public void GCode(object[] number)
        {
            String buf = String.Empty;
            for (int i = 0; i < number.Length; i++)
                buf += "G" + number[i].ToString() + " ";
            _Write(buf);
        }
        //-------------------------------
        
        /// <summary>
        /// Specifies feedrate
        /// </summary>
        public void FeedRate(object number)
        {
            _Write("F" + number.ToString());
        }

        //-------------------------------Move function and tons of its overloads
        /// <summary>
        /// Literally is the realisation the code like "G1 X Z A F%rate%"
        /// </summary>
        /// <param name="x"></param>
        /// <param name="z"></param>
        /// <param name="a"></param>
        /// <param name="rate"></param>
        public void Move(object x, object z, object a, int rate)
        {
            Inline();
            GCode(1);
            Append("X", x);
            Append("Z", z);
            Append("A", a);
            FeedRate(rate);
            Inline();
        }

        /// <summary>
        /// Literally is the realisation the code like "G1 Z F%rate%"
        /// </summary>
        /// <param name="x"></param>
        /// <param name="z"></param>
        /// <param name="a"></param>
        /// <param name="rate"></param>
        public void Move(string c1, object v1, int rate)
        {
            Inline();
            GCode(1);
            Append(c1, v1);
            FeedRate(rate);
            Inline();
        }

        /// <summary>
        /// Literally is the realisation the code like "G1 Z A F%rate%"
        /// </summary>
        /// <param name="x"></param>
        /// <param name="z"></param>
        /// <param name="a"></param>
        /// <param name="rate"></param>
        public void Move(string c1, object v1, string c2, object v2, int rate)
        {
            Inline();
            GCode(1);
            Append((string)c1, v1);
            Append((string)c2, v2);
            FeedRate(rate);
            Inline();
        }

        /// <summary>
        /// Literally is the realisation the code like "G1 X Z A F%rate%"
        /// </summary>
        /// <param name="x"></param>
        /// <param name="z"></param>
        /// <param name="a"></param>
        /// <param name="rate"></param>
        public void Move(string x, string z, string a, int rate)
        {
            Inline();
            GCode(1);
            Append("X", x);
            Append("Z", z);
            Append("A", a);
            FeedRate(rate);
            Inline();
        }

        /// <summary>
        /// Literally is the realisation the code like "G1 Z F%rate%"
        /// </summary>
        /// <param name="x"></param>
        /// <param name="z"></param>
        /// <param name="a"></param>
        /// <param name="rate"></param>
        public void Move(string c1, string v1, int rate)
        {
            Inline();
            GCode(1);
            Append(c1, v1);
            FeedRate(rate);
            Inline();
        }

        /// <summary>
        /// Literally is the realisation the code like "G1 Z A F%rate%"
        /// </summary>
        /// <param name="x"></param>
        /// <param name="z"></param>
        /// <param name="a"></param>
        /// <param name="rate"></param>
        public void Move(string c1, string v1, string c2, string v2, int rate)
        {
            Inline();
            GCode(1);
            Append((string)c1, v1);
            Append((string)c2, v2);
            FeedRate(rate);
            Inline();
        }
        //----------------------------------


        /// <summary>
        /// Specifies while cycle with condition
        /// </summary>
        public void While(String condition)
        {
            _tabCounter++;
            _Write("WHILE " + _FormatString(condition.ToString()));
        }

        /// <summary>
        /// Ends while cycle
        /// </summary>
        public void EndWhile()
        {
            _Write("ENDWHILE");
            _tabCounter--;
        }

        /// <summary>
        /// Write specified string (Automatically uppercase)
        /// </summary>
        /// <param name="str"></param>
        public void Echo(object str)
        {
            _Write((str.ToString()).ToUpper());
        }
        
        /// <summary>
        /// Writes comment with a new string
        /// </summary>
        /// <param name="str"></param>
        public void Comment(string str)
        {
            _Write("; " + str);
        }

        /// <summary>
        /// End writing and close the stream
        /// </summary>
        public void Close()
        {
            _stream.Close();
        }

        //---------------------------------------------------------------Private

        /// <summary>
        /// Casting value to double and rounds it to 3 digits
        /// </summary>
        /// <param name="value">Will be formatted aoutomatically</param>
        /// <returns></returns>
        private double _FormatValue(object value)
        {
            return Math.Round(Convert.ToDouble(value), 3);
        }

        /// <summary>
        /// Removes spaces and makes string uppercase
        /// </summary>
        /// <param name="str">String to format</param>
        /// <returns></returns>
        private String _FormatString(String str)
        {
            return (str.Replace(" ", "")).ToUpper();
        }

        /// <summary>
        /// Formats and writes str value in file
        /// </summary>
        /// <param name="str">String to write</param>
        private void _Write(String str)
        {            
            _stream.Write(_tab + str + _ending);
        }        
    }
}
