using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MyLab
{
    public class ParkingCollection
    {
        readonly Dictionary<string, Parking<ITransport>> parkingStages;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly char separator = ':';

        public List<string> Keys => parkingStages.Keys.ToList();

        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddParking(string name)
        {
            if (!parkingStages.ContainsKey(name)) parkingStages.Add(name, new Parking<ITransport>(pictureWidth, pictureHeight));
        }

        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name)) parkingStages.Remove(name);
        }

        public Parking<ITransport> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using(StreamWriter sw = new StreamWriter(filename, false))
            {
                sw.Write($"ParkingCollection{Environment.NewLine}");
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку 
                    sw.Write($"Parking{separator}{level.Key}{Environment.NewLine}");
                    ITransport car = null;
                    for (int i = 0; (car = level.Value.GetNext(i)) != null; i++)
                    {
                        if (car != null)
                        {
                            //если место не пустое 
                            //Записываем тип машины 
                            if (car.GetType().Name == "BroneCar")
                            {
                                sw.Write($"BroneCar{separator}");
                            }
                            if (car.GetType().Name == "BroneZenit")
                            {
                                sw.Write($"BroneZenit{separator}");
                            }
                            //Записываемые параметры 
                            sw.Write(car + Environment.NewLine);
                        }
                    }
                }
            }
            return true;
        }
		
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string strs = sr.ReadLine();
                if (strs.Contains("ParkingCollection"))
                {
                    //очищаем записи 
                    parkingStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные 
                    throw new ArgumentOutOfRangeException();
                }
                abstrBron car = null;
                string key = string.Empty;
                while ((strs = sr.ReadLine()) != null)
                {
                    if (strs.Contains("Parking"))
                    {
                        //начинаем новую парковку 
                        key = strs.Split(separator)[1];
                        parkingStages.Add(key, new Parking<ITransport>(pictureWidth, pictureHeight));
                    }
                    else if (strs.Contains(separator))
                    {
                        if (strs.Contains("BroneCar"))
                        {
                            car = new BroneCar(strs.Split(separator)[1]);
                        }
                        else if (strs.Contains("BroneZenit"))
                        {
                            car = new BroneZenit(strs.Split(separator)[1]);
                        }
                        if (!(parkingStages[key] + car))
                        {
                            throw new ParkingOverflowException();
                        }
                    }
                }
            }
        }
    }
}