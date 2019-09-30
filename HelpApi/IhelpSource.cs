using System;

namespace Adani.common.HelpModWPF.HelpApi
{
    public interface IHelpSource
    {
        string HelpSource();
    }

    class ProjectRootDirectory : IHelpSource
    {
        public string HelpSource()
        {
            return AppDomain.CurrentDomain.BaseDirectory.ToString();
        }

    }

}
