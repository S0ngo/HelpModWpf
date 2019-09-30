namespace Adani.common.HelpModWPF.HelpApi
{
    interface IHelpSection
    {
        string HelpSection();
    }

    class GetPage : IHelpSection
    {
        public string HelpSection()
        {
            int page = 3;
            return page.ToString();
        }
      
    }

    class GetNameddest : IHelpSection
    {
        string[] FileHelp = { "dest1", "dest2", "dest3", "Службы интернета" };

        public string HelpSection()
        {
            var dataObject = System.Windows.Clipboard.GetDataObject();
            string text = dataObject.GetData("UnicodeText", true).ToString();

            for (int i = 0; i < FileHelp.Length; i++)
            {
                if (FileHelp[i] == text)
                {
                    return FileHelp[i];
                }
            }

            return null;
        }

    }

}
