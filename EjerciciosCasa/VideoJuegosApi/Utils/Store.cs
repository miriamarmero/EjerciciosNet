using System.Collections.Generic;
using VideoJuegosApi.Models;

namespace VideoJuegosApi.Utils
{
    public sealed class Store
    {
        private readonly static Store _instance = new Store();
        public List<VideoJuego> todos = new List<VideoJuego>();
        
        public Store()
        {
        }

        public static Store Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}