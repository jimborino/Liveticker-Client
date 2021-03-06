﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace Liveticker_Client
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// <para>Die Schnittstelle publishLiveticker veröffentlicht eine „LiveTicker” Nachricht.</para>
        /// </summary>
        /// <param name="id">ID des zu veröffentlichenden Livetickers</param>
        private void publishLiveticker(int id)
        {
        }

        /// <summary>
        /// <para>Die Schnittstelle deleteLiveticker löscht eine „LiveTicker” Nachricht.</para>
        /// </summary>
        /// <param name="id">ID des zu löschenden Livetickers</param>
        private void deleteLiveticker(int id)
        {
        }

        /// <summary>
        /// <para>Durch die Schnittstelle addEvent soll es möglich sein eine Sportart hinzuzufügen.</para>
        /// </summary>
        /// <param name="date">...</param>
        /// <param name="title">...</param>
        /// <param name="description">...</param>
        /// <param name="icon">...</param>
        private void addEvent(DateTime date, string title, string description, Image icon)
        {
        }

        /// <summary>
        /// <para>Die Schnittstelle deleteEvent löscht eine Sportart.</para>
        /// </summary>
        /// <param name="id">ID des zu löschenden Events</param>
        private void deleteEvent(int id)
        {
        }

        /// <summary>
        /// <para>Durch die Schnittstelle modifyEvent soll es möglich sein die Daten eines Events zu bearbeiten, dies beinhaltet Datum, Titel, Beschreibung und Icon.</para>
        /// </summary>
        private void modifyEvent()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTicketVerfassen_Click(object sender, RoutedEventArgs e)
        {
            TickErstellen te = new TickErstellen();
            te.ShowDialog(); // Öffnen so das das MainWindow nicht mehr anklickbar ist.
        }

        /// <summary>
        /// <para>Handled eingaben die an das gesamte Fenster gerichtet sind.</para>
        /// <para>Wird benötigt um das Fenster zu schließen.</para>
        /// </summary>
        /// <param name="sender">...</param>
        /// <param name="e">...</param>
        private void Window_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            switch (e.Key)
            {
                case System.Windows.Input.Key.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}