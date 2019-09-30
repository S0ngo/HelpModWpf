using Adani.common.HelpModWPF.HelpApi;
using System.IO;
using System.Windows.Input;

namespace Adani.common.HelpModWPF
{
    class OpentHelp
    {

        public IHelpSection HelpSection;
        public IHelpClient HelpClient;
        public IHelpSource HelpSource;

        public string application;
        public string strParams;

        public void OpenFileHelp()
        {
            if (application != null && strParams != null)
            {
                System.Diagnostics.Process.Start(application, strParams);
            }
        }

    }

    class OpentPDFPageHelp : OpentHelp
    {
        public OpentPDFPageHelp()
        {
            HelpSection = new GetPage();
            HelpClient = new GetActiveWindowTitle();
            HelpSource = new ProjectRootDirectory();

            string page = HelpSection.HelpSection();
            string source = HelpSource.HelpSource();
            string fileHelp = HelpClient.HelpClient();
            string expansion = ".pdf";

            application = "AcroRd32.exe";
    
            if (File.Exists(source + fileHelp + expansion))
            {
                strParams = " /N /A \"page=" + page + "\" \"" + source + fileHelp + expansion + "\"";
            }
        }
    }

    class OpentPDFNameddestHelp : OpentHelp
    { 
        public OpentPDFNameddestHelp()
        {
            HelpSection = new GetNameddest();
            HelpClient = new GetActiveWindowTitle();
            HelpSource = new ProjectRootDirectory();

            string nameddest = HelpSection.HelpSection();
            string source = HelpSource.HelpSource();
            string fileHelp = HelpClient.HelpClient();
            string expansion = ".pdf";

            application = "AcroRd32.exe";

            if (File.Exists(source + fileHelp + expansion))
            {
                strParams = " /N /A \"nameddest=" + nameddest + "\" \"" + source + fileHelp + expansion + "\"";
            }
        }
    }
    
    
}
