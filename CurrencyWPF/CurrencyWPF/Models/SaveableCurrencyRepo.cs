using Currency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurrencyWPF;
using CurrencyWPF.ViewModels;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CurrencyWPF.Models
{
    [Serializable]
    public  class SaveableCurrencyRepo : BaseViewModel
    {
        public string Path { get; set; }
        public List<ICoin> Coins { get; set; }
        
        
        public SaveableCurrencyRepo( List<ICoin> repo)
        {
           
            Path = "MyFile.bin";

        }

        public bool Save(List<ICoin> repo)
        {
            

            if (Path == null)
            {
                return false;
            }
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(this.Path, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, repo);
            stream.Close();
            return true;
        }
        public List<ICoin>  Load()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.Read);

            List<ICoin> repoNew = (List<ICoin>)formatter.Deserialize(stream) as List<ICoin>;
            stream.Close();
            Coins = repoNew;
            return Coins;
        }
    }
}
