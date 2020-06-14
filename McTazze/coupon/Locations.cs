﻿/*
    Copyright 2020 ErikPelli

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
*/

using System;
using System.Collections.Generic;

namespace McTazze.coupon
{
    // Class that contains all possible locations
    class Locations
    {
        // List that contains all italian mcdonalds locations (alphabetical order)
        private static List<(int, string)> locations = new List<(int, string)>{
            (405, "Abbiategrasso"),
            (304, "Acireale Drive"),
            (894, "Acqui Terme"),
            (192, "Affi Drive"),
            (125, "Afragola"),
            (244, "Agrigento"),
            (32, "Alessandria"),
            (743, "Alessandria Giordano Bruno"),
            (259, "Ancona Baraccola"),
            (807, "Ancona Torrette"),
            (568, "Antegnate"),
            (410, "Anzio"),
            (49, "Aosta"),
            (740, "Appiano Gentile"),
            (764, "Aprilia Mascagni Drive"),
            (808, "Arcore Drive"),
            (742, "Arese Mall"),
            (768, "Ascoli Piceno Drive"),
            (496, "Assago"), (120, "Assisi"),
            (427, "Asti Consorzio"),
            (645, "Avezzano"),
            (318, "Bagnolo Cremasco"),
            (253, "Bari Casamassima"),
            (403, "Bari Mungivacca"),
            (194, "Bari Santa Caterina"),
            (70, "Bari Sparano"),
            (592, "Bari Tangenziale"),
            (746, "Barletta"),
            (526, "Bassano"),
            (371, "Bellinzago"),
            (681, "Belluno"),
            (352, "Belpasso CT"),
            (2189, "Bergamo P.za Marconi"),
            (212, "Biella"),
            (227, "Binasco"),
            (158, "Bologna S. Lazzaro"),
            (565, "Bologna Stalingrado"),
            (265, "Bologna Togliatti Drive"),
            (763, "Bologna via Larga"),
            (600, "Bologna VIII Agosto"),
            (778, "Bolzano Mall"),
            (853, "Bolzano Piazza Parrocchia"),
            (828, "Borgomanero Drive"),
            (663, "Bracciano"),
            (657, "Brembate Drive"),
            (73, "Brescia Campogrande"),
            (104, "Brescia Continente"),
            (706, "Brindisi"),
            (20, "Busnago"),
            (2186, "Busto Arsizio"),
            (724, "Cagliari Peretti"),
            (2156, "Cagliari S. Simone"),
            (56, "Campi Bisenzio"),
            (842, "Carbonia Drive"),
            (495, "Carini"),
            (392, "Carpi"),
            (130, "Casalecchio Di Reno 1"),
            (546, "Casalpusterlengo"),
            (540, "Casoria"),
            (482, "Cassano"),
            (739, "Castegnato"),
            (596, "Castel Maggiore"),
            (580, "Castel Romano"),
            (2109, "Castelletto Ticino"),
            (501, "Castelvetrano"),
            (719, "Castiglione delle Stiviere"),
            (282, "Castione Andevenno"),
            (115, "Catania"),
            (859, "Catania Aeroporto"),
            (433, "Catania Gravina"),
            (738, "Catania Mall"),
            (444, "Catania S. Giovanni"),
            (535, "Catania Tenutella"),
            (446, "Catania Ulisse"),
            (450, "Catanzaro Le Fontane"),
            (699, "Cecina"),
            (404, "Cento"),
            (820, "Cerro Maggiore Drive"),
            (347, "Cesano Boscone"),
            (827, "Cesena Cattaneo"),
            (415, "Cesena Cervese"),
            (633, "Chioggia"),
            (675, "Chivasso"),
            (710, "Ciampino"),
            (567, "Cinisello Mall"),
            (3225, "Cinisello Testi1"),
            (789, "Cinisello Valtellina"),
            (80, "Civitavecchia"),
            (800, "Collegno Corso Francia"),
            (214, "Cologno Monzese"),
            (268, "Colonnella"),
            (2107, "Como"),
            (258, "Concesio Triumplina"),
            (838, "Concorezzo"),
            (776, "Cornuda"),
            (525, "Corridonia"),
            (166, "Corsico"),
            (878, "Cosenza Bilotti Museo"),
            (229, "Cremona Drive"),
            (677, "Crotone Passovecchio"),
            (14, "Curno"),
            (818, "Curno via Bergamo"),
            (514, "Curtatone"),
            (692, "Dalmine"),
            (260, "Darfo Boario Terme"),
            (3226, "Desenzano Sul Garda"),
            (520, "Desio"),
            (636, "Domodossola"),
            (790, "Dossobuono"),
            (529, "Eboli"),
            (896, "Enna"),
            (3221, "Erba"),
            (127, "Erbusco"),
            (1005, "Fabriano Via Dante"),
            (429, "Faenza"),
            (667, "Falconara"),
            (703, "Fano"),
            (183, "Ferrara Drive"),
            (467, "Ferrara Sud"),
            (3238, "Ferrara Trento E Trieste"),
            (578, "Fidenza"),
            (255, "Firenze Agnelli"),
            (2197, "Firenze Esterno Stazione"),
            (270, "Firenze Nenni"),
            (485, "Firenze Osmannoro"),
            (704, "Firenze Senese"),
            (96, "Firenze Stazione Griglia"),
            (500, "Fiume Veneto"),
            (690, "Fiumicino via del Faro"),
            (817, "Foggia Mall"),
            (760, "Foggia Mezzogiorno"),
            (771, "Foligno Drive"),
            (523, "Frosinone Lepini"),
            (416, "Gallarate via Milano"),
            (395, "Garbagnate"),
            (610, "Garlate"),
            (614, "Gela"),
            (814, "Gerenzano"),
            (892, "Ghedi"),
            (539, "Gioia Tauro"),
            (362, "Giugliano"),
            (707, "Grandate"),
            (364, "Gravellona Toce"),
            (239, "Grosseto"),
            (563, "Guidonia"),
            (836, "Imperia Drive"),
            (841, "Induno Olona"),
            (493, "Jesi"),
            (411, "Jesolo"),
            (136, "L' Aquila"),
            (717, "Ladispoli"),
            (502, "Lainate"),
            (620, "Lamezia Terme Drive"),
            (3198, "Latina Fiori"),
            (702, "Latina Isonzo"),
            (58, "Latina Romagnoli"),
            (558, "Lecce Surbo"),
            (48, "Lecco"),
            (385, "Legnago"),
            (484, "Legnano"),
            (263, "Lentate sul Seveso"),
            (668, "Lipomo"),
            (783, "Locate Triulzi Outlet"),
            (100, "Lodi Tangenziale Est"),
            (380, "Lonato"), (577, "Loreto"),
            (686, "Lucca Capannori"),
            (572, "Lugo"),
            (640, "Maddaloni Drive"),
            (730, "Magenta"),
            (474, "Malnate"),
            (409, "Marcianise"),
            (432, "Marcon Galleria"),
            (727, "Marghera Mall"),
            (765, "Merano"),
            (243, "Mercogliano"),
            (629, "Messina Cairoli"),
            (518, "Mestre Terraglio"),
            (693, "Mestre Tosatto Mall"),
            (144, "Milano Antonini"),
            (9, "Milano Bonola"),
            (2174, "Milano Centrale 2"),
            (79, "Milano Certosa"),
            (680, "Milano Corso Lodi"),
            (2102, "Milano Duomo"),
            (37, "Milano Farini"),
            (658, "Milano Galleria Fontana"),
            (644, "Milano Lorenteggio Drive"),
            (417, "Milano Oberdan"),
            (2111, "Milano P.le Loreto"),
            (2146, "Milano Rogoredo"),
            (2148, "Milano Rubicone"),
            (12, "Milano Sabotino"),
            (2101, "Milano San Babila"),
            (664, "Milano Stazione Centrale Interno"),
            (844, "Milano via Dante"),
            (308, "Milano Via Novara"),
            (852, "Milano via Torino"),
            (53, "Milano XXIV Maggio"),
            (511, "Milazzo"),
            (551, "Mirandola"),
            (3222, "Modena Bruciata"),
            (716, "Modena Emilia Est"),
            (167, "Modena Ovest"),
            (2187, "Modena Portali"),
            (441, "Molfetta"),
            (348, "Moncalieri"),
            (618, "Monfalcone"),
            (815, "Monselice"),
            (317, "Montano Lucino"),
            (69, "Montebello"),
            (691, "Montecatini Camporcioni"),
            (250, "Montecchio Drive"),
            (187, "Montepaone"),
            (538, "Monterotondo"),
            (114, "Montesilvano"),
            (161, "Monza V.le Lombardia"),
            (112, "Monza Via Milano"),
            (809, "Napoli Galleria Umberto"),
            (206, "Napoli Stadio Fuorigrotta"),
            (797, "Navacchio"),
            (621, "Nettuno"),
            (679, "Nichelino"),
            (421, "Nocera Superiore"),
            (372, "Nola"),
            (428, "Novara Sporting"),
            (143, "Novate Milanese"),
            (804, "Nuoro"),
            (2165, "Olbia"),
            (662, "Olbia Indonesia"),
            (626, "Olgiate Olona"),
            (129, "Orio al Serio"),
            (154, "Oristano"),
            (898, "Orte Drive"),
            (386, "Orzinuovi"),
            (672, "Osimo"),
            (2181, "Paderno Dugnano"),
            (3233, "Padova"),
            (537, "Padova Guido Reni"),
            (240, "Padova Ovest"),
            (88, "Palermo Drive"),
            (464, "Palermo La Malfa"),
            (714, "Palermo Pecoraino"),
            (251, "Pantigliate"),
            (557, "Parco Leonardo"),
            (597, "Parma Est"),
            (350, "Parma San Leonardo"),
            (477, "Pavia Brambilla"),
            (2220, "Pavone Canavese"),
            (65, "Perugia Collestrada"),
            (426, "Perugia San Sisto"),
            (736, "Perugia Stadio"),
            (682, "Pesaro Gagarin Drive"),
            (650, "Pescara Marconi"),
            (990, "Pescara Via della Riviera"),
            (377, "Peschiera"),
            (146, "Piacenza Stazione"),
            (709, "Pioltello"),
            (204, "Piombino"),
            (688, "Pisa Darsena"),
            (412, "Pisa Miracoli"),
            (638, "Pomezia Castelli Romani"),
            (849, "Pomezia Via Roma"),
            (754, "Pomigliano d'Arco"),
            (556, "Pompei Mall"),
            (147, "Pordenone"),
            (247, "Porto San Giorgio Drive"),
            (357, "Prato"),
            (491, "Puegnago"),
            (876, "Quarto Mall"),
            (728, "Quartu Sant'Elena Poetto"),
            (126, "Quartucciu"),
            (281, "Ragusa drive"),
            (90, "Ravenna Ipercoop"),
            (656, "Ravenna via Trieste"),
            (509, "Reggio Calabria Tangenziale"),
            (772, "Reggio Emilia Sud"),
            (504, "Reggio Emilia Tien An Men"),
            (64, "Rende"),
            (439, "Rende Marconi"),
            (238, "Rescaldina"),
            (819, "Rho Drive"),
            (632, "Rimini Flaminia"),
            (353, "Rimini Le Befane"),
            (589, "Rimini Popilia"),
            (445, "Rivoli"),
            (887, "Rodengo Saiano Outlet"),
            (363, "Roma Anagnina"),
            (41, "Roma Annibaliano"),
            (560, "Roma Appia"),
            (186, "Roma Aurelia"),
            (812, "Roma Borgo Pio"),
            (30, "Roma C.so Francia"),
            (448, "Roma Capena"),
            (466, "Roma Casal del Marmo"),
            (747, "Roma Casalotti"),
            (480, "Roma Dragona"),
            (373, "Roma EUR"),
            (40, "Roma Giolitti"),
            (562, "Roma Giulio Cesare"),
            (359, "Roma Lunghezza"),
            (701, "Roma Mirti"),
            (469, "Roma Nomentana"),
            (813, "Roma P.zza delle Cinque Lune"),
            (2, "Roma P.zza Di Spagna"),
            (413, "Roma Palaia"),
            (134, "Roma Parchi Colombo"),
            (3224, "Roma Pio XI"),
            (33, "Roma Prati Fiscali"),
            (611, "Roma Regina Margherita"),
            (419, "Roma San Paolo"),
            (452, "Roma Stradivari"),
            (3, "Roma Sturzo"),
            (178, "Roma Tiburtina Cavallari"),
            (24, "Roma Tiburtina De Paolis"),
            (735, "Roma Tor Vergata Mall"),
            (829, "Roma Torpignattara"),
            (810, "Roma Tre Fontane Drive"),
            (29, "Roma V.le America"),
            (678, "Roma Valle Aurelia"),
            (619, "Romagnano Sesia"),
            (522, "Romanina"),
            (811, "Roncadelle Mall"),
            (536, "Rovereto"),
            (124, "Rovigo"),
            (498, "Rozzano"),
            (607, "Rubano"),
            (279, "S.Giovanni Teatino"),
            (221, "S.Giuliano Terme"),
            (830, "Salerno Mall"),
            (142, "San Benedetto Del Tronto"),
            (877, "San Bonifacio Drive"),
            (684, "San Giovanni Lupatoto Drive"),
            (261, "San Martino Siccomario"),
            (858, "San Maurizio Canavese"),
            (368, "San Prisco"),
            (284, "San Vendemiano - Conegliano"),
            (781, "San Vittore Olona"),
            (384, "Sarzana"),
            (2231, "Sassari"),
            (122, "Sassuolo"),
            (608, "Savona"),
            (269, "Schio Drive"),
            (609, "Sedriano"),
            (459, "Segrate"),
            (718, "Segrate Cassanese"),
            (148, "Senigallia"),
            (449, "Serravalle Scrivia Outlet"),
            (330, "Sesto San Giovanni - Sarca"),
            (354, "Sesto San Giovanni v.le Italia"),
            (731, "Sestu"),
            (280, "Siderno"),
            (729, "Silea"),
            (301, "Siracusa Drive"),
            (336, "Siracusa Melilli C.C. Belvedere Auchan"),
            (506, "Solbiate Arno"),
            (117, "Somma Lombardo"),
            (533, "Sora"),
            (566, "Stezzano"),
            (455, "Stradella"),
            (110, "Taranto"),
            (333, "Tavagnacco"),
            (3240, "Tavernola"),
            (651, "Terracina Drive"),
            (436, "Teverola"),
            (857, "Thiene Drive"),
            (803, "Torino Lingotto Mall"),
            (340, "Torino Monginevro (Norauto)"),
            (847, "Torino Santa Rita"),
            (872, "Torino Sant'Ottavio"),
            (492, "Torino via Livorno"),
            (456, "Torre Annunziata Retail Park"),
            (2137, "Torri di Quartesolo"),
            (388, "Tradate"),
            (613, "Trapani"),
            (211, "Trento"),
            (734, "Trento Nord"),
            (180, "Treviglio"),
            (545, "Treviso Repubblica"),
            (674, "Trieste Goldoni"),
            (320, "Trieste Mall"),
            (77, "Udine"),
            (21, "Varese 1"),
            (665, "Varese Stadio"),
            (595, "Velletri"),
            (733, "Verano Brianza"),
            (400, "Verolanuova"),
            (845, "Verona Adige Mall"),
            (196, "Verona Fiera"),
            (141, "Verona Milano"),
            (5, "Verona Porta Nuova"),
            (816, "Verona Via Preare"),
            (834, "Viareggio Drive"),
            (531, "Vicenza Mall"),
            (462, "Vicenza San Lazzaro"),
            (515, "Vigevano"),
            (300, "Vignate"),
            (507, "Vignola"),
            (339, "Villaricca"),
            (584, "Villesse Mall"),
            (283, "Vimercate"),
            (799, "Viterbo Garbini"),
            (604, "Viterbo San Paolo"),
            (837, "Voghera"),
            (356, "Zumpano CS")
        };

        // Return a random location
        public static (int, string) GetLocation()
        {
            // Check list length
            if (locations.Count > 0)
            {
                // Get a random list index
                int index = new Random().Next(Locations.locations.Count);

                (int locationID, string locationName) = Locations.locations[index];

                // Remove item from list
                locations.RemoveAt(index);

                // Return location
                return (locationID, locationName);
            }
            else
            {
                throw new Exception("Locations list is empty.");
            }  
        }

    }
}