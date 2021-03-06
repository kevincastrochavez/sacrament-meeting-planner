// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sacramentMeetingPlanner.Data;

#nullable disable

namespace sacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(sacramentMeetingPlannerContext))]
    partial class sacramentMeetingPlannerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("sacramentMeetingPlanner.Models.Bishopric", b =>
                {
                    b.Property<int>("BishopricID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Calling")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BishopricID");

                    b.ToTable("Bishopric", (string)null);
                });

            modelBuilder.Entity("sacramentMeetingPlanner.Models.Hymn", b =>
                {
                    b.Property<int>("HymnID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("HymnID");

                    b.ToTable("Hymn", (string)null);
                });

            modelBuilder.Entity("sacramentMeetingPlanner.Models.SacramentMeeting", b =>
                {
                    b.Property<int>("SacramentMeetingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Benediction")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int?>("BishopricID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClosingHymnID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ConductingID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DismissalHymnID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("HymnID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Invocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int?>("MusicalNumberID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MusicalPerformance")
                        .HasColumnType("TEXT");

                    b.Property<int?>("OpeningHymnID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PresidingID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SacramentHymnID")
                        .HasColumnType("INTEGER");

                    b.HasKey("SacramentMeetingID");

                    b.HasIndex("BishopricID");

                    b.HasIndex("ClosingHymnID");

                    b.HasIndex("ConductingID");

                    b.HasIndex("DismissalHymnID");

                    b.HasIndex("HymnID");

                    b.HasIndex("MusicalNumberID");

                    b.HasIndex("OpeningHymnID");

                    b.HasIndex("PresidingID");

                    b.HasIndex("SacramentHymnID");

                    b.ToTable("SacramentMeeting", (string)null);
                });

            modelBuilder.Entity("sacramentMeetingPlanner.Models.Speaker", b =>
                {
                    b.Property<int>("SpeakerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("SacramentMeetingID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubjectType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SpeakerID");

                    b.HasIndex("SacramentMeetingID");

                    b.ToTable("Speaker", (string)null);
                });

            modelBuilder.Entity("sacramentMeetingPlanner.Models.SacramentMeeting", b =>
                {
                    b.HasOne("sacramentMeetingPlanner.Models.Bishopric", "Bishopric")
                        .WithMany()
                        .HasForeignKey("BishopricID");

                    b.HasOne("sacramentMeetingPlanner.Models.Hymn", "ClosingHymn")
                        .WithMany()
                        .HasForeignKey("ClosingHymnID");

                    b.HasOne("sacramentMeetingPlanner.Models.Bishopric", "Conducting")
                        .WithMany()
                        .HasForeignKey("ConductingID");

                    b.HasOne("sacramentMeetingPlanner.Models.Hymn", "DismissalHymn")
                        .WithMany()
                        .HasForeignKey("DismissalHymnID");

                    b.HasOne("sacramentMeetingPlanner.Models.Hymn", "Hymn")
                        .WithMany()
                        .HasForeignKey("HymnID");

                    b.HasOne("sacramentMeetingPlanner.Models.Hymn", "MusicalNumber")
                        .WithMany()
                        .HasForeignKey("MusicalNumberID");

                    b.HasOne("sacramentMeetingPlanner.Models.Hymn", "OpeningHymn")
                        .WithMany()
                        .HasForeignKey("OpeningHymnID");

                    b.HasOne("sacramentMeetingPlanner.Models.Bishopric", "Presiding")
                        .WithMany()
                        .HasForeignKey("PresidingID");

                    b.HasOne("sacramentMeetingPlanner.Models.Hymn", "SacramentHymn")
                        .WithMany()
                        .HasForeignKey("SacramentHymnID");

                    b.Navigation("Bishopric");

                    b.Navigation("ClosingHymn");

                    b.Navigation("Conducting");

                    b.Navigation("DismissalHymn");

                    b.Navigation("Hymn");

                    b.Navigation("MusicalNumber");

                    b.Navigation("OpeningHymn");

                    b.Navigation("Presiding");

                    b.Navigation("SacramentHymn");
                });

            modelBuilder.Entity("sacramentMeetingPlanner.Models.Speaker", b =>
                {
                    b.HasOne("sacramentMeetingPlanner.Models.SacramentMeeting", "SacramentMeeting")
                        .WithMany()
                        .HasForeignKey("SacramentMeetingID");

                    b.Navigation("SacramentMeeting");
                });
#pragma warning restore 612, 618
        }
    }
}
