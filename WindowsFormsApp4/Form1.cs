using System;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace FormProject
{
    public partial class FormNikah : Form
    {
        private readonly NikahEntities nikahEntities;
        readonly Planning planning;
        readonly BrideMale brideMale;
        readonly BrideFemale brideFemale;

        readonly MaleFather maleFather;
        readonly MaleMother maleMother;
        readonly FemaleFather femaleFather;
        readonly FemaleMother femaleMother;
        readonly Saksi saksi;
        
        public FormNikah() 
        {
            InitializeComponent();
            nikahEntities = new NikahEntities();
            planning = new Planning();
            brideMale = new BrideMale();
            maleFather = new MaleFather();
            maleMother = new MaleMother();

            brideFemale = new BrideFemale();
            femaleFather = new FemaleFather();
            femaleMother = new FemaleMother();
            saksi = new Saksi();
        }

        private void GoToDataPriaBtn(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(wedDetail.Text) || string.IsNullOrWhiteSpace(weddingAddress.Text)
                    || string.IsNullOrWhiteSpace(weddingDescription.Text) || weddingDate.Value <= DateTime.Now

                )
            {
                MessageBox.Show("Masukkan input yang benar");
            }
            else
            {
                c1.Checked = c1.Enabled = true;
                listPages.SetPage(dataPria);
            }
        }

        private void GoToDataOrtuPriaBtn(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(maleCivilID.Text) || string.IsNullOrWhiteSpace(maleFullName.Text)
                || string.IsNullOrWhiteSpace(maleBornPlace.Text) || maleBirthDate.Value >= DateTime.Now

                )
            {
                MessageBox.Show("Input Data Kependudukan dengan Benar");
            }


            else if (string.IsNullOrWhiteSpace(maleCivil.Text) || string.IsNullOrWhiteSpace(maleHomeAddress.Text)
                    || string.IsNullOrWhiteSpace(maleProvince.Text) || string.IsNullOrWhiteSpace(malePhone.Text)
                    || maleReligion.SelectedItem == null || maleCivil.SelectedItem == null || string.IsNullOrWhiteSpace(malePostalCode.Text)
                    || string.IsNullOrWhiteSpace(maleCity.Text)

                )
            {
                MessageBox.Show("Input Data Pribadi dengan Benar");
            }
            else
            {
                listPages.SetPage(dataOrtuPria);
                if (progress1.Value < 50)
                {
                    progress1.Value += 50;
                }
            }

            //String agamaPria = maleReligion.Items[maleReligion.SelectedIndex].ToString();
            //System.Diagnostics.Debug.WriteLine(agamaPria);

        }

        private void GoBackToWedDetail(object sender, EventArgs e)
        {
            listPages.SetPage(wedDetail);
        }

        private void GoToDataWanita(object sender, EventArgs e)
        {
            //Check Data Orang Tua Ayah Pengantin Pria
            if (string.IsNullOrWhiteSpace(maleFatherID.Text) || string.IsNullOrWhiteSpace(maleFatherName.Text)
                || string.IsNullOrWhiteSpace(maleFatherBornPlace.Text) || maleFatherBirthDate.Value >= DateTime.Now
                || maleFatherReligion.SelectedItem == null || maleFatherCivil.SelectedItem == null
                )
            {
                MessageBox.Show("Masukkan Data Ayah yang Benar");
            }

            //Check Data Orang Tua Ibu Pengantin Pria
            else if (string.IsNullOrWhiteSpace(maleMotherID.Text) || string.IsNullOrWhiteSpace(maleMotherName.Text)
                || string.IsNullOrWhiteSpace(maleMotherBornPlace.Text) || maleMotherBirthDate.Value >= DateTime.Now
                || maleMotherReligion.SelectedItem == null || maleMotherCivil.SelectedItem == null
                )
            {
                MessageBox.Show("Masukkan Data Ibu yang Benar");
            }
            else
            {
                progress1.Value += 50;
                c2.Checked = c2.Enabled = true;
                listPages.SetPage(dataWanita);
            }
        }

        private void GoBackToPriaBtn(object sender, EventArgs e)
        {
            listPages.SetPage(dataPria);
        }

        private void GoBackToOrtuPriaBtn(object sender, EventArgs e)
        {
            listPages.SetPage(dataOrtuPria);
        }

        private void GoToDataOrtuWanita(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(femaleID.Text) || string.IsNullOrWhiteSpace(femaleFullName.Text)
                    || string.IsNullOrWhiteSpace(femaleBirthPlace.Text) || femaleBirthDate.Value >= DateTime.Now

                 )
            {
                MessageBox.Show("Input Data Kependudukan dengan Benar");
            }
            else if (string.IsNullOrWhiteSpace(femaleCivil.Text) || string.IsNullOrWhiteSpace(femaleAddress.Text)
                    || string.IsNullOrWhiteSpace(femaleProvince.Text) || string.IsNullOrWhiteSpace(femalePhone.Text)
                    || femaleReligion.SelectedItem == null || femaleCivil.SelectedItem == null || string.IsNullOrWhiteSpace(femalePostal.Text)
                    || string.IsNullOrWhiteSpace(femaleCity.Text)
                )
            {
                MessageBox.Show("Input Data Pribadi dengan Benar");
            }
            else
            {
                listPages.SetPage(dataOrtuWanita);
                if (progress2.Value < 50)
                {
                    progress2.Value += 50;
                }
            }
        }

        private void GoToDataSaksiBtn(object sender, EventArgs e)
        {
            //Check Data Orang Tua Ayah Pengantin Wanita
            if (string.IsNullOrWhiteSpace(femaleFatherID.Text) || string.IsNullOrWhiteSpace(femaleFatherName.Text)
                || string.IsNullOrWhiteSpace(femaleFatherBirthPlace.Text) || femaleFatherBirthDate.Value >= DateTime.Now
                || femaleFatherReligion.SelectedItem == null || femaleFatherCivil.SelectedItem == null
                )
            {
                MessageBox.Show("Masukkan Data Ayah yang Benar");
            }

            //Check Data Orang Tua Ibu Pengantin Wanita
            if (string.IsNullOrWhiteSpace(femaleMotherID.Text) || string.IsNullOrWhiteSpace(femaleMotherName.Text)
                || string.IsNullOrWhiteSpace(femaleMotherBirthPlace.Text) || femaleMotherBirthDate.Value >= DateTime.Now
                || femaleMotherReligion.SelectedItem == null || femaleMotherCivil.SelectedItem == null
                )
            {
                MessageBox.Show("Masukkan Data Ibu yang Benar");
            }
            else
            {
                c3.Checked = c3.Enabled = true;
                progress2.Value += 50;
                listPages.SetPage(dataSaksi);
            }
        }

        private void GoBackToDataWanita(object sender, EventArgs e)
        {
            listPages.SetPage(dataWanita);
        }

        private void GoToFinishPage(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstWitnessName.Text) || string.IsNullOrWhiteSpace(firstWitnessHome.Text)
                 || string.IsNullOrWhiteSpace(firstWitnessCity.Text) || string.IsNullOrWhiteSpace(firstWitnessPostal.Text) ||
                 string.IsNullOrWhiteSpace(firstWitnessPostal.Text) || string.IsNullOrWhiteSpace(firstWitnessProvince.Text) ||
                 string.IsNullOrWhiteSpace(firstWitnessNickname.Text)
                )
            {
                MessageBox.Show("Input data saksi pertama dengan benar");
            }

            else if (string.IsNullOrWhiteSpace(secondWitnessName.Text) || string.IsNullOrWhiteSpace(secondWitnessHome.Text)
                    || string.IsNullOrWhiteSpace(secondWitnessCity.Text) || string.IsNullOrWhiteSpace(secondWitnessPostal.Text) ||
                    string.IsNullOrWhiteSpace(secondWitnessPostal.Text) || string.IsNullOrWhiteSpace(secondWitnessProvince.Text)
                    || string.IsNullOrWhiteSpace(secondWitnessNickname.Text)
                    )
            {
                MessageBox.Show("Input data saksi kedua dengan benar");
            }
            else
            {
                progress3.Value += 100;
                c4.Checked = c4.Enabled = true;
                listPages.SetPage(finishPage);
            }
        }

        private void GoBackToDataSaksi(object sender, EventArgs e)
        {
            listPages.SetPage(dataSaksi);
        }

        private void FinishBtn(object sender, EventArgs e)
        {
            //Wedding Planning
            String alamatNikah = weddingAddress.Text;
            String teleponNikah = weddingPhone.Text;
            var tanggalNikah = weddingDate.Value;
            String deskripsiNikah = weddingDescription.Text;

            //Broombride Data
            String nomorIDPria = maleCivilID.Text;
            String namaPria = maleFullName.Text;
            String tempatLahirPria = maleBornPlace.Text;
            var tanggalLahirPria = maleBirthDate.Value;

            ////Broombride Data Lifestyle
            String alamatPria = maleHomeAddress.Text + ", " + maleCity.Text + ", " + malePostalCode + ", " +
                maleProvince.Text;
            String teleponPria = malePhone.Text;
            String agamaPria = maleReligion.Items[maleReligion.SelectedIndex].ToString();
            String kewarganegaraanPria = maleCivil.Items[maleCivil.SelectedIndex].ToString();
            String pekerjaanPria = maleWork.Text;

            //Broombride Parent Data
            ///Father
            String nomorIDAyahPria = maleFatherID.Text;
            String namaAyahPria = maleFatherName.Text;
            String tempatLahirAyahPria = maleFatherBornPlace.Text;
            var tanggalLahirAyahPria = maleFatherBirthDate.Value;

            String kewarganegaraanAyahPria = maleFatherCivil.Items[maleFatherCivil.SelectedIndex].ToString();
            String agamaAyahPria = maleFatherReligion.Items[maleFatherReligion.SelectedIndex].ToString();

            ///Mother
            String nomorIDIbuPria = maleMotherID.Text;
            String namaIbuPria = maleMotherName.Text;
            String tempatLahirIbuPria = maleMotherBornPlace.Text;
            var tanggalLahirIbuPria = maleMotherBirthDate.Value;

            String kewarganegaraanIbuPria = maleMotherCivil.Items[maleMotherCivil.SelectedIndex].ToString();
            String agamaIbuPria = maleMotherReligion.SelectedItem.ToString();

            //Bride Data
            String nomorIDWanita = femaleID.Text;
            String namaWanita = femaleFullName.Text;
            String tempatLahirWanita = femaleBirthPlace.Text;
            var tanggalLahirWanita = femaleBirthDate.Value;

            //Bride Data Lifestyle
            String alamatWanita = femaleAddress.Text + ", " + femaleCity.Text + ", " + femalePostal + ", " +
                femaleProvince.Text;
            String teleponWanita = femalePhone.Text;
            String agamaWanita = femaleReligion.Items[femaleReligion.SelectedIndex].ToString();
            String kewarganegaraanWanita = femaleCivil.Items[femaleCivil.SelectedIndex].ToString();
            String pekerjaanWanita = femaleWork.Text;

            //Bride Parent Data
            ///Father
            String nomorIDAyahWanita = femaleFatherID.Text;
            String namaAyahWanita = femaleFatherName.Text;
            String tempatLahirAyahWanita = femaleFatherBirthPlace.Text;
            var tanggalLahirAyahWanita = femaleFatherBirthDate.Value;

            String kewarganegaraanAyahWanita = femaleFatherCivil.Items[femaleFatherCivil.SelectedIndex].ToString();
            String agamaAyahWanita = femaleFatherReligion.Items[femaleFatherReligion.SelectedIndex].ToString();

            ///Mother
            String nomorIDIbuWanita = femaleMotherID.Text;
            String namaIbuWanita = femaleMotherName.Text;
            String tempatLahirIbuWanita = femaleMotherBirthPlace.Text;
            var tanggalLahirIbuWanita = femaleMotherBirthDate.Value;

            String kewarganegaraanIbuWanita = femaleMotherCivil.Items[femaleMotherCivil.SelectedIndex].ToString();
            String agamaIbuWanita = femaleMotherReligion.Items[femaleMotherReligion.SelectedIndex].ToString();

            //Saksi
            ///Saksi Pertama
            String namaSaksiPertama = firstWitnessName.Text;
            String alamatSaksiPertama = firstWitnessHome.Text + ", " + firstWitnessCity.Text + ", " + firstWitnessPostal.Text + ", " +
                                        firstWitnessProvince.Text;

            String catatSaksiPertama = greetingFirstWitness.Items[greetingFirstWitness.SelectedIndex].ToString() 
                + " " + firstWitnessNickname.Text; 

            ///Saksi Kedua
            String namaSaksiKedua = secondWitnessName.Text;
            String alamatSaksiKedua = secondWitnessHome.Text + ", " + secondWitnessCity.Text + ", " + secondWitnessPostal.Text + ", " +
                                        secondWitnessProvince.Text;

            String catatSaksiKedua = greetingSecondWitness.Items[greetingSecondWitness.SelectedIndex].ToString() +
                " " + secondWitnessNickname.Text;

            if (toggleAgree.Value == true)
            {
                progress4.Value += 100;
                c5.Checked = c5.Enabled = true;

                planning.NikahAddress = alamatNikah;
                planning.NikahDate = tanggalNikah;
                planning.NikahPhone = teleponNikah;
                planning.NikahDescription = deskripsiNikah;

                planning.PasanganPria = nomorIDPria;
                planning.PasanganWanita = nomorIDWanita;

                planning.CatatSaksiSatu = catatSaksiPertama;
                planning.CatatSaksiDua = catatSaksiKedua; 

                //[1] Data Pengantin Pria
                brideMale.PriaNIK = nomorIDPria;
                brideMale.PriaName = namaPria;
                brideMale.PriaBirthPlace = tempatLahirPria;
                brideMale.PriaBirthDate = tanggalLahirPria;

                brideMale.PriaAddress = alamatPria;
                brideMale.PriaPhone = teleponPria;
                brideMale.PriaCivil = kewarganegaraanPria;
                brideMale.PriaReligion = agamaPria;
                brideMale.PriaWork = pekerjaanPria;
                /// Data Orang Tuanya
                brideMale.MaleFatherNIK = nomorIDAyahPria;
                brideMale.MaleMotheNIK = nomorIDIbuPria;

                //Data Ayah Pengantin Pria
                maleFather.PriaFatherNIK = nomorIDAyahPria;
                maleFather.PriaFatherName = namaAyahPria;
                maleFather.PriaFatherBirthPlace = tempatLahirAyahPria;
                maleFather.PriaFatherBirthDate = tanggalLahirAyahPria;

                maleFather.PriaFatherCivil = kewarganegaraanAyahPria;
                maleFather.PriaFatherReligion = agamaAyahPria;

                //Data Ibu Pengantin Pria
                maleMother.PriaMotherNIK = nomorIDIbuPria;
                maleMother.PriaMotherName = namaIbuPria;
                maleMother.PriaMotherBirthPlace = tempatLahirIbuPria;
                maleMother.PriaMotherBirthDate = tanggalLahirIbuPria;

                maleMother.PriaMotherCivil = kewarganegaraanIbuPria;
                maleMother.PriaMotherReligion = agamaIbuPria;

                //[2] Data Pengantin wanita
                brideFemale.FemaleNIK = nomorIDWanita;
                brideFemale.FemaleName = namaWanita;
                brideFemale.FemaleBirthPlace = tempatLahirWanita;
                brideFemale.FemaleBirthDate = tanggalLahirWanita;

                brideFemale.FemaleAddress = alamatWanita;
                brideFemale.FemalePhone = teleponWanita;
                brideFemale.FemaleCivil = kewarganegaraanWanita;
                brideFemale.FemaleReligion = agamaWanita;
                brideFemale.FemaleWork = pekerjaanWanita;

                ///Data Orang tuanya
                brideFemale.FemaleFatherNIK = nomorIDAyahWanita;
                brideFemale.FemaleMotherNIK = nomorIDIbuWanita;

                //Data Ayah Pengantin Wanita
                femaleFather.WanitaFatherNIK = nomorIDAyahWanita;
                femaleFather.WanitaFatherName = namaAyahWanita;
                femaleFather.WanitaFatherBirthPlace = tempatLahirAyahWanita;
                femaleFather.WanitaFatherBirthDate = tanggalLahirAyahWanita;

                femaleFather.WanitaFatherCivil = kewarganegaraanAyahWanita;
                femaleFather.WanitaFatherReligion = agamaAyahWanita;

                //Data Ibu Pengantin Wanita
                femaleMother.WanitaMotherNIK = nomorIDIbuWanita;
                femaleMother.WanitaMotherName = namaIbuWanita;
                femaleMother.WanitaMotherBirthPlace = tempatLahirIbuWanita;
                femaleMother.WanitaMotherBirthDate = tanggalLahirIbuWanita;

                femaleMother.WanitaMotherCivil = kewarganegaraanIbuWanita;
                femaleMother.WanitaMotherReligion = agamaIbuWanita;


                //[3]Data Saksi
                saksi.SaksiSatuName = namaSaksiPertama;
                saksi.SaksiSatuAddress = alamatSaksiPertama;
                saksi.SaksiDuaName = namaSaksiKedua;
                saksi.SaksiDuaAddress = alamatSaksiKedua;


                //Masukkan ke database
                nikahEntities.Plannings.Add(planning);
                nikahEntities.BrideMales.Add(brideMale);
                nikahEntities.BrideFemales.Add(brideFemale);
                nikahEntities.MaleFathers.Add(maleFather);
                nikahEntities.MaleMothers.Add(maleMother);

                nikahEntities.FemaleFathers.Add(femaleFather);
                nikahEntities.FemaleMothers.Add(femaleMother);

                nikahEntities.Saksis.Add(saksi);

                nikahEntities.SaveChanges();

                
                FinishForm finishForm = new FinishForm();
                finishForm.ShowDialog();

            }
        }

        private void FormNikah_Load(object sender, EventArgs e)
        {

            progress1.MaximumValue = 100;
            progress2.MaximumValue = 100;
            progress3.MaximumValue = 100;
            progress4.MaximumValue = 100;
        }

    }
}
