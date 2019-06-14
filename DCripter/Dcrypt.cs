using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCripter
{
    static class Dcrypt
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Master master = new Master();
            Slave slave = new Slave(master);
            master.saveReference(slave);
            Application.Run(new MultiFormContext(master, slave));
         
        }
    }
}
