using Skork_Engine_Library.Parse;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Documents;

namespace SkorkEngine.Service
{
    public class CompileService
    {
        /// <summary>
        /// Attempts to compile code from a <see cref="RichTextBox"/>.
        /// 
        /// See <see cref="SkorkParser.CompileSkorkCode(ref List{string})"/> for compiler returns.
        /// </summary>
        /// <param name="richText">The <see cref="RichTextBox"/> that you want to compile.</param>
        /// <returns></returns>
        public static int CompileCode(List<string> lstCode)
        {
            SkorkParser parser = new SkorkParser();

            try
            {
                return parser.CompileSkorkCode(ref lstCode);
            }
            catch
            {

            }

            return -1;
        }

        /// <summary>
        /// Attempts to compile code from a <see cref="RichTextBox"/>.
        /// 
        /// <para>See <see cref="SkorkParser.CompileSkorkCode(ref List{string})"/>
        /// for compiler returns.</para>
        /// </summary>
        /// <param name="richTextBox">The <see cref="RichTextBox"/> that you want to compile.</param>
        /// <returns></returns>
        public static List<string> ConvertCodeIntoList(ref RichTextBox richTextBox)
        {
            SkorkParser parser = new SkorkParser();

            TextRange range = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            string[] lines = range.Text.Split('\n');

            List<string> lstCode = new List<string>();

            foreach (string s in lines)
            {
                lstCode.Add(s);
            }

            return lstCode;
        }

    }
}
