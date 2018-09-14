using MakePizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakePizza.DAO
{
    public class SingletonContext
    {
        private static Contexto contexto;

        private SingletonContext() { }

        public static Contexto GetInstance()
        {
            if(contexto == null)
            {
                contexto = new Contexto();
            }
            return contexto;
        }
    }
}