using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Documents;

using Skork_Engine_Library.Parse;

namespace SkorkEngine.Service {
    public class CompileService {


        /// <summary>
        /// Attempts to compile code from a <see cref="RichTextBox"/>.
        /// 
        /// See <see cref="SkorkParser.CompileSkorkCode(ref List{string})"/> for compiler returns.
        /// </summary>
        /// <param name="richText">The <see cref="RichTextBox"/> that you want to compile.</param>
        /// <returns></returns>
        public static int CompileCode(ref RichTextBox richText) {
            SkorkParser parser = new SkorkParser();

            TextRange range = new TextRange(richText.Document.ContentStart, richText.Document.ContentEnd);
            string[] lines = range.Text.Split('\n');

            List<string> lstCode = new List<string>();

            foreach (string s in lines) {
                lstCode.Add(s);
            }

            try {
                parser.CompileSkorkCode(ref lstCode);
            }

            return
        }

        /// <summary>
        /// Attempts to compile code from a <see cref="RichTextBox"/>.
        /// 
        /// <para>See <see cref="SkorkParser.CompileSkorkCode(ref List{string})"/>
        /// for compiler returns.</para>
        /// </summary>
        /// <param name="richText">The <see cref="RichTextBox"/> that you want to compile.</param>
        /// <returns></returns>
        public static List<string> ConvertCodeIntoList(ref RichTextBox richText) {
            SkorkParser parser = new SkorkParser();

            TextRange range = new TextRange(richText.Document.ContentStart, richText.Document.ContentEnd);
            string[] lines = range.Text.Split('\n');

            List<string> lstCode = new List<string>();

            foreach (string s in lines) {
                lstCode.Add(s);
            }

            return parser.CompileSkorkCode();
        }

    }
}
