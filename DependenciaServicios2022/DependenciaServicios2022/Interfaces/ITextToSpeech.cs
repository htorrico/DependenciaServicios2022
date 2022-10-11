using System;
using System.Collections.Generic;
using System.Text;

namespace DependenciaServicios2022.Interfaces
{
    public interface ITextToSpeech
   {
        void Speak(string text);
    }
}
