/* HenkCrypter
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
using System.Windows.Forms;
using encryption;

namespace HenkCrypter
{
    public partial class Builder : Form
    {
        string EncryptionKey = "EncryptionKey";
        public Builder() => InitializeComponent();

        private void search_Click(object sender, EventArgs e) { using (OpenFileDialog openFileDialog1 = new OpenFileDialog()) if (openFileDialog1.ShowDialog() == DialogResult.OK) path.Text = openFileDialog1.FileName; }

        private void build_Click(object sender, EventArgs e)
        {
            //location of the files
            if (!File.Exists(path.Text)) MessageBox.Show("No file selected");


            //get the bytes of the stub
            byte[] StubBytes;
            if (Key.Text.Length != 0)
            {
                EncryptionKey = Key.Text;
                StubBytes = File.ReadAllBytes(Application.StartupPath + Path.DirectorySeparatorChar + "StubWithPassword.exe");
            }
            else StubBytes = File.ReadAllBytes(Application.StartupPath + Path.DirectorySeparatorChar + "stub.exe");
            //get the bytes of the Program
            byte[] ProgramBytes = File.ReadAllBytes(path.Text);

            //encrypt the bytes
            ProgramBytes = aes_256.Encrypt(ProgramBytes, aes_256.CreateKey(EncryptionKey));

            //get the length of the encrypted bytes and convert it to byte[]
            byte[] LengthByte = BitConverter.GetBytes(ProgramBytes.Length);

            //merge all the bytes
            byte[] ToWrite = new byte[StubBytes.Length + ProgramBytes.Length + LengthByte.Length];
            Buffer.BlockCopy(StubBytes, 0, ToWrite, 0, StubBytes.Length);
            Buffer.BlockCopy(ProgramBytes, 0, ToWrite, StubBytes.Length, ProgramBytes.Length);
            Buffer.BlockCopy(LengthByte, 0, ToWrite, StubBytes.Length + ProgramBytes.Length, LengthByte.Length);

            //write all the bytes
            using (FileStream file = File.OpenWrite(Application.StartupPath + Path.DirectorySeparatorChar + "build.exe"))
            {
                file.Seek(0, SeekOrigin.End);
                file.Write(ToWrite, 0, ToWrite.Length);
            }
        }
    }
}
