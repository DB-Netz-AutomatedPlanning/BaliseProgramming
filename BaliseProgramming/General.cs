using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaliseProgramming
{
    public static class General
    {
        /* User data should be entered in accordance with specific length guideline (UNISIG SS 036)
         * ToDo: To be connected to the SD1 Data schema*/
        public static string StringUserData()
        {
            int Q_UPDOWN = 1; //length 1 bit
            int M_VERSION = 32; //length 7 bit
            int Q_MEDIA = 0;// length 1 bit
            int N_PIG = 1;// length 3 bit
            int N_TOTAL = 1;// length 3 bit
            int M_DUP = 0;//length 2 bit
            int M_MCOUNT = 255; //length 8 bit
            int NID_C = 65;//length 10 bit 
            int NID_BG = 4711; //length 14
            int Q_LINK = 0; //length 1   // Total = 50


            int NID_PACKET = 65; // length 8;
            int Q_DIR = 1; // length 2
            int L_PACKET = 71;// length 13
            int Q_SCALE = 1;// length 2
            int NID_TSR = 220; // length 8
            int D_TSR = 1500; // length 15
            int L_TSR = 500; // length 15
            int Q_FRONT = 1; // length 1
            int V_TSR = 20; //length 7  // Total = 71

            int NID_PACKET_2 = 137; // length 8;
            int Q_DIR_2 = 1; // length 2
            int L_PACKET_2 = 24;// length 13
            int Q_SRSTOP = 0;//length 1 bit  // Total = 24

            int NID_PACKET_3 = 255; //length 8  // Total = 8

            string Q_UPDOWN_S = Convert.ToString(Q_UPDOWN, 2).PadLeft(1, '0');
            string M_VERSION_S = Convert.ToString(M_VERSION, 2).PadLeft(7, '0');
            string Q_MEDIA_S = Convert.ToString(Q_MEDIA, 2).PadLeft(1, '0');
            string N_PIG_S = Convert.ToString(N_PIG, 2).PadLeft(3, '0');
            string N_TOTAL_S = Convert.ToString(N_TOTAL, 2).PadLeft(3, '0');
            string M_DUP_S = Convert.ToString(M_DUP, 2).PadLeft(2, '0');
            string M_MCOUNT_S = Convert.ToString(M_MCOUNT, 2).PadLeft(8, '0');
            string NID_C_S = Convert.ToString(NID_C, 2).PadLeft(10, '0');
            string NID_BG_S = Convert.ToString(NID_BG, 2).PadLeft(14, '0');
            string Q_LINK_S = Convert.ToString(Q_LINK, 2).PadLeft(1, '0');


            string NID_PACKET_S = Convert.ToString(NID_PACKET, 2).PadLeft(8, '0');
            string Q_DIR_S = Convert.ToString(Q_DIR, 2).PadLeft(2, '0');
            string L_PACKET_S = Convert.ToString(L_PACKET, 2).PadLeft(13, '0');
            string Q_SCALE_S = Convert.ToString(Q_SCALE, 2).PadLeft(2, '0');
            string NID_TSR_S = Convert.ToString(NID_TSR, 2).PadLeft(8, '0');
            string D_TSR_S = Convert.ToString(D_TSR, 2).PadLeft(15, '0');
            string L_TSR_S = Convert.ToString(L_TSR, 2).PadLeft(15, '0');
            string Q_FRONT_S = Convert.ToString(Q_FRONT, 2).PadLeft(1, '0');
            string V_TSR_S = Convert.ToString(V_TSR, 2).PadLeft(7, '0');

            string NID_PACKET_S_2 = Convert.ToString(NID_PACKET_2, 2).PadLeft(8, '0');
            string Q_DIR_S_2 = Convert.ToString(Q_DIR_2, 2).PadLeft(2, '0');
            string L_PACKET_S_2 = Convert.ToString(L_PACKET_2, 2).PadLeft(13, '0');
            string Q_SRSTOP_2 = Convert.ToString(Q_SRSTOP, 2).PadLeft(1, '0');

            string NID_PACKET_S_3 = Convert.ToString(NID_PACKET_3, 2).PadLeft(8, '0');



            string all =  Q_UPDOWN_S + M_VERSION_S + Q_MEDIA_S + N_PIG_S + N_TOTAL_S + M_DUP_S + M_MCOUNT_S + NID_C_S + NID_BG_S + Q_LINK_S +
                NID_PACKET_S + Q_DIR_S + L_PACKET_S + Q_SCALE_S + NID_TSR_S + D_TSR_S + L_TSR_S + Q_FRONT_S + V_TSR_S
                + NID_PACKET_S_2 + Q_DIR_S_2 + L_PACKET_S_2 + Q_SRSTOP_2 + NID_PACKET_S_3;

            all = all.PadLeft(210, '0');
            return all;
        }

        // All valid 11-bits words. See SS-036 (clause B2 of Annex B)
        public static string[] Word()
        {
            return new string[] {"00101","00102","00103","00104","00105","00106","00107","00110","00111","00112",
                "00113","00114","00115","00116","00117","00120","00121","00122","00123","00124",
                "00125","00126","00127","00130","00131","00132","00133","00134","00135","00141",
                "00142","00143","00144","00145","00146","00147","00150","00151","00152","00153",
                "00154","00155","00156","00157","00160","00161","00162","00163","00164","00165",
                "00166","00167","00170","00171","00172","00173","00174","00175","00176","00201",
                "00206","00211","00214","00216","00217","00220","00222","00223","00224","00225",
                "00226","00231","00233","00244","00245","00246","00253","00257","00260","00261",
                "00272","00273","00274","00275","00276","00301","00303","00315","00317","00320",
                "00321","00332","00334","00341","00342","00343","00344","00346","00352","00353",
                "00357","00360","00374","00376","00401","00403","00404","00405","00406","00407",
                "00410","00411","00412","00413","00416","00417","00420","00424","00425","00426",
                "00427","00432","00433","00442","00443","00445","00456","00457","00460","00461",
                "00464","00465","00470","00471","00472","00474","00475","00476","00501","00502",
                "00503","00504","00505","00506","00507","00516","00517","00520","00521","00522",
                "00523","00524","00525","00530","00531","00532","00533","00534","00535","00544",
                "00545","00546","00547","00550","00551","00552","00553","00554","00555","00556",
                "00557","00560","00561","00562","00563","00571","00573","00576","00601","00602",
                "00604","00605","00610","00611","00612","00613","00614","00615","00616","00617",
                "00620","00621","00622","00623","00624","00625","00626","00627","00630","00634",
                "00635","00644","00645","00646","00647","00650","00651","00652","00653","00654",
                "00655","00656","00657","00660","00661","00662","00663","00666","00667","00672",
                "00674","00675","00676","00701","00712","00713","00716","00717","00720","00721",
                "00722","00723","00730","00731","00732","00733","00734","00735","00742","00743",
                "00744","00745","00746","00747","00750","00751","00752","00753","00754","00755",
                "00756","00757","00760","00761","00764","00765","00766","00767","00772","00773",
                "00776","01001","01004","01005","01016","01017","01020","01021","01022","01023",
                "01024","01025","01030","01031","01032","01033","01034","01035","01043","01044",
                "01045","01046","01047","01054","01057","01060","01061","01062","01075","01076",
                "01101","01102","01103","01110","01114","01115","01116","01117","01120","01121",
                "01122","01123","01124","01125","01126","01127","01130","01131","01132","01133",
                "01142","01143","01144","01145","01146","01147","01151","01152","01153","01154",
                "01155","01156","01157","01160","01164","01166","01167","01176","01201","01214",
                "01217","01220","01221","01222","01223","01224","01225","01226","01227","01230",
                "01231","01232","01233","01243","01244","01245","01253","01254","01255","01256",
                "01257","01260","01261","01272","01273","01274","01275","01276","01301","01302",
                "01303","01305","01306","01307","01317","01320","01321","01332","01334","01335",
                "01342","01343","01344","01345","01350","01351","01352","01353","01355","01356",
                "01357","01360","01361","01364","01365","01370","01371","01372","01373","01374",
                "01376","01401","01403","01406","01407","01414","01415","01416","01417","01420",
                "01424","01425","01431","01433","01434","01435","01443","01445","01456","01457",
                "01460","01462","01474","01475","01476","01501","01502","01503","01504","01505",
                "01516","01517","01520","01524","01532","01533","01544","01546","01550","01551",
                "01552","01553","01554","01557","01560","01561","01562","01563","01566","01567",
                "01576","01601","01603","01604","01605","01606","01607","01610","01611","01612",
                "01613","01614","01615","01616","01617","01620","01621","01622","01623","01624",
                "01625","01626","01630","01631","01632","01633","01635","01643","01644","01645",
                "01650","01651","01652","01653","01654","01655","01656","01657","01660","01661",
                "01672","01674","01675","01676","01701","01720","01744","01745","01746","01747",
                "01750","01751","01752","01753","01754","01755","01756","01757","01760","01761",
                "01762","01763","01764","01765","01766","01767","01770","01771","01772","01773",
                "01774","01775","02002","02003","02004","02005","02006","02007","02010","02011",
                "02012","02013","02014","02015","02016","02017","02020","02021","02022","02023",
                "02024","02025","02026","02027","02030","02031","02032","02033","02057","02076",
                "02101","02102","02103","02105","02116","02117","02120","02121","02122","02123",
                "02124","02125","02126","02127","02132","02133","02134","02142","02144","02145",
                "02146","02147","02151","02152","02153","02154","02155","02156","02157","02160",
                "02161","02162","02163","02164","02165","02166","02167","02170","02171","02172",
                "02173","02174","02176","02201","02210","02211","02214","02215","02216","02217",
                "02220","02223","02224","02225","02226","02227","02231","02233","02244","02245",
                "02253","02257","02260","02261","02272","02273","02274","02275","02276","02301",
                "02302","02303","02315","02317","02320","02321","02332","02334","02342","02343",
                "02344","02346","02352","02353","02357","02360","02361","02362","02363","02370",
                "02371","02374","02376","02401","02403","02404","02405","02406","02407","02412",
                "02413","02416","02417","02420","02421","02422","02424","02425","02426","02427",
                "02432","02433","02434","02435","02442","02443","02445","02456","02457","02460",
                "02470","02471","02472","02474","02475","02476","02501","02502","02503","02504",
                "02505","02516","02517","02520","02521","02522","02523","02524","02532","02533",
                "02534","02544","02545","02546","02547","02550","02551","02552","02553","02554",
                "02555","02556","02557","02560","02563","02576","02601","02610","02611","02613",
                "02617","02620","02621","02622","02623","02624","02625","02626","02630","02631",
                "02632","02633","02634","02635","02644","02645","02646","02647","02650","02651",
                "02652","02653","02654","02655","02656","02657","02660","02661","02662","02663",
                "02667","02674","02675","02676","02701","02702","02715","02716","02717","02720",
                "02723","02730","02731","02732","02733","02734","02742","02743","02744","02745",
                "02746","02747","02752","02753","02754","02755","02756","02757","02760","02761",
                "02772","02773","02776","03001","03004","03005","03010","03011","03012","03013",
                "03016","03017","03020","03021","03022","03023","03024","03025","03026","03027",
                "03030","03031","03032","03033","03034","03035","03042","03043","03044","03045",
                "03046","03047","03054","03055","03056","03057","03060","03061","03064","03065",
                "03076","03101","03102","03103","03105","03110","03111","03114","03115","03116",
                "03117","03120","03121","03122","03123","03124","03125","03126","03127","03130",
                "03131","03132","03133","03142","03143","03147","03150","03151","03152","03153",
                "03154","03155","03156","03157","03160","03161","03162","03163","03164","03165",
                "03166","03167","03172","03173","03175","03176","03201","03204","03206","03214",
                "03215","03216","03217","03220","03221","03222","03223","03224","03225","03226",
                "03227","03230","03231","03232","03233","03242","03243","03244","03245","03246",
                "03247","03252","03253","03254","03255","03256","03257","03260","03261","03270",
                "03271","03272","03273","03274","03275","03276","03301","03302","03303","03305",
                "03306","03307","03312","03313","03316","03317","03320","03321","03332","03334",
                "03335","03344","03345","03350","03351","03352","03353","03357","03360","03361",
                "03364","03365","03366","03367","03370","03371","03372","03373","03374","03376",
                "03401","03403","03417","03420","03424","03425","03431","03433","03434","03435",
                "03436","03443","03445","03456","03457","03460","03462","03474","03476","03501",
                "03502","03503","03504","03505","03516","03517","03520","03524","03531","03532",
                "03533","03544","03546","03551","03552","03553","03554","03555","03557","03560",
                "03561","03563","03566","03571","03576","03601","03602","03603","03604","03605",
                "03606","03607","03610","03611","03612","03613","03614","03615","03616","03617",
                "03620","03621","03622","03623","03624","03625","03626","03627","03630","03631",
                "03632","03633","03634","03635","03636","03642","03643","03644","03645","03646",
                "03647","03650","03651","03652","03653","03654","03655","03656","03657","03660",
                "03661","03662","03663","03664","03665","03666","03667","03670","03671","03672",
                "03673","03674","03675","03676"};
        }


        public static List<string> DivideIntoWords (string data, int eachSize)
        {
            if (data.Length % eachSize != 0) Console.WriteLine("Warning ... Not all words are captured");
            List<string> words = new List<string>();
            for (int i = 0; i < data.Length; i+=eachSize)
            {
                words.Add(data.Substring(i, eachSize));
            }
            return words; 
        }


        /* Check if the Alphabet condition is satisfied
         * Any 11-bit word bi-1...bi-11 such that i is a multiple of 11 shall be valid.
         * Clearly, this condition is automatically satisfied in the shaped-data part of the telegram. However, 
         * the alphabet condition applies to all parts of the telegram*/
        public static bool AlphabetConditionSatisfied(string telegram)
        {
            List<string> telegramArray = new List<string>();
            string[] words = Word();
            for (int i = 0;i < telegram.Length -1; i+=11)
            {
                string val = telegram.Substring(i,11);
                telegramArray.Add(val);
            }

            foreach (string val in telegramArray)
            {
                int decimalValue = Convert.ToInt32(val, 2);
                string octalValue = Convert.ToString(decimalValue,8).PadLeft(5, '0');
                if (Array.Exists(words, element => element == octalValue) == false)
                    return false;
            } return true;
        }


        /* Check if OffSynchParsing Condition is Satisfied
         * 
         * This condition tests sequences of 11-bit words: (bi-1...bi-11), (bi-12...bi-22), (bi-23...bi-33), ... with i 
         * not a multiple of 11. It imposes a limit on the number of consecutive valid words within such sequences.
         * If i+1 or i-1 is a multiple of 11, the length of the longest run of consecutive valid words shall not exceed 2 (two).
         * Otherwise, if it is not a multiple of 11, the length of the longest run of consecutive valid words shall not exceed
         * 10 (ten) for long telegrams and 6 (six) for short telegrams. None of these conditions is automatically satisfied in 
         * any part of the telegram. However, the substitution table “helps” in the case where i+1 or i-1 is a multiple of 11,
         * see sub-clause 4.3.2.3 in UNISIG SS-036*/
        public static bool IsOffSynchParsingConditionSatisfied(string binaryStrings, string[] words) 
        {
            for (int i = 0; i < binaryStrings.Length; i++)
            {
                int index = binaryStrings.Length - i;
                if (index % 11 != 0) // i should NOT be multiple of 11 
                {
                    int synchIndex = binaryStrings.Length - i;
                    int currentLength = 0; // the length of consecutive valid words
                    bool isSyncPoint = ((synchIndex + 1) % 11 == 0) || ((synchIndex - 1) % 11 == 0);

                    for (int j = i; j <= binaryStrings.Length - 11; j += 11)
                    {
                        string currentWord = binaryStrings.Substring(j, 11); // 11-bit word
                        int decimalValue = Convert.ToInt32(currentWord, 2);
                        string octalValue = Convert.ToString(decimalValue, 8).PadLeft(5, '0');
                        // Check if it's a valid word
                        if (Array.Exists(words, element => element == octalValue) == true)
                        {
                            currentLength++;

                            if (isSyncPoint && currentLength > 2)
                            {
                                return false; // Return false if the limit is exceeded based on sync point
                            }
                            else if (!isSyncPoint && currentLength > (binaryStrings.Length > 341 ? 10 : 6))
                            {
                                return false; // Return false if the limit is exceeded based on non-sync point
                            }
                        }
                        else
                        {
                            currentLength = 0;
                        }
                    }
                }
                else Console.WriteLine("Skip: It's a multiple of 11");
            }
            return true;
        }


        /* Check if Under-Sampling Condition is Satisfied.
         * Under-sampling by 2, i.e., permuting a telegram into bn-2, bn-4, ..., b1, bn-1, bn-3, ..., b2, b0, results in 
         * another code word in the cyclic code and is thus not detectable by checking the parity bits. Since it is 
         * plausible that such a transformation can be caused by a hardware defect, each telegram is tested to make sure that such 
         * a transformed code word violates the Alphabet Condition.
         * Let v_j=b_j*2k, j=0...n-1 (under-sampling by a factor of 2k). For k=1, 2, 3, 4 and for any i, the length of the longest
         * run of valid words in the sequence (v_i-1...v_i-11), (v_i-12...v_i-22), (v_i-23...v_i-33) shall not exceed 30. In other 
         * words, no under-sampled short telegram and no length-341 segment of an under-sampled long telegram may satisfy the 
         * Alphabet Condition with arbitrary word boundaries.*/

        public static bool IsUnderSamplingConditionSatisfied(string telegram)  
        {
            telegram = Helper.Permutation(telegram);
            for (int k =1; k<=4; k++)
            {
                int maxLength = 0;
                int currentLength = 0;
                string[] validWords = Word();
                
                // Determine the under-sampling factor
                int factor = (int)Math.Pow(2, k);

                for (int i = 0; i < telegram.Length; i += factor)
                {
                    if (i + 11 <= telegram.Length)
                    {
                        string word = telegram.Substring(i, 11);

                        if (Array.Exists(validWords, element => element == word) == true)
                        {
                            currentLength++;
                            if (currentLength > 30)
                            {
                                Console.WriteLine("Under sampling Condition not satisfied ");
                                return false;
                            } // Return false if the length exceeds the limit
                            maxLength = Math.Max(maxLength, currentLength); // Redundant (useful if sometimes interested in the maxlength)
                        
                        }
                        else { currentLength = 0; }
                    }
                }
            }
            return true; // All conditions satisfied, return true
        }


        /* Check Aperiodicity Condition for Long Telegram.
         * 
         * This condition applies only to the long format. It ensures that no part of a long 
         * telegram may be mistaken as a short telegram, even in the presence of noise and bit 
         * slips, by testing the Hamming distance between two sequences of 11-bit words that 
         * are separated by about 341 bits. 
         * For every i that is a multiple of 11: 
         *      - the Hamming distance between b_i-1...b_i-22 and b_i-341-1...b_i-341-22 shall be at least 3;
         *      - for each k = +1, -1, +2, -2, +3 and -3, the Hamming distance between b_i-1...b_i-22 and
         *        b_i-341-k-1...b_i-341-k-22 shall be at least 2.
         */
        public static bool CheckAperiodicityConditionForLongFormat(string telegram)
        {
            int telegramLength = telegram.Length;
            if (telegramLength % 11 != 0)
            {
                Console.WriteLine("Invalid telegram input");
                return false; // Reject invalid telegram input
            }
            if (telegramLength == 341) return true; // This condition is not necessary for short telegram

            for (int i = 0; i < telegramLength; i += 11)
            {
                string sequence1 = telegram.Substring(i, 22);
                string sequence2 = telegram.Substring(i + (telegramLength - 341), 22);

                if (HammingDistance(sequence1, sequence2) < 3)
                    return false;
                int[] kValues = new int[] { 1, -1, 2, -2, 3, -3 };

                foreach(int k in kValues)
                {
                    string shiftedSequence = ShiftSequence(telegram, i + (telegramLength - 341), k);

                    if (HammingDistance(sequence1, shiftedSequence) < 2)
                        return false;
                }
            }
            return true;
        }

        private static int HammingDistance(string sequence1, string sequence2)
        {
            int distance = 0;

            for (int i = 0; i < sequence1.Length; i++)
            {
                if (sequence1[i] != sequence2[i])
                    distance++;
            }
            return distance;
        }


        private static string ShiftSequence(string telegram, int startIndex, int shift)
        {
            string shiftedSequence = string.Empty;

            for (int i = startIndex; i < startIndex + 22; i++)
            {
                int newIndex = i + shift;
                newIndex = (newIndex < startIndex) ? startIndex + 22 + newIndex : newIndex;
                newIndex = (newIndex >= startIndex + 22) ? newIndex - startIndex - 22 : newIndex;
                shiftedSequence += telegram[newIndex];
            }

            return shiftedSequence;
        }




        /* This method generate the telegram binary (341 length for short) by combining all the processes
         * together as well as testing the candidate telegram */
        public static string Generate(string telegramUserData)
        {
            List<string> wordArray = new List<string>();
            List<List<int>> scrambleBits = Helper.GetAllBitsOutcomes(12);

            for (int k = 0; k < scrambleBits.Count; k++)
            {
                Console.WriteLine("Before Scramble: " + telegramUserData);
                wordArray = DivideIntoWords(telegramUserData, 10);  // dividing user data into an array of 10 bit words
                string scramblingBit = Helper.IntListToString(scrambleBits[k]);

                long S = (2801775573 * Convert.ToUInt32(scramblingBit, 2)) % 4294967296; //seed
                uint shift = (uint)S;
                Console.WriteLine("Shift: " + shift);
                uint toggle = 0xF5000001; // tapmask

                //scrambling GFLR algortithm
                for (int i = 0; i < wordArray.Count; i++)
                {
                    for (int j = 0; j < wordArray[i].Length; j++)
                    {
                        char reqBit = wordArray[i][j];
                        char reqMsb = (char)((shift >> 31) & 1);
                        char reqOut = (char)(reqBit ^ reqMsb);
                        wordArray[i] = Helper.SetBit(wordArray[i], j, reqOut);
                        shift <<= 1;

                        if (reqBit != 0)  //(reqBit & 1) == 1
                        {
                            shift ^= toggle;
                        }
                    }
                }

                Console.WriteLine("Tele after Scrambling: " + String.Join(",", wordArray));

                // Convert the 10bits to 11bits
                for (int i=0; i<wordArray.Count; i++)
                {
                    string currentBin = wordArray[i];
                    int toDecimal = Convert.ToInt32(currentBin, 2);
                    string octalNumber = Word()[toDecimal];
                    // Convert the octal number to an integer
                    int decimalNumber = Convert.ToInt32(octalNumber, 8);
                    string binaryString = Convert.ToString(decimalNumber, 2).PadLeft(11, '0');
                    wordArray[i]=binaryString;
                }
           
                StringBuilder telegramUserDataNew = new();
                foreach (string str in wordArray)
                {
                    telegramUserDataNew.Append(str);
                }
                Console.WriteLine("tele231: " +  telegramUserDataNew.ToString());

                //First, check if alphabet condition was satisfied
                if (AlphabetConditionSatisfied(telegramUserDataNew.ToString()))
                {
                    List<List<int>> esbBits = Helper.GetAllBitsOutcomes(10);

                    string copystring = telegramUserDataNew.ToString();
                    for (int l = 0; l < esbBits.Count; l++)
                    {
                        StringBuilder telegramUserDataNew2 = new (); // Build the telegram to the esb
                        telegramUserDataNew2.Append(copystring);
                        telegramUserDataNew2.Append("001");
                        telegramUserDataNew2.Append(scramblingBit);
                        int[] esb = esbBits[l].ToArray();
                        telegramUserDataNew2.Append(Helper.ToString(esb));
                        string checkBits = Helper.CalculateCheckBits(telegramUserDataNew2);
                        telegramUserDataNew2.Append(checkBits);
                        /* Every telegram shall satisfy all conditions below. As described in sub-clause 4.3.2.3 (UNISIG SS-036),
                         * a candidate telegram that does not satisfy all these conditions shall be rejected; a new candidate may 
                         * then be obtained by either changing the extra shaping bits (which affects only the check bits), or by
                         * changing the scrambling bits (which affects the whole telegram).
                         * All the conditions below shall also hold “wrap-around”, i.e., for cyclically repeated telegrams. All 
                         * indices are tacitly assumed to be reduced modulo n (=1023 or 341 for the long and the short format, respectively).
                         */
                        if (AlphabetConditionSatisfied(telegramUserDataNew2.ToString()) && IsOffSynchParsingConditionSatisfied(telegramUserDataNew2.ToString(), Word())
                            && IsUnderSamplingConditionSatisfied(telegramUserDataNew2.ToString()) && CheckAperiodicityConditionForLongFormat(telegramUserDataNew2.ToString()))  //  
                        {
                            Console.WriteLine("Alphabet Condition Satisfied: ");
                            Console.WriteLine("OffSynchParsing Condition Satisfied: ");
                            Console.WriteLine("Under Sampling Condition Satisfied: ");
                            Console.WriteLine("Correct Telegram is: " + telegramUserDataNew2.ToString());
                            return telegramUserDataNew2.ToString();
                        }
                    }
                }
            }
            Console.WriteLine("No Valid detected");
            return "";
        }
    }
}