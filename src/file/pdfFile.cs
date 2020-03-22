using src.processing;
using src.segment;
using src.XML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src.Files
{
    public class pdfFile : file
    {
        public override void readContent(string path)
        {
            pdfProc pdfproc = new pdfProc();
            List<string> listContentPage = new List<string>(); 
            listContentPage = pdfproc.readPdfFile(path);
            int page = 1;
            foreach (string contentPage in listContentPage)
            {
                content = content + contentPage;
                List<Segment> tmp = new List<Segment>();
                tmp = pdfproc.splitTxtContentToSegment(contentPage, delimiters, page);
                listSegments.AddRange(tmp);
                page++;
            }
        }
        public override void loadFileSave(string path)
        {
            if (File.Exists(path))
            {
                readwriteXML txt = new readwriteXML();
                this.listSegmentsFromSave = txt.readSegmentFromFileSave(path);

                //            //Set lai cac tm voi file save
            }
        }
        public override void createFileTranslateDocument(string path)
        {
            throw new NotImplementedException();
        }
    }
}
