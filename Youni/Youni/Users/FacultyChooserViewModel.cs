﻿using System;
using Xamarin.Forms;

namespace Youni
{
    public class FacultyChooserViewModel
    {
        public string RegName { get; set; }
        public string RegSurname { get; set; }
        public string RegEmail { get; set; }
        public string RegPassword { get; set; }
        private DataBaseHandler DBHandler;
        public INavigation Navigation;
        public Command MecEngCommand { get; set; }
        public Command SofEngCommand { get; set; }
        public Command EleEngCommand { get; set; }
        public Command CivEngCommand { get; set; }

        public FacultyChooserViewModel()
        {
            this.DBHandler = new DataBaseHandler();

            MecEngCommand = new Command(async () =>
            {
                try
                {
                    await this.DBHandler.InsertUserAsync(this.RegEmail, this.RegPassword, this.RegName, this.RegSurname, "Ingegneria Meccanica");
                    await Application.Current.MainPage.Navigation.PopModalAsync();
                }
                catch (System.Net.Sockets.SocketException)
                {
                    await Application.Current.MainPage.DisplayAlert("Errore", "Problema di connessione", "Riprova");
                }
            });

            SofEngCommand = new Command(async () =>
            {
                try
                {
                    await this.DBHandler.InsertUserAsync(this.RegEmail, this.RegPassword, this.RegName, this.RegSurname, "Ingegneria Informatica");
                    await Application.Current.MainPage.Navigation.PopModalAsync();
                }
                catch (System.Net.Sockets.SocketException)
                {
                    await Application.Current.MainPage.DisplayAlert("Errore", "Problema di connessione", "Riprova");
                }
            });

            EleEngCommand = new Command(async () =>
            {
                try
                {
                    await this.DBHandler.InsertUserAsync(this.RegEmail, this.RegPassword, this.RegName, this.RegSurname, "Ingegneria Elettronica");
                    await Application.Current.MainPage.Navigation.PopModalAsync();
                }
                catch (System.Net.Sockets.SocketException)
                {
                    await Application.Current.MainPage.DisplayAlert("Errore", "Problema di connessione", "Riprova");
                }
            });

            CivEngCommand = new Command(async () =>
            {
                try
                {
                    await this.DBHandler.InsertUserAsync(this.RegEmail, this.RegPassword, this.RegName, this.RegSurname, "Ingegneria Civile");
                    await Application.Current.MainPage.Navigation.PopModalAsync();
                }
                catch (System.Net.Sockets.SocketException)
                {
                    await Application.Current.MainPage.DisplayAlert("Errore", "Problema di connessione", "Riprova");
                }
            });
        }

        public FacultyChooserViewModel(string regName, string regSurname, string regEmail, string regPassword) : this()
        {
            this.RegName = regName;
            this.RegSurname = regSurname;
            this.RegEmail = regEmail;
            this.RegPassword = regPassword;
        }

        //public FacultyChooserViewModel(INavigation navigation) : this()
        //{
        //    this.Navigation = navigation;
        //}
    }
}
