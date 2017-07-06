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
        private StreamWriter Stream;
        private String ending;
        /// <summary>
        /// Defines will the command switch to the next string after being writed
        /// </summary>
        public bool isInline
        {
            get
            {
                return (ending != " ");
            }
        }
                        
        public CNCWriter(StreamWriter stream)
        {
            Stream = stream;
            ending = "\r\n";
        }

        public CNCWriter(String path)
        {
            Stream = new StreamWriter(path);
            ending = "\r\n";
        }

        /// <summary>
        /// After set to 'true' all commands will no longer switch to the next string until it will be setted to 'false'
        /// </summary>
        /// <param name="inline"></param>
        public void Inline(bool inline)
        {
            if (inline)
                ending = " ";
            else
            {
                ending = "\r\n";
                Write(String.Empty);
            }
        }
        /// <summary>
        /// Define REAL variable
        /// </summary>
        /// <param name="var">Variable name</param>
        public void DefReal(String var)
        {
            Write("DEF REAL " + var);
        }

        /// <summary>
        /// Writes code which append string to variable
        /// </summary>
        /// <param name="var">Variable name</param>
        /// <param name="value">String to append</param>
        public void Append(String var, String value)
        {
            Write(var.ToUpper() + "=" + FormatString(value));
        }

        /// <summary>
        /// Writes code which append value to variable
        /// </summary>
        /// <param name="var">Variable name</param>
        /// <param name="value">Value to append (auto-formatted)</param>
        public void Append(String var, object value)
        {
            value = FormatValue(value);
            Write(var.ToUpper() + "=" + value.ToString());
        }

        /// <summary>
        /// Writes M-code in format "M+'number'"
        /// </summary>
        public void MCode(object number)
        {
            Write("M" + number.ToString());
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
            Write(buf);
        }

        /// <summary>
        /// Writes G-code in format "G+'number'"
        /// </summary>
        public void GCode(object number)
        {
            Write("G" + number.ToString());
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
            Write(buf);
        }

        
        /// <summary>
        /// Specifies feedrate
        /// </summary>
        public void FeedRate(object number)
        {
            Write("F" + number.ToString());
        }

        /// <summary>
        /// Specifies while cycle with condition
        /// </summary>
        public void While(object condition)
        {
            Write("WHILE " + FormatString(condition.ToString()));
        }

        /// <summary>
        /// Ends while cycle
        /// </summary>
        public void EndWhile()
        {
            Write("ENDWHILE");
        }

        /// <summary>
        /// Write specified string (Automatically uppercase)
        /// </summary>
        /// <param name="str"></param>
        public void Echo(object str)
        {
            Write((str.ToString()).ToUpper());
        }

        public void 
        //---------------------------------------------------------------Private

        /// <summary>
        /// Casting value to double and rounds it to 3 digits
        /// </summary>
        /// <param name="value">Will be formatted aoutomatically</param>
        /// <returns></returns>
        private double FormatValue(object value)
        {
            return Math.Round(Convert.ToDouble(value), 3);
        }

        /// <summary>
        /// Removes spaces and makes string uppercase
        /// </summary>
        /// <param name="str">String to format</param>
        /// <returns></returns>
        private String FormatString(String str)
        {
            return (str.Replace(" ", "")).ToUpper();
        }

        /// <summary>
        /// Writes with a new line or not depending on "Inline" value
        /// </summary>
        /// <param name="str">String to write</param>
        private void Write(String str)
        {
            Stream.Write(str + ending);
        }

    }
}
