using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    /// <summary>
    /// Aplico DIP para que ConsolePrrinter y FilePrinter dependan de IRecipeContent
    /// </summary>
    public interface IRecipeContent 
    {
        string GetTextToPrint();
    }
}