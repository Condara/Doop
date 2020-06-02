﻿using System;
using System.Text;
using DOOP_LV6_Čondić.Iterator;
using DOOP_LV6_Čondić.Memento;
using DOOP_LV6_Čondić.NSObserver;

namespace DOOP_LV6_Čondić
{
    class Program
    {
        static void Main(string[] args)
        {

            note note = new note("Naslov", "text, tijelo poruke");

            note.Show();

            StringBuilder sbTitle = new StringBuilder("Naslov p");
            StringBuilder sbBody = new StringBuilder("Text pp0");
            Notebook notebook = new Notebook();

            for (int i = 0; i < 8; i++)
            {
                sbTitle.Append('w', i / 2);
                sbBody.Append('b', i / 3);
                notebook.AddNote(new note(sbTitle.ToString(), sbBody.ToString()));
            }

            CIterator iterator = new CIterator(notebook);
            iterator.First().Show();
            while (iterator.Next() != null)
            {
                iterator.Current.Show();
            }

            notebook.Clear();

            CareTaker careTaker = new CareTaker();
            ToDoItem tdi1 = new ToDoItem("naslov1", "text1", DateTime.Now);
            ToDoItem tdi2 = new ToDoItem("naslov12", "text12", DateTime.Now);
            ToDoItem tdi3 = new ToDoItem("naslov123", "text123", DateTime.MinValue);
            ToDoItem tdi4 = new ToDoItem("naslov1234", "text1234", DateTime.MaxValue);
            tdi1.AddStateCT(careTaker);
            tdi2.AddStateCT(careTaker);
            tdi3.AddStateCT(careTaker);
            tdi4.AddStateCT(careTaker);

            ToDoItem getStateTdi = new ToDoItem("", "", DateTime.MinValue);
            getStateTdi.RestoreState(careTaker.GetByTitle("naslov12")); 

            Console.WriteLine(getStateTdi.ToString());

            HomeThermostat termostat1 = new HomeThermostat();
            HomeThermostat termostat2 = new HomeThermostat();
            CarThermostat termostatAuto = new CarThermostat();
            WeatherStation station = new WeatherStation(44);

            station.AddObserver(termostat1);
            station.AddObserver(termostat2);
            station.AddObserver(termostatAuto);
            station.SetTemperature(22);
            station.SetTemperature(2);
        }
    }
}
