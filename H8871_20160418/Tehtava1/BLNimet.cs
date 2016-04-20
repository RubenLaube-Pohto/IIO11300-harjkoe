using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JAMK.ICT
{
    public static class NimiPaivat
    {
        #region kuukaudet
        static string[] tammikuu;
        static string[] helmikuu;
        static string[] maaliskuu;
        static string[] huhtikuu;
        static string[] toukokuu;
        static string[] kesäkuu;
        static string[] heinäkuu;
        static string[] elokuu;
        static string[] syyskuu;
        static string[] lokakuu;
        static string[] marraskuu;
        static string[] joulukuu;
        #endregion
        public static string HaeNimiPäivä(int paiva, int kuukausi)
        {
            string nimet = "";
            AsetaNimet();
            switch (kuukausi)
            {
                case 1: { nimet = tammikuu[paiva]; } break;
                case 2: { nimet = helmikuu[paiva]; } break;
                case 3: { nimet = maaliskuu[paiva]; } break;
                case 4: { nimet = huhtikuu[paiva]; } break;
                case 5: { nimet = toukokuu[paiva]; } break;
                case 6: { nimet = kesäkuu[paiva]; } break;
                case 7: { nimet = heinäkuu[paiva]; } break;
                case 8: { nimet = elokuu[paiva]; } break;
                case 9: { nimet = syyskuu[paiva]; } break;
                case 10: { nimet = lokakuu[paiva]; } break;
                case 11: { nimet = marraskuu[paiva]; } break;
                case 12: { nimet = joulukuu[paiva]; } break;
                default:
                    break;
            }
            return nimet;
        }

        public static string GetDate(string name)
        {
            AsetaNimet();
            Regex regex = new Regex(name);
            for (int i = 1; i <= 12; i++)
            {
                switch (i)
                {
                    case 1:
                        {
                            for (int j = 0; j < tammikuu.Length; j++)
                            {
                                if (regex.IsMatch(tammikuu[j]))
                                {
                                    return (j + 1) + "." + i + ".";
                                }
                            }
                        }
                        break;
                    case 2:
                        {
                            for (int j = 0; j < helmikuu.Length; j++)
                            {
                                if (regex.IsMatch(helmikuu[j]))
                                {
                                    return (j + 1) + "." + i + ".";
                                }
                            }
                        }
                        break;
                    case 3:
                        {
                            for (int j = 0; j < maaliskuu.Length; j++)
                            {
                                if (regex.IsMatch(maaliskuu[j]))
                                {
                                    return (j + 1) + "." + i + ".";
                                }
                            }
                        }
                        break;
                    case 4:
                        {
                            for (int j = 0; j < huhtikuu.Length; j++)
                            {
                                if (regex.IsMatch(huhtikuu[j]))
                                {
                                    return (j + 1) + "." + i + ".";
                                }
                            }
                        }
                        break;
                    case 5:
                        {
                            for (int j = 0; j < toukokuu.Length; j++)
                            {
                                if (regex.IsMatch(toukokuu[j]))
                                {
                                    return (j + 1) + "." + i + ".";
                                }
                            }
                        }
                        break;
                    case 6:
                        {
                            for (int j = 0; j < kesäkuu.Length; j++)
                            {
                                if (regex.IsMatch(kesäkuu[j]))
                                {
                                    return (j + 1) + "." + i + ".";
                                }
                            }
                        }
                        break;
                    case 7:
                        {
                            for (int j = 0; j < heinäkuu.Length; j++)
                            {
                                if (regex.IsMatch(heinäkuu[j]))
                                {
                                    return (j + 1) + "." + i + ".";
                                }
                            }
                        }
                        break;
                    case 8:
                        {
                            for (int j = 0; j < elokuu.Length; j++)
                            {
                                if (regex.IsMatch(elokuu[j]))
                                {
                                    return (j + 1) + "." + i + ".";
                                }
                            }
                        }
                        break;
                    case 9:
                        {
                            for (int j = 0; j < syyskuu.Length; j++)
                            {
                                if (regex.IsMatch(syyskuu[j]))
                                {
                                    return (j + 1) + "." + i + ".";
                                }
                            }
                        }
                        break;
                    case 10:
                        {
                            for (int j = 0; j < lokakuu.Length; j++)
                            {
                                if (regex.IsMatch(lokakuu[j]))
                                {
                                    return (j + 1) + "." + i + ".";
                                }
                            }
                        }
                        break;
                    case 11:
                        {
                            for (int j = 0; j < marraskuu.Length; j++)
                            {
                                if (regex.IsMatch(marraskuu[j]))
                                {
                                    return (j + 1) + "." + i + ".";
                                }
                            }
                        }
                        break;
                    case 12:
                        {
                            for (int j = 0; j < joulukuu.Length; j++)
                            {
                                if (regex.IsMatch(joulukuu[j]))
                                {
                                    return (j + 1) + "." + i + ".";
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            return "Nimellä ei löytynyt päivää.";
        }

        private static void AsetaNimet()
        {
            #region tammikuu
            tammikuu = new string[31];
            tammikuu[0] = "Uudenvuodenpäivä";
            tammikuu[1] = "Aapeli, Gerhard ja Gert";
            tammikuu[2] = "Elmeri, Elmer, Elmo, ja Helmer";
            tammikuu[3] = "Ruut ja Rut";
            tammikuu[4] = "Lea ja Leea";
            tammikuu[5] = "Harri, Harry ja Harriet";
            tammikuu[6] = "Aukusti, Aku, August ja Augusta";
            tammikuu[7] = "Hilppa, Titta ja Gunnar";
            tammikuu[8] = "Veikko, Veli, Veijo ja Bror";
            tammikuu[9] = "Nyyrikki ja Sigrud";
            tammikuu[10] = "Kari, Karri ja Osvald";
            tammikuu[11] = "Toini ja Eivor";
            tammikuu[12] = "Nuutti ja Knut";
            tammikuu[13] = "Sakari, Saku ja Zacharias";
            tammikuu[14] = "Solja ja Doris";
            tammikuu[15] = "Ilmari, Ilmo, Gudmund ja Germund";
            tammikuu[16] = "Toni, Anttoni, Antto, Anton, Tony ja Antonia";
            tammikuu[17] = "Laura";
            tammikuu[18] = "Heikki, Henrik, Henrikki, Henri, Henry, Henrika ja Henrietta";
            tammikuu[19] = "Henna, Henni, Henriikka, Sebastian ja Fabian";
            tammikuu[20] = "Aune, Oona, Auni, Agnes ja Agneta";
            tammikuu[21] = "Visa ja Fridolf";
            tammikuu[22] = "Eine, Eini, Enni, Ingegerd ja Ingela";
            tammikuu[23] = "Senja ja Jari";
            tammikuu[24] = "Paavo, Pauli, Paavali ja Paul";
            tammikuu[25] = "Joonatan ja Jonatan";
            tammikuu[26] = "Viljo ja Folke";
            tammikuu[27] = "Kaarlo, Kalle, Kaarle, Mies, Karl ja Carola";
            tammikuu[28] = "Valtteri, Valter ja Volter";
            tammikuu[29] = "Irja, Gunnel ja Gunilla";
            tammikuu[30] = "Alli, Alfhild ja Alfa";
            #endregion
            #region helmikuu
            helmikuu = new string[29];
            helmikuu[0] = "Riitta ja Berit";
            helmikuu[1] = "Aamu, Jemina ja Disa";
            helmikuu[2] = "Valo ja Hugo";
            helmikuu[3] = "Armi, Ronja ja My";
            helmikuu[4] = "Asser ja Ture";
            helmikuu[5] = "Terhi, Teija, Tiia, Tea, Terhikki, Dorotea, Dora ja Dorrit";
            helmikuu[6] = "Riku, Rikhard, Rikard ja Dick";
            helmikuu[7] = "Laina ja Rigmor";
            helmikuu[8] = "Raija, Raisa ja Bodil";
            helmikuu[9] = "Elina, Elna, Ella, Ellen ja Elin";
            helmikuu[10] = "Talvikki, Isabella ja Isa";
            helmikuu[11] = "Elma ja Elmi";
            helmikuu[12] = "Sulo, Sulho ja Algot";
            helmikuu[13] = "Voitto, Valentin ja Tino";
            helmikuu[14] = "Sipi, Sippo ja Sigfrid";
            helmikuu[15] = "Kai ja Kaj";
            helmikuu[16] = "Väinö, Väinämö, Carita ja Rita";
            helmikuu[17] = "Kaino ja Tyra";
            helmikuu[18] = "Eija ja Fritjof";
            helmikuu[19] = "Heli, Helinä, Heljä, Hely ja Ragnborg";
            helmikuu[20] = "Keijo, Alf ja Alva";
            helmikuu[21] = "Tuulikki, Tuuli, Tuulia, Hildur ja Hilda";
            helmikuu[22] = "Aslak ja Bjarne";
            helmikuu[23] = "Matti, Mattias, Mattias ja Mats";
            helmikuu[24] = "Tuija, Tuire ja Jessica";
            helmikuu[25] = "Nestori, Ingvar ja Ingvald";
            helmikuu[26] = "Torsti ja Torsten";
            helmikuu[27] = "Onni, Rune ja Runa";
            helmikuu[28] = "Ei kukaan, koska on karkauspäivä";
            #endregion
            #region maaliskuu
            maaliskuu = new string[31];
            maaliskuu[0] = "Alpo, Alvi, Alpi ja Albin";
            maaliskuu[1] = "Virve, Virva ja Fanny";
            maaliskuu[2] = "Kauko ja Torbjörn";
            maaliskuu[3] = "Ari, Arsi, Atro, Adrian ja Atle";
            maaliskuu[4] = "Laila ja Leila";
            maaliskuu[5] = "Tarmo, Rudolf ja Rolf";
            maaliskuu[6] = "Tarja, Taru ja Gudrun";
            maaliskuu[7] = "Vilppu, Filip ja Filippa";
            maaliskuu[8] = "Auvo ja Edvin";
            maaliskuu[9] = "Aurora, Aura ja Auri";
            maaliskuu[10] = "Kalervo, Torgny ja Torkel";
            maaliskuu[11] = "Reijo, Reko, Gregorius, Greger ja Grels";
            maaliskuu[12] = "Erno, Tarvo, Ernesti ja Ernst";
            maaliskuu[13] = "Matilda ja Tilda";
            maaliskuu[14] = "Risto ja Kristoffer";
            maaliskuu[15] = "Ilkka ja Herbert";
            maaliskuu[16] = "Kerttu, Kerttuli, Gertrud ja Trude";
            maaliskuu[17] = "Eetu ja Edvard";
            maaliskuu[18] = "Jooseppi, Juuso, Joosef, Josefiina, Josef ja Josefina";
            maaliskuu[19] = "Aki, Joakim ja Kim";
            maaliskuu[20] = "Pentti, Bengt, Bengta ja Benita";
            maaliskuu[21] = "Vihtori, Viktor ja Viktoria";
            maaliskuu[22] = "Akseli ja Axel";
            maaliskuu[23] = "Kaapo, Gabriel, Kaapro, Kaappo ja Gabriella";
            maaliskuu[24] = "Aija, Gunvor ja Gunnevi";
            maaliskuu[25] = "Manu,  Immanuel, Manne, Immo ja Emanuel";
            maaliskuu[26] = "Sauli, Saul ja Torvald";
            maaliskuu[27] = "Armas ja Sune";
            maaliskuu[28] = "Joonas, Jouni, Joni Joona, Jonne, Jonni ja Jonas";
            maaliskuu[29] = "Usko, Tage ja Guy";
            maaliskuu[30] = "Irma, Irmeli ja Irmelin";
            #endregion
            #region huhtikuu
            huhtikuu = new string[30];
            huhtikuu[0] = "Raita, Pulmu ja Harald";
            huhtikuu[1] = "Pellervo ja Vidar";
            huhtikuu[2] = "Sampo ja Ferdinand";
            huhtikuu[3] = "Ukko ja Odin";
            huhtikuu[4] = "Irene, Irina, Ira, ja Iro";
            huhtikuu[5] = "Vilho, Ville, Viljami, Vilhelm, Vili, Jami ja William";
            huhtikuu[6] = "Allan ja Ahvo";
            huhtikuu[7] = "Suoma, Suometar ja Rea";
            huhtikuu[8] = "Elias, Eelis, Eljas ja Eliel";
            huhtikuu[9] = "Tero ja Tryggve";
            huhtikuu[10] = "Verna";
            huhtikuu[11] = "Julius, Julia, Juliaana ja Juliana";
            huhtikuu[12] = "Tellervo ja Etel";
            huhtikuu[13] = "Taito ja Ruben";
            huhtikuu[14] = "Linda, Tuomi ja Linn";
            huhtikuu[15] = "Jalo, Patrik ja Patricia";
            huhtikuu[16] = "Otto";
            huhtikuu[17] = "Valto, Valdemar ja Volmar";
            huhtikuu[18] = "Päivi, Pilvi, Bernhard ja Bernt";
            huhtikuu[19] = "Lauha ja Arla";
            huhtikuu[20] = "Anssi, Anselmi ja Camilla";
            huhtikuu[21] = "Alina";
            huhtikuu[22] = "Yrjö, Jyrki, Jyri, Yrjänä, Jori, Georg, Göran, Örjan, Jöran, Jörgen ja Jörn";
            huhtikuu[23] = "Pertti, Albert, Altti ja Albertina";
            huhtikuu[24] = "Markku, Markus ja Marko";
            huhtikuu[25] = "Terttu, Teresa, Teresia ja Terese";
            huhtikuu[26] = "Merja, Engelbrekt ja Engelbert";
            huhtikuu[27] = "Ilpo, Ilppo, Tuure ja Ture";
            huhtikuu[28] = "Teijo ja Henning";
            huhtikuu[29] = "Mirja, Mirva, Mira, Miia, Mia, Mirjami, Mirka ja Mirkka";
            #endregion
            #region toukokuu
            toukokuu = new string[31];
            toukokuu[0] = "Vappu, Valpuri ja Valborg";
            toukokuu[1] = "Vuokko, Viivi, Vivan ja Vivi";
            toukokuu[2] = "Outi ja Linus";
            toukokuu[3] = "Ruusu, Roosa ja Rosa";
            toukokuu[4] = "Maini ja Ulrik";
            toukokuu[5] = "Ylermi, Frej, Frejvid ja Freja";
            toukokuu[6] = "Helmi, Kastehelmi ja Tua";
            toukokuu[7] = "Heino ja Åke";
            toukokuu[8] = "Timo ja Dennis";
            toukokuu[9] = "Aino, Aina, Aini ja Ainikki";
            toukokuu[10] = "Osmo, Kennet, Kent";
            toukokuu[11] = "Lotta, Charlotta ja Lotten";
            toukokuu[12] = "Kukka, Floora ja Flora";
            toukokuu[13] = "Tuula ja Edit";
            toukokuu[14] = "Sofia, Sonja ja Sohvi";
            toukokuu[15] = "Esteri, Essi ja Ester";
            toukokuu[16] = "Maila, Maili, Mailis, Rebekka, Rebecka ja Hagar";
            toukokuu[17] = "Erkki, Eero, Eerikki, Eerika, Erik, Jerker ja Erika";
            toukokuu[18] = "Emilia, Emma, Emmi, Milla, Milja, Milka, Amalia ja Mili";
            toukokuu[19] = "Lilja, Karoliina, Lilli ja Lilian";
            toukokuu[20] = "Kosti, Konsta, Konstantin ja Conny";
            toukokuu[21] = "Hemminki, Hemmo ja Hemming";
            toukokuu[22] = "Lyydia, Lyyli ja Lydia";
            toukokuu[23] = "Tuukka, Touko ja Alarik";
            toukokuu[24] = "Urpo ja Urban";
            toukokuu[25] = "Vilhelmiina, Minna, Vilma, Miina, Mimmi ja Vilhelmina";
            toukokuu[26] = "Ritva ja Ingeborg";
            toukokuu[27] = "Alma";
            toukokuu[28] = "Oiva, Oivi, Olivia, Orvar, Oliver ja Olivia";
            toukokuu[29] = "Pasi ja Rurik";
            toukokuu[30] = "Helka, Helga ja Helge";
            #endregion
            #region kesäkuu
            kesäkuu = new string[30];
            kesäkuu[0] = "Teemu, Nikodemus ja Rabbe";
            kesäkuu[1] = "Venla ja Vendla";
            kesäkuu[2] = "Orvokki ja Viola";
            kesäkuu[3] = "Toivo ja Selim";
            kesäkuu[4] = "Sulevi ja Stig";
            kesäkuu[5] = "Kustaa, Kyösti, Kustavi, Gustav, Gösta, Gustava";
            kesäkuu[6] = "Suvi, Robert, Roope, Robert ja Robin";
            kesäkuu[7] = "Salomo, Salomon, Kjell ja Kettil";
            kesäkuu[8] = "Ensio ja Daga";
            kesäkuu[9] = "Seppo ja Svante";
            kesäkuu[10] = "Impi, Immi ja Hjördis";
            kesäkuu[11] = "Esko ja Eskil";
            kesäkuu[12] = "Raili, Raila, Åsa ja Aslög";
            kesäkuu[13] = "Kielo ja Tord";
            kesäkuu[14] = "Vieno ja Viena, Mona, Monika";
            kesäkuu[15] = "Päivi, Päivikki, Päivä ja Eugen";
            kesäkuu[16] = "Urho, Birger ja Börje";
            kesäkuu[17] = "Tapio ja Ingolf";
            kesäkuu[18] = "Siiri, Sigri ja Siri";
            kesäkuu[19] = "Into ja Inga";
            kesäkuu[20] = "Ahti, Ahto, Ingemar, Ingmar ja Inge";
            kesäkuu[21] = "Paula, Liina, Pauliina, Paulina ja Lina";
            kesäkuu[22] = "Aatto, Aatu, Aadolf ja Adolf";
            kesäkuu[23] = "Johannes, Juhani, Juha, Juho, Jukka, Jussi, Janne, Jani, Juhana, Johannes, Johan, Jan, Jon, John, Johny ja Jens";
            kesäkuu[24] = "Uuno ja Uno";
            kesäkuu[25] = "Jorma, Jarmo, Jarkko, Jarno, Jere, Jeremias ja Viveka";
            kesäkuu[26] = "Elviira, Elvi ja Elvira";
            kesäkuu[27] = "Leo ja Leopold";
            kesäkuu[28] = "Pietari, Pekka, Petri, Petra, Petteri, Pekko, Peter, Per, Petter, Petra ja Pernilla";
            kesäkuu[29] = "Päiviö, Päivö ja Leif";
            #endregion
            #region heinäkuu
            heinäkuu = new string[31];
            heinäkuu[0] = "Aaro, Aaron ja Kasimir";
            heinäkuu[1] = "Maria, Mari, Maija, Meeri, Maaria, Marika, Maiju, Maikki, Kukka-Maaria, Maja, Maj ja Mary";
            heinäkuu[2] = "Arvo, Egil, Ejvind ja Öjvind";
            heinäkuu[3] = "Ulla, Ulpu ja Ulrika";
            heinäkuu[4] = "Unto, Untamo ja Ulf";
            heinäkuu[5] = "Esa, Esaias ja Halvar";
            heinäkuu[6] = "Klaus, Launo ja Klas";
            heinäkuu[7] = "Turo, Turkka, Tor, Tore ja Tora";
            heinäkuu[8] = "Ilta, Jasmin, Nanna ja Nanny";
            heinäkuu[9] = "Saima ja Saimi";
            heinäkuu[10] = "Elli, Noora, Nelli, Eleonoora, Eleonora, Nora, Leonora ja Elinor";
            heinäkuu[11] = "Hermanni, Herkko ja Herman";
            heinäkuu[12] = "Ilari, Lari ja Joel";
            heinäkuu[13] = "Aliisa ja Alice";
            heinäkuu[14] = "Rauni, Rauna, Ragnhild, Ragni ja Ragna";
            heinäkuu[15] = "Reino ja Reinhold";
            heinäkuu[16] = "Ossi ja Ossian";
            heinäkuu[17] = "Riikka, Frederik, Fred ja Frederika";
            heinäkuu[18] = "Saara, Sari, Salli, Salla, Sara ja Sally";
            heinäkuu[19] = "Marketta, Maarit, Reeta, Maaret, Reetta, Margareeta, Margereta, Margit, Marit, Greta ja Gretel";
            heinäkuu[20] = "Johanna, Hanna, Jenni, Jonna, Jenna, Hannele, Hanne, Joanna, Johanna, Jenry, Hanna ja Hannele";
            heinäkuu[21] = "Leena, Leeni, Lenita, Matleena, Magdaleena, Malin ja Lena";
            heinäkuu[22] = "Oili ja Olga";
            heinäkuu[23] = "Kristiina, Kirsti, Tina, Kirsi, Krista, Kiia, Kristina, Kerstin, Kristel, Kia, Stina ja Tina";
            heinäkuu[24] = "Jaakko, Jaakoppi, Jaakob, Jakob ja Jim";
            heinäkuu[25] = "Martta ja Marta";
            heinäkuu[26] = "Heidi";
            heinäkuu[27] = "Atso ja Håkan";
            heinäkuu[28] = "Olavi, Olli, Uolevi, Uoti, Olof, Olav, Ola, Ole ja Olle";
            heinäkuu[29] = "Asta";
            heinäkuu[30] = "Helena ja Elena";
            #endregion
            #region elokuu
            elokuu = new string[31];
            elokuu[0] = "Maire, Gerda ja Gerd";
            elokuu[1] = "Kimmo ja Holger";
            elokuu[2] = "Linnea, Nea ja Vanamo";
            elokuu[3] = "Veera ja Vera";
            elokuu[4] = "Salme, Sanelma ja Gurli";
            elokuu[5] = "Toimi, Keimo ja Sixten";
            elokuu[6] = "Lahja ja Yrsa";
            elokuu[7] = "Sylvi, Sylvia ja Silva";
            elokuu[8] = "Erja, Eira ja Natalie";
            elokuu[9] = "Lauri, Lasse, Lassi ja Lars";
            elokuu[10] = "Sanna, Sanni, Susanna ja Susanne";
            elokuu[11] = "Klaara ja Klara";
            elokuu[12] = "Jesse ja Alfons";
            elokuu[13] = "Onerva, Kanerva ja Svea";
            elokuu[14] = "Marjatta, Marja, Jaana, Marjo, Marjut, Marjaana, Marjukka, Marita, Maritta, Marianne, Marianna ja Marlene";
            elokuu[15] = "Aulis ja Brynolf";
            elokuu[16] = "Verneri, Verner ja Veronika";
            elokuu[17] = "Leevi ja Bo";
            elokuu[18] = "Mauno, Maunu, Magnus ja Måns";
            elokuu[19] = "Samuli, Sami, Samuel, Samu ja Sam";
            elokuu[20] = "Soini, Veini ja Sven";
            elokuu[21] = "Iivari, Iivo ja Ivo";
            elokuu[22] = "Varma, Signe ja Signhild";
            elokuu[23] = "Perttu, Bertel, Bertil ja Berta";
            elokuu[24] = "Loviisa, Lovisa ja Louise";
            elokuu[25] = "Ilma, Ilmi, Ilmatar, Märta ja Märit";
            elokuu[26] = "Rauli, Ralf ja Rufus";
            elokuu[27] = "Tauno ja Hilding";
            elokuu[28] = "Iines, Iina, Inari, Ines ja Ina";
            elokuu[29] = "Eemil, Eemeli ja Emil";
            elokuu[30] = "Arvi ja Arvid";
            #endregion
            #region syyskuu
            syyskuu = new string[30];
            syyskuu[0] = "Pirkka ja Gottfrid";
            syyskuu[1] = "Sinikka, Sini ja Synnöve";
            syyskuu[2] = "Soili, Soile, Soila ja Solveig";
            syyskuu[3] = "Ansa ja Roland";
            syyskuu[4] = "Roni, Mainio, Ragnvald, Ronald ja Ronny";
            syyskuu[5] = "Asko ja Felix";
            syyskuu[6] = "Miro, Arho, Arhippa, Regina ja Roy";
            syyskuu[7] = "Taimi, Göte ja Göta";
            syyskuu[8] = "Eevert, Isto ja Evert";
            syyskuu[9] = "Kalevi, Kaleva ja Östen";
            syyskuu[10] = " Aleksanteri, Santeri, Ali, Ale, Aleksandra, Alexander, Alex, Alexandra ja Sandra";
            syyskuu[11] = "Valma, Vilja ja Dagny";
            syyskuu[12] = "Orvo ja Ylva";
            syyskuu[13] = "Iida ja Ida";
            syyskuu[14] = "Sirpa ja Runar";
            syyskuu[15] = "Hellevi, Hillevi, Hille, Hilla ja Helvig";
            syyskuu[16] = "Aili, Aila, Hildegard ja Hildegerd";
            syyskuu[17] = "Tyyne, Tytti, Tyyni ja Pamela";
            syyskuu[18] = "Reija ja Torborg";
            syyskuu[19] = "Varpu, Vaula ja Erna";
            syyskuu[20] = "Mervi, Gunborg ja Gunlög";
            syyskuu[21] = "Mauri, Mauriz ja Moriz";
            syyskuu[22] = "Mielikk ja Teklai";
            syyskuu[23] = "Alvar ja Auno";
            syyskuu[24] = "Kullervo ja Sigvard";
            syyskuu[25] = "Kuisma ja Finn";
            syyskuu[26] = "Vesa ja Torolf";
            syyskuu[27] = "Arja, Leonard ja Lennart";
            syyskuu[28] = "Mikael, Mikko, Mika, Miika, Miikka, Miska ja Mikaela";
            syyskuu[29] = "Sorja, Sirja ja Roger";
            #endregion
            #region lokakuu
            lokakuu = new string[31];
            lokakuu[0] = "Rauno, Rainer, Raine, Raino, Ragnar ja Rainer";
            lokakuu[1] = "Valio ja Ludvig";
            lokakuu[2] = "Raimo ja Evald";
            lokakuu[3] = "Saila, Saija, Frans ja Frank";
            lokakuu[4] = "Inkeri, Inka, Ingrid ja Inger";
            lokakuu[5] = "Minttu, Pinja ja Bruno";
            lokakuu[6] = "Pirkko, Pirjo, Piritta, Pirita, Birgitta, Brita, Britta, Britt ja Birgit";
            lokakuu[7] = "Hilja ja Peik";
            lokakuu[8] = "Ilona ja Marina";
            lokakuu[9] = "Aleksi, Aleksis ja Alexis";
            lokakuu[10] = "Otso, Ohto ja Björn";
            lokakuu[11] = "Aarre, Aarto ja Valfrid";
            lokakuu[12] = "Taina, Tanja, Taija, Ebbe ja Ebba";
            lokakuu[13] = "Elsa, Else, Elsi ja Ilse";
            lokakuu[14] = "Helvi, Heta, Hedvig ja Hedda";
            lokakuu[15] = "Sirkka, Sirkku ja Stella";
            lokakuu[16] = "Saini, Saana, Vesta, Diana";
            lokakuu[17] = "Satu, Säde ja Saga";
            lokakuu[18] = "Uljas ja Viking";
            lokakuu[19] = "Kauno, Kasperi, Kasper ja Jesper";
            lokakuu[20] = "Ursula";
            lokakuu[21] = "Anja, Anita, Anniina ja Anitta";
            lokakuu[22] = "Severi, Severin ja Sören";
            lokakuu[23] = "Asmo ja Rasmus";
            lokakuu[24] = "Sointu ja Yvonne";
            lokakuu[25] = "Amanda, Niina, Manta, Nina ja Ninni";
            lokakuu[26] = "Helli, Hellä, Hellin, Helle ja Sabina";
            lokakuu[27] = "Simo ja Simon";
            lokakuu[28] = "Alfred ja Urmas";
            lokakuu[29] = "Eila ja Jennifer";
            lokakuu[30] = "Artturi, Arto, Arttu ja Artur";
            #endregion
            #region marraskuu
            marraskuu = new string[30];
            marraskuu[0] = "Pyry, Lyly, Gun ja Gunhild";
            marraskuu[1] = "Topi, Topias ja Tobias";
            marraskuu[2] = "Terho ja Erland";
            marraskuu[3] = "Hertta ja Carina";
            marraskuu[4] = "Reima ja Torhild";
            marraskuu[5] = "Kustaa Aadolf, Gustav ja Adolf";
            marraskuu[6] = "Taisto ja Glenn";
            marraskuu[7] = "Aatos ja Styrbjörn";
            marraskuu[8] = "Teuvo, Teodor ja Theo";
            marraskuu[9] = "Martti, Martin, Mårten ja Martina";
            marraskuu[10] = "Panu ja Boris";
            marraskuu[11] = "Virpi, Konrad ja Kurt";
            marraskuu[12] = "Ano, Kristian ja Krister";
            marraskuu[13] = "Iiris ja Iris";
            marraskuu[14] = "Janika, Janita, Janina, Janette, Jannika ja Jeanette";
            marraskuu[15] = "Aarne, Aarno, Aarni, Arne, Arnold ja Arna";
            marraskuu[16] = "Eino, Einari, Einar ja Enar";
            marraskuu[17] = "Tenho, Jousia ja Max";
            marraskuu[18] = "Elisabet, Liisa, Eliisa, Elisa, Elise, Liisi, Lisa, Lisen, Lisbet ja Elise";
            marraskuu[19] = "Jalmari, Jari, Hjalmar ja Pontus";
            marraskuu[20] = "Hilma";
            marraskuu[21] = "Silja, Selja ja Cecilia";
            marraskuu[22] = "Ismo, Yngve, Yngvar";
            marraskuu[23] = "Lempi, Lemmikki, Sivi ja Siv";
            marraskuu[24] = "Katri, Kaisa, Kaija, Katja, Kaarina, Katariina, Katriina, Kati, Kaisu, Riina, Katarina, Karin ja Kajsa";
            marraskuu[25] = "Sisko ja Dagmar";
            marraskuu[26] = "Hilkka, Astrid ja Estrid";
            marraskuu[27] = "Heini ja Sten";
            marraskuu[28] = "Aimo ja Edgar";
            marraskuu[29] = "Antti, Antero, Atte, Anders, Andreas, Andre ja Andrea";
            #endregion
            #region joulukuu
            joulukuu = new String[31];
            joulukuu[0] = "Oskari ja Oskar";
            joulukuu[1] = "Anelma, Unelma, Beata ja Beatrice";
            joulukuu[2] = "Vellamo, Meri ja Urda";
            joulukuu[3] = "Airi, Aira, Barbara ja Barbro";
            joulukuu[4] = "Selma";
            joulukuu[5] = "Niilo, Nikolai, Niko, Niklas ja Nils";
            joulukuu[6] = "Sampsa, Agata, Agda ja Ågot";
            joulukuu[7] = "Kyllikki, Kylli, Magnhild ja Magna";
            joulukuu[8] = "Anna, Anne, Anni, Anu, Annikki, Anneli, Annukka, Annika ja Annette";
            joulukuu[9] = "Jutta ja Judit";
            joulukuu[10] = "Taneli, Tatu, Daniel, Dan ja Daniela";
            joulukuu[11] = "Tuovi ja Tove";
            joulukuu[12] = "Seija ja Lucia";
            joulukuu[13] = "Jouko ja Ove";
            joulukuu[14] = "Heimo ja Sverker";
            joulukuu[15] = "Auli, Aulikki, Aada, Ada ja Adele";
            joulukuu[16] = "Raakel ja Rakel";
            joulukuu[17] = "Aapo, Aappo, Rami ja Abraham";
            joulukuu[18] = "Iikka, Iiro, Iisakki, Isko ja Isak";
            joulukuu[19] = "Benjamin, Kerkko, Ben ja Benny";
            joulukuu[20] = "Tuomas, Tuomo, Tommi, Tomi, Tomas, Tom ja Tommy";
            joulukuu[21] = "Raafael ja Rafael";
            joulukuu[22] = "Senni ja Elof";
            joulukuu[23] = "Aatami, Eeva, Eevi, Eveliina, Adam ja Eva";
            joulukuu[24] = "-Joulupäivä-";
            joulukuu[25] = "Tapani, Teppo, Tahvo, Stefan ja Staffan";
            joulukuu[26] = "Hannu, Hannes ja Hans";
            joulukuu[27] = "Piia ja Pia";
            joulukuu[28] = "Rauha ja Frida";
            joulukuu[29] = "Daavid, Taavetti, Taavi ja David";
            joulukuu[30] = "Sylvester ja Silvo";
            #endregion
        }
    }
}
