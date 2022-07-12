using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using sacramentMeetingPlanner.Data;
using System;
using System.Linq;

namespace sacramentMeetingPlanner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new sacramentMeetingPlannerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<sacramentMeetingPlannerContext>>()))
            {
                // Look for any movies.
                if (context.Bishopric.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bishopric.AddRange(
                    new Bishopric
                    {
                        Name = "Benjamin F",
                        Calling = "Bishop"
                    },

                    new Bishopric
                    {
                        Name = "Kevin C",
                        Calling = "1st Counselor"
                    },

                    new Bishopric
                    {
                        Name = "Tim T",
                        Calling = "2nd Counselor"
                    }
                );
                context.SaveChanges();

                // Look for any hymns.
                if (context.Hymn.Any())
                {
                    return;   // DB has been seeded
                }

                context.Hymn.AddRange(
                    new Hymn
                    {
                        Number = 1,
                        Title = "The Morning Breaks"
                    },

                    new Hymn
                    {
                        Number = 2,
                        Title = "The Spirit of God"
                    },

                    new Hymn
                    {
                        Number = 3,
                        Title = "Now Let Us Rejoice"
                    },

                    new Hymn
                    {
                        Number = 4,
                        Title = "Truth Eternal"
                    },

                    new Hymn
                    {
                        Number = 5,
                        Title = "High on the Mountain Top"
                    },

                    new Hymn
                    {
                        Number = 6,
                        Title = "Redeemer of Israel"
                    },
                    
                    new Hymn
                    {
                        Number = 7,
                        Title = "Israel, Israel, God is Calling"
                    },

                    new Hymn
                    {
                        Number = 8,
                        Title = "Awake and Arise"
                    },

                    new Hymn
                    {
                        Number = 9,
                        Title = "Come, Rejoice"
                    },

                    new Hymn
                    {
                        Number = 10,
                        Title = "Come, Sing to the Lord"
                    },

                    new Hymn
                    {
                        Number = 11,
                        Title = "What Was Witnessed in the Heavens?"
                    },

                    new Hymn
                    {
                        Number = 12,
                        Title = "'Twas Witnessed in the Heavens"
                    },

                    new Hymn
                    {
                        Number = 13,
                        Title = "An Angel from on High"
                    },

                    new Hymn
                    {
                        Number = 14,
                        Title = "Sweet is the Peace the Gospel Brings"
                    },

                    new Hymn
                    {
                        Number = 15,
                        Title = "I Saw a Mighty Angel Fly"
                    },
                    
                    new Hymn
                    {
                        Number = 16,
                        Title = "What Glorious Scenes Mine Eyes Behold"
                    },
                    
                    new Hymn
                    {
                        Number = 17,
                        Title = "Awake, Ye Saints of God, Awak"
                    },

                    new Hymn
                    {
                        Number = 18,
                        Title = "The Voice of God Again is Heard"
                    },

                    new Hymn
                    {
                        Number = 19,
                        Title = "We Thank Thee, O God, for a Prophet"
                    },

                    new Hymn
                    {
                        Number = 20,
                        Title = "God of Power, God of Right"
                    },
                    
                    new Hymn
                    {
                        Number = 21,
                        Title = "Come, Listen to a Prophet's Voice"
                    },

                    new Hymn
                    {
                        Number = 22,
                        Title = "We Listen to a Prophet's Voice"
                    },

                    new Hymn
                    {
                        Number = 23,
                        Title = "We Ever Pray for Thee"
                    },

                    new Hymn
                    {
                        Number = 24,
                        Title = "God Bless Our Prophet Dear"
                    },

                    new Hymn
                    {
                        Number = 25,
                        Title = "Now We'll Sing with One Accord"
                    },

                    new Hymn
                    {
                        Number = 26,
                        Title = "Joseph Smith's First Prayer"
                    },

                    new Hymn
                    {
                        Number = 27,
                        Title = "Praise to the Man"
                    },

                    new Hymn
                    {
                        Number = 28,
                        Title = "Saints, Behold How Great Jehovah"
                    },

                    new Hymn
                    {
                        Number = 29,
                        Title = "A Poor Wayfaring Man of Grief"
                    },

                    new Hymn
                    {
                        Number = 30,
                        Title = "Come, Come, Ye Saints"
                    },

                    new Hymn
                    {
                        Number = 31,
                        Title = "O God, Our Help in Ages Past"
                    },

                    new Hymn
                    {
                        Number = 32,
                        Title = "The Happy Day at Last Has Come"
                    },
                    
                    new Hymn
                    {
                        Number = 33,
                        Title = "Our Mountain Home So Dear"
                    },
                    
                    new Hymn
                    {
                        Number = 34,
                        Title = "O Ye Mountains High"
                    },
                    
                    new Hymn
                    {
                        Number = 35,
                        Title = "For the Strength of the Hills"
                    },
                    
                    new Hymn
                    {
                        Number = 36,
                        Title = "They, the Builders of the Nation"
                    },
                    
                    new Hymn
                    {
                        Number = 37,
                        Title = "The Wintry Day, Descending to Its Close"
                    },

                    new Hymn
                    {
                        Number = 38,
                        Title = "Come, All Ye Saints of Zion"
                    },
                    
                    new Hymn
                    {
                        Number = 39,
                        Title = "O Saints of Zion"
                    },
                    
                    new Hymn
                    {
                        Number = 40,
                        Title = "Arise, O Glorious Zion"
                    },

                    new Hymn
                    {
                        Number = 41,
                        Title = "Let Zion in Her Beauty Rise"
                    },

                    new Hymn
                    {
                        Number = 42,
                        Title = "Hail to the Brightness of Zion's Glad Morning!"
                    },
                    
                    new Hymn
                    {
                        Number = 43,
                        Title = "Zion Stands with Hills Surrounded"
                    },

                    new Hymn
                    {
                        Number = 44,
                        Title = "Beautiful Zion, Built Above"
                    },
                    
                    new Hymn
                    {
                        Number = 45,
                        Title = "Lead Me into Life Eternal"
                    },
                    
                    new Hymn
                    {
                        Number = 46,
                        Title = "Glorious Things of Thee Are Spoken"
                    },

                    new Hymn
                    {
                        Number = 47,
                        Title = "We Will Sing of Zion"
                    },

                    new Hymn
                    {
                        Number = 48,
                        Title = "Glorious Things Are Sung of Zion"
                    },
                    
                    new Hymn
                    {
                        Number = 49,
                        Title = "Adam-ondi-Ahman"
                    },

                    new Hymn
                    {
                        Number = 50,
                        Title = "Come, Thou Glorious Day of Promise"
                    },

                    new Hymn
                    {
                        Number = 51,
                        Title = "Sons of Michael, He Approaches"
                    },
                    
                    new Hymn
                    {
                        Number = 52,
                        Title = "The Day Dawn Is Breaking"
                    },

                    new Hymn
                    {
                        Number = 53,
                        Title = "Let Earth's Inhabitants Rejoice"
                    },

                    new Hymn
                    {
                        Number = 54,
                        Title = "Behold, the Mountain of the Lord"
                    },
                    
                    new Hymn
                    {
                        Number = 55,
                        Title = "Lo, the Mighty God Appearing!"
                    },

                    new Hymn
                    {
                        Number = 56,
                        Title = "Softly Beams the Sacred Dawning"
                    },

                    new Hymn
                    {
                        Number = 57,
                        Title = "We're Not Ashamed to Own Our Lord"
                    },
                    
                    new Hymn
                    {
                        Number = 58,
                        Title = "Come, Ye Children of the Lord"
                    },

                    new Hymn
                    {
                        Number = 59,
                        Title = "Come, O Thou King of Kings"
                    },

                    new Hymn
                    {
                        Number = 60,
                        Title = "Battle Hymn of the Republic"
                    },
                    
                    new Hymn
                    {
                        Number = 61,
                        Title = "Raise Your Voices to the Lord"
                    },

                    new Hymn
                    {
                        Number = 62,
                        Title = "All Creatures of Our God and King"
                    },

                    new Hymn
                    {
                        Number = 63,
                        Title = "Great King of Heaven"
                    },
                    
                    new Hymn
                    {
                        Number = 64,
                        Title = "On This Day of Joy and Gladness"
                    },

                    new Hymn
                    {
                        Number = 65,
                        Title = "Come, All Ye Saints Who Dwell on Earth"
                    },

                    new Hymn
                    {
                        Number = 66,
                        Title = "Rejoice, the Lord is King!"
                    },
                    
                    new Hymn
                    {
                        Number = 67,
                        Title = "Glory to God on High"
                    },

                    new Hymn
                    {
                        Number = 68,
                        Title = "A Mighty Fortress is Our God"
                    },

                    new Hymn
                    {
                        Number = 69,
                        Title = "All Glory, Laud, and Honor"
                    },
                    
                    new Hymn
                    {
                        Number = 70,
                        Title = "Sing Praise to Him"
                    },

                    new Hymn
                    {
                        Number = 71,
                        Title = "With Songs of Praise"
                    },

                    new Hymn
                    {
                        Number = 72,
                        Title = "Praise to the Lord, the Almighty"
                    },
                    
                    new Hymn
                    {
                        Number = 73,
                        Title = "Praise the Lord with Heart and Voice"
                    },

                    new Hymn
                    {
                        Number = 74,
                        Title = "Praise Ye the Lord"
                    },

                    new Hymn
                    {
                        Number = 75,
                        Title = "In Hymns of Praise"
                    },

                    new Hymn
                    {
                        Number = 76,
                        Title = "God of Our Fathers, We Come unto Thee"
                    },

                    new Hymn
                    {
                        Number = 77,
                        Title = "Great Is the Lord"
                    },

                    new Hymn
                    {
                        Number = 78,
                        Title = "God of Our Fathers, Whose Almighty Hand"
                    },

                    new Hymn
                    {
                        Number = 79,
                        Title = "With All the Power of Heart and Tongue"
                    },

                    new Hymn
                    {
                        Number = 80,
                        Title = "God of Our Fathers, Known of Old"
                    },

                    new Hymn
                    {
                        Number = 81,
                        Title = "Press Forward, Saints"
                    },

                    new Hymn
                    {
                        Number = 82,
                        Title = "For All the Saints"
                    },

                    new Hymn
                    {
                        Number = 83,
                        Title = "Guide Us, O Thou Great Jehovah"
                    },

                    new Hymn
                    {
                        Number = 84,
                        Title = "Faith of Our Fathers"
                    },

                    new Hymn
                    {
                        Number = 85,
                        Title = "How Firm a Foundation"
                    },

                    new Hymn
                    {
                        Number = 86,
                        Title = "How Great Thou Art"
                    },

                    new Hymn
                    {
                        Number = 87,
                        Title = "God Is Love"
                    },

                    new Hymn
                    {
                        Number = 88,
                        Title = "Great God, Attend While Zion Sings"
                    },

                    new Hymn
                    {
                        Number = 89,
                        Title = "The Lord Is My Light"
                    },

                    new Hymn
                    {
                        Number = 90,
                        Title = "From All That Dwell below the Skies"
                    },

                    new Hymn
                    {
                        Number = 91,
                        Title = "Father, Thy Children to Thee Now Raise"
                    },

                    new Hymn
                    {
                        Number = 92,
                        Title = "For the Beauty of the Earth"
                    },

                    new Hymn
                    {
                        Number = 93,
                        Title = "Prayer of Thanksgiving"
                    },

                    new Hymn
                    {
                        Number = 94,
                        Title = "Come, Ye Thankful People"
                    },

                    new Hymn
                    {
                        Number = 95,
                        Title = "Now Thank We All Our God"
                    },

                    new Hymn
                    {
                        Number = 96,
                        Title = "Dearest Children, God Is Near You"
                    },

                    new Hymn
                    {
                        Number = 97,
                        Title = "Lead, Kindly Light"
                    },

                    new Hymn
                    {
                        Number = 98,
                        Title = "I Need Thee Every Hour"
                    },

                    new Hymn
                    {
                        Number = 99,
                        Title = "Nearer, Dear Savior, to Thee"
                    },

                    new Hymn
                    {
                        Number = 100,
                        Title = "Nearer, My God, to Thee"
                    },

                    new Hymn
                    {
                        Number = 101,
                        Title = "Guide Me to Thee"
                    },

                    new Hymn
                    {
                        Number = 102,
                        Title = "Jesus, Lover of My Soul"
                    },

                    new Hymn
                    {
                        Number = 103,
                        Title = "Precious Savior, Dear Redeemer"
                    },

                    new Hymn
                    {
                        Number = 104,
                        Title = "Jesus, Savior, Pilot Me"
                    },

                    new Hymn
                    {
                        Number = 105,
                        Title = "Master, the Tempest Is Raging"
                    },

                    new Hymn
                    {
                        Number = 106,
                        Title = "God Speed the Right"
                    },

                    new Hymn
                    {
                        Number = 107,
                        Title = "Lord, Accept Our True Devotion"
                    },

                    new Hymn
                    {
                        Number = 108,
                        Title = "The Lord Is My Shepherd"
                    },

                    new Hymn
                    {
                        Number = 109,
                        Title = "The Lord My Pasture Will Prepare"
                    },

                    new Hymn
                    {
                        Number = 110,
                        Title = "Cast Thy Burden upon the Lord"
                    },

                    new Hymn
                    {
                        Number = 111,
                        Title = "Rock of Ages"
                    },

                    new Hymn
                    {
                        Number = 112,
                        Title = "Savior, Redeemer of My Soul"
                    },

                    new Hymn
                    {
                        Number = 113,
                        Title = "Our Savior's Love"
                    },

                    new Hymn
                    {
                        Number = 114,
                        Title = "Come unto Him"
                    },

                    new Hymn
                    {
                        Number = 115,
                        Title = "Come, Ye Disconsolate"
                    },

                    new Hymn
                    {
                        Number = 116,
                        Title = "Come, Follow Me"
                    },

                    new Hymn
                    {
                        Number = 117,
                        Title = "Come unto Jesus"
                    },

                    new Hymn
                    {
                        Number = 118,
                        Title = "Ye Simple Souls Who Stray"
                    },

                    new Hymn
                    {
                        Number = 119,
                        Title = "Come, We That Love the Lord"
                    },

                    new Hymn
                    {
                        Number = 120,
                        Title = "Lean on My Ample Arm"
                    },

                    new Hymn
                    {
                        Number = 121,
                        Title = "I'm a Pilgrim, I'm a Stranger"
                    },

                    new Hymn
                    {
                        Number = 122,
                        Title = "Though Deepening Trials"
                    },

                    new Hymn
                    {
                        Number = 123,
                        Title = "Oh, May My Soul Commune with Thee"
                    },

                    new Hymn
                    {
                        Number = 124,
                        Title = "Be Still, My Soul"
                    },

                    new Hymn
                    {
                        Number = 125,
                        Title = "How Gentle God's Commands"
                    },

                    new Hymn
                    {
                        Number = 126,
                        Title = "How Long, O Lord Most Holy and True"
                    },

                    new Hymn
                    {
                        Number = 127,
                        Title = "Does the Journey Seem Long?"
                    },

                    new Hymn
                    {
                        Number = 128,
                        Title = "When Faith Endures"
                    },

                    new Hymn
                    {
                        Number = 129,
                        Title = "Where Can I turn for Peace"
                    },

                    new Hymn
                    {
                        Number = 130,
                        Title = "Be Thou Humble"
                    },

                    new Hymn
                    {
                        Number = 131,
                        Title = "More Holiness Give Me"
                    },

                    new Hymn
                    {
                        Number = 132,
                        Title = "God Is in His Holy Temple"
                    },

                    new Hymn
                    {
                        Number = 133,
                        Title = "Father in Heaven"
                    },

                    new Hymn
                    {
                        Number = 134,
                        Title = "I Believe in Christ"
                    },

                    new Hymn
                    {
                        Number = 135,
                        Title = "My Redeemer Lives"
                    },

                    new Hymn
                    {
                        Number = 136,
                        Title = "I Know That My Redeemer Lives"
                    },

                    new Hymn
                    {
                        Number = 137,
                        Title = "Testimony"
                    },

                    new Hymn
                    {
                        Number = 138,
                        Title = "Bless Our Fast, We Pray"
                    },

                    new Hymn
                    {
                        Number = 139,
                        Title = "In Fasting We Approach Thee"
                    },

                    new Hymn
                    {
                        Number = 140,
                        Title = "Did You Think to Pray"
                    },

                    new Hymn
                    {
                        Number = 141,
                        Title = "Jesus, the Very Thought of Thee"
                    },

                    new Hymn
                    {
                        Number = 142,
                        Title = "Sweet Hour of Prayer"
                    },

                    new Hymn
                    {
                        Number = 143,
                        Title = "Let the Holy Spirit Guide"
                    },

                    new Hymn
                    {
                        Number = 144,
                        Title = "Secret Prayer"
                    },

                    new Hymn
                    {
                        Number = 145,
                        Title = "Prayer Is the Soul's Sincere Desire"
                    },

                    new Hymn
                    {
                        Number = 146,
                        Title = "Gently Raise the Sacred Strain"
                    },

                    new Hymn
                    {
                        Number = 147,
                        Title = "Sweet Is the Word"
                    },

                    new Hymn
                    {
                        Number = 148,
                        Title = "Sabbath Day"
                    },

                    new Hymn
                    {
                        Number = 149,
                        Title = "As the Dew from Heaven Distilling"
                    },

                    new Hymn
                    {
                        Number = 150,
                        Title = "O Thou Kind and Gracious Father"
                    },

                    new Hymn
                    {
                        Number = 151,
                        Title = "We Meet, Dear Lord"
                    },

                    new Hymn
                    {
                        Number = 152,
                        Title = "God Be with you Till We Meet Again"
                    },

                    new Hymn
                    {
                        Number = 153,
                        Title = "Lord, We Ask Thee Ere We Part"
                    },

                    new Hymn
                    {
                        Number = 154,
                        Title = "Father, This Hour Has Been One of Joy"
                    },

                    new Hymn
                    {
                        Number = 155,
                        Title = "We Have Partaken of Thy Love"
                    },

                    new Hymn
                    {
                        Number = 156,
                        Title = "Sing We Now at Parting"
                    },

                    new Hymn
                    {
                        Number = 157,
                        Title = "Thy Spirit, Lord, Has Stirred Our Souls"
                    },

                    new Hymn
                    {
                        Number = 158,
                        Title = "Before Thee, Lord, I Bow My Head"
                    },

                    new Hymn
                    {
                        Number = 159,
                        Title = "Now the Day Is Over"
                    },

                    new Hymn
                    {
                        Number = 160,
                        Title = "Softly Now the Light of Day"
                    },

                    new Hymn
                    {
                        Number = 161,
                        Title = "The Lord Be with Us"
                    },

                    new Hymn
                    {
                        Number = 162,
                        Title = "Lord, We Come before Thee Now"
                    },

                    new Hymn
                    {
                        Number = 163,
                        Title = "Lord, Dismiss Us with Thy Blessing"
                    },

                    new Hymn
                    {
                        Number = 164,
                        Title = "Great God, to Thee My Evening Song"
                    },

                    new Hymn
                    {
                        Number = 165,
                        Title = "Abide with Me; 'Tis Eventide"
                    },

                    new Hymn
                    {
                        Number = 166,
                        Title = "Abide with Me!"
                    },

                    new Hymn
                    {
                        Number = 167,
                        Title = "Come, Let Us Sing an Evening Hymn"
                    },

                    new Hymn
                    {
                        Number = 168,
                        Title = "As the Shadows Fall"
                    },

                    new Hymn
                    {
                        Number = 169,
                        Title = "As Now We Take the Sacrament"
                    },

                    new Hymn
                    {
                        Number = 170,
                        Title = "God, Our Father, Hear Us Pray"
                    },

                    new Hymn
                    {
                        Number = 171,
                        Title = "With Humble Heart"
                    },

                    new Hymn
                    {
                        Number = 172,
                        Title = "In Humility, Our Savior"
                    },

                    new Hymn
                    {
                        Number = 173,
                        Title = "While of These Emblems We Partake"
                    },

                    new Hymn
                    {
                        Number = 174,
                        Title = "While of These Emblems We Partake"
                    },

                    new Hymn
                    {
                        Number = 175,
                        Title = "O God, the Eternal Father"
                    },

                    new Hymn
                    {
                        Number = 176,
                        Title = "'Tis Sweet to Sing the Matchless Love"
                    },

                    new Hymn
                    {
                        Number = 177,
                        Title = "'Tis Sweet to Sing the Matchless Love"
                    },

                    new Hymn
                    {
                        Number = 178,
                        Title = "O Lord of Hosts"
                    },

                    new Hymn
                    {
                        Number = 179,
                        Title = "Again, our Dear Redeeming Lord"
                    },

                    new Hymn
                    {
                        Number = 180,
                        Title = "Father in Heaven, We Do Believe"
                    },

                    new Hymn
                    {
                        Number = 181,
                        Title = "Jesus of Nazareth, Savior and King"
                    },

                    new Hymn
                    {
                        Number = 182,
                        Title = "We'll Sing All Hail to Jesus' Name"
                    },

                    new Hymn
                    {
                        Number = 183,
                        Title = "In Remembrance of Thy Suffering"
                    },

                    new Hymn
                    {
                        Number = 184,
                        Title = "Upon the Cross of Calvary"
                    },

                    new Hymn
                    {
                        Number = 185,
                        Title = "Reverently and Meekly Now"
                    },

                    new Hymn
                    {
                        Number = 186,
                        Title = "Again We Meet around the Board"
                    },

                    new Hymn
                    {
                        Number = 187,
                        Title = "God Love Us, So He Sent His Son"
                    },

                    new Hymn
                    {
                        Number = 188,
                        Title = "Thy Will, O Lord, Be Done"
                    },

                    new Hymn
                    {
                        Number = 189,
                        Title = "O Thou, Before the World Began"
                    },

                    new Hymn
                    {
                        Number = 190,
                        Title = "In Memory of the Crucified"
                    },

                    new Hymn
                    {
                        Number = 191,
                        Title = "Behold the Great Redeemer Die"
                    },

                    new Hymn
                    {
                        Number = 192,
                        Title = "He Died! The Great Redeemer Died"
                    },

                    new Hymn
                    {
                        Number = 193,
                        Title = "I Stand All Amazed"
                    },

                    new Hymn
                    {
                        Number = 194,
                        Title = "There Is a Green Hill Far Away"
                    },

                    new Hymn
                    {
                        Number = 195,
                        Title = "How Great the Wisdom and the Love"
                    },

                    new Hymn
                    {
                        Number = 196,
                        Title = "Jesus, Once of Humble Birth"
                    },

                    new Hymn
                    {
                        Number = 197,
                        Title = "O Savior, Thou Who Wearest a Crown"
                    },

                    new Hymn
                    {
                        Number = 198,
                        Title = "That Easter Morn"
                    },

                    new Hymn
                    {
                        Number = 199,
                        Title = "He Is Risen!"
                    },

                    new Hymn
                    {
                        Number = 200,
                        Title = "Christ the Lord Is Risen Today"
                    },

                    new Hymn
                    {
                        Number = 201,
                        Title = "Joy to the World"
                    },

                    new Hymn
                    {
                        Number = 202,
                        Title = "Oh, Come, All Ye Faithful"
                    },

                    new Hymn
                    {
                        Number = 203,
                        Title = "Angels We Have Heard on High"
                    },

                    new Hymn
                    {
                        Number = 204,
                        Title = "Silent Night"
                    },

                    new Hymn
                    {
                        Number = 205,
                        Title = "Once in Royal David's City"
                    },

                    new Hymn
                    {
                        Number = 206,
                        Title = "Away in a Manger"
                    },

                    new Hymn
                    {
                        Number = 207,
                        Title = "It Came upon the Midnight Clear"
                    },

                    new Hymn
                    {
                        Number = 208,
                        Title = "O Little Town of Bethlehem"
                    },

                    new Hymn
                    {
                        Number = 209,
                        Title = "Hark! The Herald Angels Sing"
                    },

                    new Hymn
                    {
                        Number = 210,
                        Title = "With Wondering Awe"
                    },

                    new Hymn
                    {
                        Number = 211,
                        Title = "While Shepherds Watched Their Flocks"
                    },

                    new Hymn
                    {
                        Number = 212,
                        Title = "Far, Far Away on Judea’s Plains"
                    },

                    new Hymn
                    {
                        Number = 213,
                        Title = "The First Noel"
                    },

                    new Hymn
                    {
                        Number = 214,
                        Title = "I Heard the Bells on Christmas Day"
                    },

                    new Hymn
                    {
                        Number = 215,
                        Title = "Ring Out, Wild Bells"
                    },

                    new Hymn
                    {
                        Number = 216,
                        Title = "We Are Sowing"
                    },

                    new Hymn
                    {
                        Number = 217,
                        Title = "Come, Let Us Anew"
                    },

                    new Hymn
                    {
                        Number = 218,
                        Title = "We Give Thee But Thine Own"
                    },

                    new Hymn
                    {
                        Number = 219,
                        Title = "Because I Have Been Given Much"
                    },

                    new Hymn
                    {
                        Number = 220,
                        Title = "Lord, I Would Follow Thee"
                    },

                    new Hymn
                    {
                        Number = 221,
                        Title = "Dear to the Heart of the Shepherd"
                    },

                    new Hymn
                    {
                        Number = 222,
                        Title = "Hear Thou Our Hymn, O Lord"
                    },

                    new Hymn
                    {
                        Number = 223,
                        Title = "Have I Done Any Good?"
                    },

                    new Hymn
                    {
                        Number = 224,
                        Title = "I Have Work Enough to Do"
                    },

                    new Hymn
                    {
                        Number = 225,
                        Title = "We Are Marching On to Glory"
                    },

                    new Hymn
                    {
                        Number = 226,
                        Title = "Improve the Shining Moments"
                    },

                    new Hymn
                    {
                        Number = 227,
                        Title = "There Is Sunshine in My Soul Today"
                    },

                    new Hymn
                    {
                        Number = 228,
                        Title = "You Can Make the Pathway Bright"
                    },

                    new Hymn
                    {
                        Number = 229,
                        Title = "Today, While the Sun Shines"
                    },

                    new Hymn
                    {
                        Number = 230,
                        Title = "Scatter Sunshine"
                    },

                    new Hymn
                    {
                        Number = 231,
                        Title = "Father, Cheer Our Souls Tonight"
                    },

                    new Hymn
                    {
                        Number = 232,
                        Title = "Let Us Oft Speak Kind Words"
                    },

                    new Hymn
                    {
                        Number = 233,
                        Title = "Nay, Speak No Ill"
                    },

                    new Hymn
                    {
                        Number = 234,
                        Title = "Jesus, Mighty King in Zion"
                    },

                    new Hymn
                    {
                        Number = 235,
                        Title = "Should You Feel Inclined to Censure"
                    },

                    new Hymn
                    {
                        Number = 236,
                        Title = "Lord, Accept into Thy Kingdom"
                    },

                    new Hymn
                    {
                        Number = 237,
                        Title = "Do What Is Right"
                    },

                    new Hymn
                    {
                        Number = 238,
                        Title = "Behold Thy Sons and Daughters, Lord"
                    },

                    new Hymn
                    {
                        Number = 239,
                        Title = "Choose the Right"
                    },

                    new Hymn
                    {
                        Number = 240,
                        Title = "Know This, That Every Soul Is Free"
                    },

                    new Hymn
                    {
                        Number = 241,
                        Title = "Count Your Blessings"
                    },

                    new Hymn
                    {
                        Number = 242,
                        Title = "Praise God, from Whom All Blessings Flow"
                    },

                    new Hymn
                    {
                        Number = 243,
                        Title = "Let Us All Press On"
                    },

                    new Hymn
                    {
                        Number = 244,
                        Title = "Come Along, Come Along"
                    },

                    new Hymn
                    {
                        Number = 245,
                        Title = "This House We Dedicate to Thee"
                    },

                    new Hymn
                    {
                        Number = 246,
                        Title = "Onward, Christian Soldiers"
                    },

                    new Hymn
                    {
                        Number = 247,
                        Title = "We Love Thy House, O God"
                    },

                    new Hymn
                    {
                        Number = 248,
                        Title = "Up, Awake, Ye Defenders of Zion"
                    },

                    new Hymn
                    {
                        Number = 249,
                        Title = "Called to Serve"
                    },

                    new Hymn
                    {
                        Number = 250,
                        Title = "We Are All Enlisted"
                    },

                    new Hymn
                    {
                        Number = 251,
                        Title = "Behold! A Royal Army"
                    },

                    new Hymn
                    {
                        Number = 252,
                        Title = "Put Your Shoulder to the Wheel"
                    },

                    new Hymn
                    {
                        Number = 253,
                        Title = "Like Ten Thousand Legions Marching"
                    },

                    new Hymn
                    {
                        Number = 254,
                        Title = "True to the Faith"
                    },

                    new Hymn
                    {
                        Number = 255,
                        Title = "Carry On"
                    },

                    new Hymn
                    {
                        Number = 256,
                        Title = "As Zion’s Youth in Latter Days"
                    },

                    new Hymn
                    {
                        Number = 257,
                        Title = "Rejoice! A Glorious Sound Is Heard"
                    },

                    new Hymn
                    {
                        Number = 258,
                        Title = "O Thou Rock of Our Salvation"
                    },

                    new Hymn
                    {
                        Number = 259,
                        Title = "Hope of Israel"
                    },

                    new Hymn
                    {
                        Number = 260,
                        Title = "Who’s on the Lord’s Side?"
                    },

                    new Hymn
                    {
                        Number = 261,
                        Title = "Thy Servants Are Prepared"
                    },

                    new Hymn
                    {
                        Number = 262,
                        Title = "Go, Ye Messengers of Glory"
                    },

                    new Hymn
                    {
                        Number = 263,
                        Title = "Go Forth with Faith"
                    },

                    new Hymn
                    {
                        Number = 264,
                        Title = "Hark, All Ye Nations!"
                    },

                    new Hymn
                    {
                        Number = 265,
                        Title = "Arise, O God, and Shine"
                    },

                    new Hymn
                    {
                        Number = 266,
                        Title = "The Time Is Far Spent"
                    },

                    new Hymn
                    {
                        Number = 267,
                        Title = "How Wondrous and Great"
                    },

                    new Hymn
                    {
                        Number = 268,
                        Title = "Come, All Whose Souls Are Lighted"
                    },

                    new Hymn
                    {
                        Number = 269,
                        Title = "Jehovah, Lord of Heaven and Earth"
                    },

                    new Hymn
                    {
                        Number = 270,
                        Title = "I’ll Go Where You Want Me to Go"
                    },

                    new Hymn
                    {
                        Number = 271,
                        Title = "Oh, Holy Words of Truth and Love"
                    },

                    new Hymn
                    {
                        Number = 272,
                        Title = "Oh Say, What Is Truth?"
                    },

                    new Hymn
                    {
                        Number = 273,
                        Title = "Truth Reflects upon Our Senses"
                    },

                    new Hymn
                    {
                        Number = 274,
                        Title = "The Iron Rod"
                    },

                    new Hymn
                    {
                        Number = 275,
                        Title = "Men Are That They Might Have Joy"
                    },

                    new Hymn
                    {
                        Number = 276,
                        Title = "Come Away to the Sunday School"
                    },

                    new Hymn
                    {
                        Number = 277,
                        Title = "As I Search the Holy Scriptures"
                    },

                    new Hymn
                    {
                        Number = 278,
                        Title = "Thanks for the Sabbath School"
                    },

                    new Hymn
                    {
                        Number = 279,
                        Title = "Thy Holy Word"
                    },

                    new Hymn
                    {
                        Number = 280,
                        Title = "Welcome, Welcome, Sabbath Morning"
                    },

                    new Hymn
                    {
                        Number = 281,
                        Title = "Help Me Teach with Inspiration"
                    },

                    new Hymn
                    {
                        Number = 282,
                        Title = "We Meet Again in Sabbath School"
                    },

                    new Hymn
                    {
                        Number = 283,
                        Title = "The Glorious Gospel Light Has Shone"
                    },

                    new Hymn
                    {
                        Number = 284,
                        Title = "If You Could Hie to Kolob"
                    },

                    new Hymn
                    {
                        Number = 285,
                        Title = "God Moves in a Mysterious Way"
                    },

                    new Hymn
                    {
                        Number = 286,
                        Title = "Oh, What Songs of the Heart"
                    },

                    new Hymn
                    {
                        Number = 287,
                        Title = "Rise, Ye Saints, and Temples Enter"
                    },

                    new Hymn
                    {
                        Number = 288,
                        Title = "How Beautiful Thy Temples, Lord"
                    },

                    new Hymn
                    {
                        Number = 289,
                        Title = "Holy Temples on Mount Zion"
                    },

                    new Hymn
                    {
                        Number = 290,
                        Title = "Rejoice, Ye Saints of Latter Days"
                    },

                    new Hymn
                    {
                        Number = 291,
                        Title = "Turn Your Hearts"
                    },

                    new Hymn
                    {
                        Number = 292,
                        Title = "O My Father"
                    },

                    new Hymn
                    {
                        Number = 293,
                        Title = "Each Life That Touches Ours for Good"
                    },

                    new Hymn
                    {
                        Number = 294,
                        Title = "Love at Home"
                    },

                    new Hymn
                    {
                        Number = 295,
                        Title = "O Love That Glorifies the Son"
                    },

                    new Hymn
                    {
                        Number = 296,
                        Title = "Our Father, by Whose Name"
                    },

                    new Hymn
                    {
                        Number = 297,
                        Title = "From Homes of Saints Glad Songs Arise"
                    },

                    new Hymn
                    {
                        Number = 298,
                        Title = "Home Can Be a Heaven on Earth"
                    },

                    new Hymn
                    {
                        Number = 299,
                        Title = "Children of Our Heavenly Father"
                    },

                    new Hymn
                    {
                        Number = 300,
                        Title = "Families Can Be Together Forever"
                    },

                    new Hymn
                    {
                        Number = 301,
                        Title = "I Am a Child of God"
                    },
                    new Hymn
                    {
                        Number = 302,
                        Title = "I Know My Father Lives"
                    },

                    new Hymn
                    {
                        Number = 303,
                        Title = "Keep the Commandments"
                    },

                    new Hymn
                    {
                        Number = 304,
                        Title = "Teach Me to Walk in the Light"
                    },
                    new Hymn
                    {
                        Number = 305,
                        Title = "The Light Divine"
                    },

                    new Hymn
                    {
                        Number = 306,
                        Title = "God’s Daily Care"
                    },

                    new Hymn
                    {
                        Number = 307,
                        Title = "In Our Lovely Deseret"
                    },

                    new Hymn
                    {
                        Number = 308,
                        Title = "Love One Another"
                    },

                    new Hymn
                    {
                        Number = 309,
                        Title = "As Sisters in Zion"
                    },
                    new Hymn
                    {
                        Number = 310,
                        Title = "A Key Was Turned in Latter Days"
                    },

                    new Hymn
                    {
                        Number = 311,
                        Title = "We Meet Again as Sisters"
                    },

                    new Hymn
                    {
                        Number = 312,
                        Title = "We Ever Pray for Thee"
                    },

                    new Hymn
                    {
                        Number = 313,
                        Title = "God Is Love"
                    },

                    new Hymn
                    {
                        Number = 314,
                        Title = "How Gentle God’s Commands"
                    },
                    new Hymn
                    {
                        Number = 315,
                        Title = "Jesus, the Very Thought of Thee"
                    },
                    new Hymn
                    {
                        Number = 316,
                        Title = "The Lord Is My Shepherd"
                    },

                    new Hymn
                    {
                        Number = 317,
                        Title = "Sweet Is the Work"
                    },

                    new Hymn
                    {
                        Number = 318,
                        Title = "Love at Home"
                    },
                    
                    new Hymn
                    {
                        Number = 319,
                        Title = "Ye Elders of Israel"
                    },
                    
                    new Hymn
                    {
                        Number = 320,
                        Title = "The Priesthood of Our Lord"
                    },

                    new Hymn
                    {
                        Number = 321,
                        Title = "Ye Who Are Called to Labor"
                    },

                    new Hymn
                    {
                        Number = 322,
                        Title = "Come, All Ye Sons of God"
                    },
                    new Hymn
                    {
                        Number = 323,
                        Title = "Rise Up, O Men of God"
                    },
                    
                    new Hymn
                    {
                        Number = 324,
                        Title = "Rise Up, O Men of God"
                    },
                    
                    new Hymn
                    {
                        Number = 325,
                        Title = "See the Mighty Priesthood Gathered"
                    },

                    new Hymn
                    {
                        Number = 326,
                        Title = "Come, Come, Ye Saints"
                    },

                    new Hymn
                    {
                        Number = 327,
                        Title = "Go, Ye Messengers of Heaven"
                    },

                    new Hymn
                    {
                        Number = 328,
                        Title = "An Angel from on High"
                    },

                    new Hymn
                    {
                        Number = 329,
                        Title = "Thy Servants Are Prepared"
                    },

                    new Hymn
                    {
                        Number = 330,
                        Title = "See, the Mighty Angel Flying"
                    },
                    new Hymn
                    {
                        Number = 331,
                        Title = "Oh Say, What Is Truth?"
                    },
                    new Hymn
                    {
                        Number = 332,
                        Title = "Come, O Thou King of Kings"
                    },

                    new Hymn
                    {
                        Number = 333,
                        Title = "High on the Mountain Top"
                    },

                    new Hymn
                    {
                        Number = 334,
                        Title = "I Need Thee Every Hour"
                    },

                    new Hymn
                    {
                        Number = 335,
                        Title = "Brightly Beams Our Father’s Mercy"
                    },

                    new Hymn
                    {
                        Number = 336,
                        Title = "School Thy Feelings"
                    },

                    new Hymn
                    {
                        Number = 337,
                        Title = "O home Beloved"
                    },
                    new Hymn
                    {
                        Number = 338,
                        Title = "America the Beautiful"
                    },
                    new Hymn
                    {
                        Number = 339,
                        Title = "My Country, Tis of Thee"
                    },
                    new Hymn
                    {
                        Number = 340,
                        Title = "The Star-Spangled Banner"
                    },

                    new Hymn
                    {
                        Number = 341,
                        Title = "God Save the King"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

