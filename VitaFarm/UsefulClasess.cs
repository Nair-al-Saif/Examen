using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VitaFarm
{
    internal class UsefulClasess
    {
        internal void Message(string Text, string Type)
        {
            switch (Type)
            {
                case "Error":
                case "E":
                    MessageBox.Show(Text, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "Error!":
                case "E!":
                    MessageBox.Show(Text, "!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "Info":
                case "I":
                    MessageBox.Show(Text, "Уведомление",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
                case "Info!":
                case "I!":
                    MessageBox.Show(Text, "!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show(Text, "Сообщение", MessageBoxButtons.OK,
                        MessageBoxIcon.None);
                    break;
            }
        }
        internal void UnexpectedError(Exception ex)
        {
            Message("Непредвиденная ошибка:\n" + ex, "Error!");
            Console.WriteLine(ex.ToString());
        }
    }
}
