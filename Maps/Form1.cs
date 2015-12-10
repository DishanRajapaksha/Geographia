using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.WindowsForms.Markers;
using MetroFramework.Forms;
using GMap.NET.CacheProviders;
using System.IO;

namespace Maps
{
    public partial class Form1 : MetroForm
    {

        public Form1()
        {
            InitializeComponent();
            label1.Parent = gmap;
            label1.BackColor = Color.Transparent;

            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.SetPositionByKeywords("Sri Lanka");
            gmap.DragButton = MouseButtons.Left;
            //gmap.Manager.Mode = AccessMode.ServerAndCache;
            gmap.BackColor = Color.FromName("white");

            comboBoxMapType.ValueMember = "Name";
            comboBoxMapType.DataSource = GMapProviders.List;
            comboBoxMapType.SelectedItem = gmap.MapProvider;

            Mode.DataSource = Enum.GetValues(typeof(AccessMode));
            Mode.SelectedItem = gmap.Manager.Mode;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gmap_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PNG (*.png)|*.png";
                    sfd.FileName = "GMap.NET image";

                    Image tmpImage = gmap.ToImage();
                    if (tmpImage != null)
                    {
                        using (tmpImage)
                        {
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                tmpImage.Save(sfd.FileName);

                                MessageBox.Show("Image saved: " + sfd.FileName, "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image failed to save: " + ex.Message, "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            gmap.SetPositionByKeywords(Keyword.Text);
        }

        private void Keyword_Click(object sender, EventArgs e)
        {
            Keyword.Text = "";
        }

        private void gmap_DoubleClick(object sender, EventArgs e)
        {
            gmap.Zoom = gmap.Zoom + 1;
        }

        private void gmap_Click(object sender, EventArgs e)
        {
            gmap.Focus();
        }

        private void gmap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                gmap.Zoom = gmap.Zoom + 1;
            }
            else if (e.KeyChar == '-')
            {
                gmap.Zoom = gmap.Zoom - 1;
            }
        }

        private void SetCordinates_Click(object sender, EventArgs e)
        {
            try
            {
                double lat = double.Parse(latitude.Text);
                double lng = double.Parse(longitude.Text);

                gmap.Position = new PointLatLng(lat, lng);
            }
            catch (Exception ex)
            {
                MessageBox.Show("incorrect coordinate format: " + ex.Message);
            }
        }

         private void gmap_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);

            double X = gmap.FromLocalToLatLng(e.X, e.Y).Lng;
            double Y = gmap.FromLocalToLatLng(e.X, e.Y).Lat;

            string longitudee = X.ToString();
            string latitudee = Y.ToString();
            longitude.Text = longitudee;
            latitude.Text = latitudee;
        }

        private void Mode_DropDownClosed(object sender, EventArgs e)
        {
            gmap.Manager.Mode = (AccessMode)Mode.SelectedValue;
            gmap.ReloadMap();
        }

        private void comboBoxMapType_DropDownClosed(object sender, EventArgs e)
        {
            gmap.MapProvider = comboBoxMapType.SelectedItem as GMapProvider;
            gmap.ReloadMap();
        }
    }
}
