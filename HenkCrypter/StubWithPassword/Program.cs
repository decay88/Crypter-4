/* HenkEncrypt
 * Copyright (C) 2018  henkje (henkje@pm.me)
 * 
 * MIT license
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using encryption;

namespace StubWithPassword
{
    class Program
    {
        static void Main()
        {
            //Stub||Program||Length Of Program(4 bytes)    
            try
            {
                string EncryptionKey = Microsoft.VisualBasic.Interaction.InputBox("Key:", "Credentials");
                ExecuteBytes(GetBytes(EncryptionKey));
            }
            catch { }
        }

        static byte[] GetBytes(string Key)
        {
            //get the bytes of this file
            byte[] FileBytes = File.ReadAllBytes(Assembly.GetExecutingAssembly().Location);

            //get the length of the file that is in the stub
            //the length is saved in the last 4 bytes
            byte[] ByteLength = new byte[4];//create new array
            Array.Copy(FileBytes, FileBytes.Length - 4, ByteLength, 0, 4);//get last 4 bytes
            int length = BitConverter.ToInt32(ByteLength, 0);//convert the bytes to int
            if (length == 0) Environment.Exit(1); //not a file in the stub, close the programm

            //remove the first bytes of the filebytes, this are the bytes of the stub
            FileBytes = FileBytes.Skip(FileBytes.Length - (length + 4)).ToArray();

            //remove the last 4 bytes, this is the int with the length of the other file
            byte[] ProgramBytes = new byte[FileBytes.Length - 4];
            Array.Copy(FileBytes, ProgramBytes, ProgramBytes.Length);

            //decrypt the bytes and return them
            try { return aes_256.Decrypt(ProgramBytes, aes_256.CreateKey(Key)); }
            catch
            {
                Microsoft.VisualBasic.Interaction.MsgBox("Invalid key", Microsoft.VisualBasic.MsgBoxStyle.Critical, "Error");
                Environment.Exit(1); return null;
            }
        }

        static void ExecuteBytes(byte[] Data)
        {
            //create assembly of the Data
            Assembly Assembly = Assembly.Load(Data);

            //get the entry point of the program
            MethodInfo method = Assembly.EntryPoint;

            //run the application from starting point
            method.Invoke(Assembly.CreateInstance(method.Name), null);
        }
    }
}
