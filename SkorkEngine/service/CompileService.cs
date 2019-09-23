using SkorkEngineAPI.Language.Compile;
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
            SkorkCompile sc = new SkorkCompile();
            SkorkParser parser = new SkorkParser(ref lstCode);
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
            TextRange range = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            string[] lines = range.Text.Split('\n');

            List<string> lstCode = new List<string>();
            SkorkParser parser = new SkorkParser(ref lstCode);

            foreach (string s in lines)
            {
                lstCode.Add(s);
            }

            return lstCode;
        }

    }
}
