using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Lab4
{
    static class Flegmatic_sum
    {
        public static float Value { get; set; }
    }
    static class Holeric_sum
    {
        public static float Value { get; set; }
    }
    static class Melanholik_sum
    { 
        public static float Value { get; set; }
    }
    static class Sangvinic_sum
    {
        public static float Value { get; set; }
    }
    static class Flegmatic
    {
        public static float Value { get; set; }
    }
    static class Holeric
    {
        public static float Value { get; set; }
    }
    static class Melanholik
    {
        public static float Value { get; set; }
    }
    static class Sangvinic
    {
        public static float Value { get; set; }
    }
    static class Pos_answer
    {
        public static float Value { get; set; }
    }
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Begin());
        }
    }
}
