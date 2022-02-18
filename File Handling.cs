using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_application
{
    class File_Handling
    {
        public void data()
        {
            string filepath = "C:\\userdel.txt";
            try
            {

                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.Write(Environment.NewLine + "Appending this new line");
                    sw.Close();
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine(File.ReadAllText(filepath));
            }
        }
    }
}
