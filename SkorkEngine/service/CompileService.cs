using Skork_Engine_Library.Parse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

using Skork_Engine_Library;
namespace SkorkEngine.Service {
    public class CompileService {
        
        
        /// <summary>
        /// Attempts to compile code from a <see cref="RichTextBox"/>.
        /// 
        /// See <see cref="SkorkParser.CompileSkorkCode(List{string})"/> for compiler returns.
        /// </summary>
        /// <param name="richText">The <see cref="RichTextBox"/> that you want to compile.</param>
        /// <returns></returns>
        public static int CompileCode(ref RichTextBox richText) {
            SkorkParser parser = new SkorkParser();

            var range = new TextRange(richText.Document.ContentStart, richText.Document.ContentEnd);
            var lines = range.Text.Split('\n');

            List<string> lstCode = new List<string>();

            foreach (string s in lines) {
                lstCode.Add(s);
            }
            
           return parser.CompileSkorkCode(lstCode);
        }

        /// <summary>
        /// Attempts to compile code from a <see cref="RichTextBox"/>.
        /// 
        /// See <see cref="SkorkParser.CompileSkorkCode(List{string})"/> for compiler returns.
        /// </summary>
        /// <param name="richText">The <see cref="RichTextBox"/> that you want to compile.</param>
        /// <returns></returns>
        public static List<string> CleanCode(ref RichTextBox richText) {
            SkorkParser parser = new SkorkParser();

            var range = new TextRange(richText.Document.ContentStart, richText.Document.ContentEnd);
            var lines = range.Text.Split('\n');

            List<string> lstCode = new List<string>();

            foreach (string s in lines) {
                lstCode.Add(s);
            }

            return parser.ParseCode(lstCode);
        }

    }
}
