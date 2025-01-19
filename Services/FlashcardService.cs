// Services/FlashcardService.cs
using RamadanFlashcardsWeb.Models;
using System.Collections.Generic;

namespace RamadanFlashcardsWeb.Services
{
    public class FlashcardService
    {
        public List<Flashcard> GetFlashcards()
        {
            return new List<Flashcard>
           {
            // Basic Concepts
            new Flashcard { 
                Id = 1, 
                QuestionArabic = "ما هو رمضان؟",
                QuestionEnglish = "What is Ramadan?",
                AnswerArabic = "رمضان هو شهر الصيام المقدس عند المسلمين من الفجر إلى المغرب",
                AnswerEnglish = "Ramadan is the holy month when Muslims fast from sunrise to sunset",
                Category = "Basics",
                Difficulty = "Easy"
            },
            new Flashcard { 
                Id = 2, 
                QuestionArabic = "ما معنى الصيام في رمضان؟",
                QuestionEnglish = "What does fasting mean in Ramadan?",
                AnswerArabic = "الامتناع عن الطعام والشراب من الفجر إلى المغرب",
                AnswerEnglish = "Not eating or drinking from sunrise to sunset",
                Category = "Basics",
                Difficulty = "Easy"
            },
            
            // Prayer Times
            new Flashcard { 
                Id = 3, 
                QuestionArabic = "ما هو السحور؟",
                QuestionEnglish = "What is Suhoor?",
                AnswerArabic = "الوجبة التي يتناولها المسلمون قبل الفجر خلال رمضان",
                AnswerEnglish = "The meal Muslims eat before sunrise during Ramadan",
                Category = "Food",
                Difficulty = "Easy"
            },
            
            // Special Prayers
            new Flashcard { 
                Id = 4, 
                QuestionArabic = "ما هي صلاة التراويح؟",
                QuestionEnglish = "What is Taraweeh?",
                AnswerArabic = "صلاة خاصة يؤديها المسلمون في ليالي رمضان",
                AnswerEnglish = "Special prayers that Muslims perform at night during Ramadan",
                Category = "Prayer",
                Difficulty = "Medium"
            },

            // Quran
            new Flashcard { 
                Id = 5, 
                QuestionArabic = "متى نزل القرآن؟",
                QuestionEnglish = "When was the Quran revealed?",
                AnswerArabic = "بدأ نزول القرآن في شهر رمضان",
                AnswerEnglish = "The Quran began to be revealed in Ramadan",
                Category = "History",
                Difficulty = "Medium"
            },

            // Charity
            new Flashcard { 
                Id = 6, 
                QuestionArabic = "ما هي الزكاة؟",
                QuestionEnglish = "What is Zakat?",
                AnswerArabic = "مال يعطى للفقراء والمحتاجين",
                AnswerEnglish = "Money given to help those in need",
                Category = "Good Deeds",
                Difficulty = "Medium"
            },

            // Special Nights
            new Flashcard { 
                Id = 7, 
                QuestionArabic = "ما هي ليلة القدر؟",
                QuestionEnglish = "What is Laylat al-Qadr?",
                AnswerArabic = "ليلة مباركة في رمضان خير من ألف شهر",
                AnswerEnglish = "The blessed Night of Power - better than a thousand months",
                Category = "Special Days",
                Difficulty = "Medium"
            },

            // Eid
            new Flashcard { 
                Id = 8, 
                QuestionArabic = "ما هو عيد الفطر؟",
                QuestionEnglish = "What is Eid al-Fitr?",
                AnswerArabic = "عيد يحتفل به المسلمون في نهاية شهر رمضان",
                AnswerEnglish = "The celebration at the end of Ramadan",
                Category = "Special Days",
                Difficulty = "Easy"
            },// Basic Concepts
new Flashcard { 
    Id = 9, 
    QuestionArabic = "ما هو الهدف من الصيام في رمضان؟",
    QuestionEnglish = "What is the purpose of fasting in Ramadan?",
    AnswerArabic = "لتعزيز التقوى والروحانية",
    AnswerEnglish = "To enhance piety and spirituality",
    Category = "Basics",
    Difficulty = "Easy"
},
new Flashcard { 
    Id = 10, 
    QuestionArabic = "هل يجوز الصوم بدون نية؟",
    QuestionEnglish = "Is it permissible to fast without intention?",
    AnswerArabic = "لا، النية شرط من شروط صحة الصوم",
    AnswerEnglish = "No, intention is a requirement for the validity of fasting",
    Category = "Basics",
    Difficulty = "Medium"
},

// Prayer Times
new Flashcard { 
    Id = 11, 
    QuestionArabic = "ما هو الإفطار؟",
    QuestionEnglish = "What is Iftar?",
    AnswerArabic = "الوجبة التي يفطر بها المسلمون عند غروب الشمس",
    AnswerEnglish = "The meal Muslims eat to break their fast at sunset",
    Category = "Food",
    Difficulty = "Easy"
},
new Flashcard { 
    Id = 12, 
    QuestionArabic = "ما هو فضل السحور؟",
    QuestionEnglish = "What is the virtue of Suhoor?",
    AnswerArabic = "السحور سنة نبينا محمد صلى الله عليه وسلم",
    AnswerEnglish = "Suhoor is a Sunnah of our Prophet Muhammad (peace be upon him)",
    Category = "Food",
    Difficulty = "Medium"
},

// Special Prayers
new Flashcard { 
    Id = 13, 
    QuestionArabic = "كم عدد ركعات صلاة التراويح؟",
    QuestionEnglish = "How many units (Rak'ahs) are there in Taraweeh prayer?",
    AnswerArabic = "عدد ركعات التراويح يختلف ولكن الأفضل أن تكون ثمانية أو عشرين ركعة",
    AnswerEnglish = "The number of Rak'ahs in Taraweeh varies, but it is best to be eight or twenty units",
    Category = "Prayer",
    Difficulty = "Medium"
},
new Flashcard { 
    Id = 14, 
    QuestionArabic = "ما هي النية في الصلاة؟",
    QuestionEnglish = "What is intention (Niyyah) in prayer?",
    AnswerArabic = "النية هي قرار القلب لأداء العبادة لله",
    AnswerEnglish = "Intention is the determination of the heart to perform worship for Allah",
    Category = "Prayer",
    Difficulty = "Easy"
},

// Quran
new Flashcard { 
    Id = 15, 
    QuestionArabic = "ما هي السنة في قراءة القرآن خلال رمضان؟",
    QuestionEnglish = "What is the Sunnah regarding reciting the Quran during Ramadan?",
    AnswerArabic = "قراءة القرآن كاملاً مرة واحدة على الأقل خلال الشهر",
    AnswerEnglish = "To recite the entire Quran at least once during the month",
    Category = "History",
    Difficulty = "Medium"
},
new Flashcard { 
    Id = 16, 
    QuestionArabic = "ما هي أول سورة نزلت من القرآن؟",
    QuestionEnglish = "What is the first Surah revealed in the Quran?",
    AnswerArabic = "سورة العلق",
    AnswerEnglish = "Surah Al-Alaq",
    Category = "History",
    Difficulty = "Easy"
},

// Charity
new Flashcard { 
    Id = 17, 
    QuestionArabic = "ما هو الصدقة؟",
    QuestionEnglish = "What is Sadaqah?",
    AnswerArabic = "الصدقة هي تبرع بمال أو جهد لتلبية حاجة الأفراد والمجتمع",
    AnswerEnglish = "Sadaqah is a voluntary charity given to fulfill the needs of individuals and the community",
    Category = "Good Deeds",
    Difficulty = "Easy"
},
new Flashcard { 
    Id = 18, 
    QuestionArabic = "ما هو فضل الصدقة في رمضان؟",
    QuestionEnglish = "What is the virtue of giving Sadaqah during Ramadan?",
    AnswerArabic = "الصدقة في رمضان لها أجر مضاعف",
    AnswerEnglish = "Giving Sadaqah during Ramadan has multiplied rewards",
    Category = "Good Deeds",
    Difficulty = "Medium"
},

// Special Nights
new Flashcard { 
    Id = 19, 
    QuestionArabic = "ما هي أفضل ليلة في السنة؟",
    QuestionEnglish = "What is the best night of the year?",
    AnswerArabic = "ليلة القدر",
    AnswerEnglish = "Laylat al-Qadr",
    Category = "Special Days",
    Difficulty = "Easy"
},
new Flashcard { 
    Id = 20, 
    QuestionArabic = "ما هو أجر قيام ليلة القدر؟",
    QuestionEnglish = "What is the reward for worshipping during Laylat al-Qadr?",
    AnswerArabic = "يغفر الله الذنوب وتكتب الحسنات بأجر ألف شهر",
    AnswerEnglish = "Allah forgives sins and rewards equivalent to a thousand months are written",
    Category = "Special Days",
    Difficulty = "Medium"
},

// Eid
new Flashcard { 
    Id = 21, 
    QuestionArabic = "ما هي آداب عيد الفطر؟",
    QuestionEnglish = "What are the etiquettes of Eid al-Fitr?",
    AnswerArabic = "الغسل، ولبس أجمل الملابس، والتكبير، وصلاة العيد، وإعطاء الزكاة",
    AnswerEnglish = "Taking a bath, wearing the best clothes, making Takbeer, performing the Eid prayer, and giving Zakat",
    Category = "Special Days",
    Difficulty = "Easy"
},
new Flashcard { 
    Id = 22, 
    QuestionArabic = "ما هو فضل صلاة العيد؟",
    QuestionEnglish = "What is the virtue of the Eid prayer?",
    AnswerArabic = "جمع المسلمين وفرحتهم وشكرهم لله على النعم",
    AnswerEnglish = "It brings Muslims together in joy and gratitude to Allah for His blessings",
    Category = "Special Days",
    Difficulty = "Medium"
},

// Ramadan Practices
new Flashcard { 
    Id = 23, 
    QuestionArabic = "ما هي أفضل الأعمال في رمضان؟",
    QuestionEnglish = "What are the best deeds in Ramadan?",
    AnswerArabic = "قراءة القرآن، والدعاء، والصلاة، والصدقة",
    AnswerEnglish = "Reciting the Quran, making Dua, praying, and giving charity",
    Category = "Practices",
    Difficulty = "Easy"
},
new Flashcard { 
    Id = 24, 
    QuestionArabic = "ما هو حكم تأخير السحور؟",
    QuestionEnglish = "What is the ruling on delaying Suhoor?",
    AnswerArabic = "السنة تأخير السحور إلى ما قبل الفجر بقليل",
    AnswerEnglish = "It is Sunnah to delay Suhoor until just before dawn",
    Category = "Practices",
    Difficulty = "Medium"
},

// Health
new Flashcard { 
    Id = 25, 
    QuestionArabic = "هل الصيام مفيد للصحة؟",
    QuestionEnglish = "Is fasting beneficial for health?",
    AnswerArabic = "نعم، الصيام يعزز صحة القلب ويحسن التحكم في الوزن",
    AnswerEnglish = "Yes, fasting improves heart health and aids in weight management",
    Category = "Health",
    Difficulty = "Easy"
},
new Flashcard { 
    Id = 26, 
    QuestionArabic = "ما هو حكم الإفطار للمريض في رمضان؟",
    QuestionEnglish = "What is the ruling on a sick person breaking their fast in Ramadan?",
    AnswerArabic = "يجوز للمريض الإفطار إذا كان الصيام يؤثر على صحته",
    AnswerEnglish = "A sick person is permitted to break their fast if fasting affects their health",
    Category = "Health",
    Difficulty = "Medium"
},

// Family
new Flashcard { 
    Id = 27, 
    QuestionArabic = "كيف يمكن للعائلة الاستفادة من رمضان؟",
    QuestionEnglish = "How can the family benefit from Ramadan?",
    AnswerArabic = "بالاجتماع للصلاة والدعاء وتقديم العون لبعضهم البعض",
    AnswerEnglish = "By gathering for prayers, making Dua, and supporting each other",
    Category = "Family",
    Difficulty = "Easy"
},
new Flashcard { 
    Id = 28, 
    QuestionArabic = "ما هو دور الوالدين في توجيه الأطفال خلال رمضان؟",
    QuestionEnglish = "What is the role of parents in guiding children during Ramadan?",
    AnswerArabic = "تعليمهم الصوم والصلاة وأهمية العبادات والالتزام بها",
    AnswerEnglish = "Teaching them about fasting, prayer, the importance of worship, and adherence",
    Category = "Family",
    Difficulty = "Medium"
},

// Community
new Flashcard { 
    Id = 29, 
    QuestionArabic = "كيف يمكن للمسلمين تعزيز الوحدة خلال رمضان؟",
    QuestionEnglish = "How can Muslims foster unity during Ramadan?",
    AnswerArabic = "بالمشاركة في الأنشطة الاجتماعية والتعاون في الخيرات",
    AnswerEnglish = "By participating in social activities and cooperating in good deeds",
    Category = "Community",
    Difficulty = "Easy"
},
   };
        }
    }
}
