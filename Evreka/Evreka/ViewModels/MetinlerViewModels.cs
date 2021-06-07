using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Evreka.Models;

namespace Evreka.ViewModels
{
   public class MetinlerViewModels
    {

      public  ObservableCollection<Metinler> hakkımızdasayfa1metinler;

        public MetinlerViewModels()
        {
            Hakkımızdasayfa1metinler = new ObservableCollection<Metinler>
            {
                new Metinler{Metins="Sektördeki öncü rolümüz bizi her zaman daha iyi olmaya teşvik ediyor."},
                new Metinler{Metins="Evreka, atık yönetimi sektöründe operasyonel mükemmelliğe odaklanarak dijital atık yönetimi çözümleri tasarlar.Evreka, yazılım ve donanım yeniliklerini kullanarak entegre bir platform geliştirmenin yanı sıra daha sürdürülebilir ve dijital bir süreç yönetimi için dünyanın her yerindeki atık yönetimi şirketleri, yerel yönetimler ve belediyeler ile iş birliği içinde çalışır." },


            };

         }   

        public ObservableCollection<Metinler> Hakkımızdasayfa1metinler { get => hakkımızdasayfa1metinler; set => hakkımızdasayfa1metinler = value; }
    }




    }

