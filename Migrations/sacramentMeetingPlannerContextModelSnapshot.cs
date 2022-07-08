﻿// <auto-generated />
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

                    b.Property<int>("BishopricID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClosingHymn")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Conducting")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("DismissalHymn")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HymnID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Invocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("OpeningHymn")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Presiding")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SacramentHymn")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SpeakerID")
                        .HasColumnType("INTEGER");

                    b.HasKey("SacramentMeetingID");

                    b.HasIndex("BishopricID");

                    b.HasIndex("HymnID");

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

                    b.Property<int>("SacramentMeetingID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SacramentMeetingID1")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubjectType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SpeakerID");

                    b.HasIndex("SacramentMeetingID1");

                    b.ToTable("Speaker", (string)null);
                });

            modelBuilder.Entity("sacramentMeetingPlanner.Models.SacramentMeeting", b =>
                {
                    b.HasOne("sacramentMeetingPlanner.Models.Bishopric", "Bishopric")
                        .WithMany()
                        .HasForeignKey("BishopricID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("sacramentMeetingPlanner.Models.Hymn", "Hymn")
                        .WithMany()
                        .HasForeignKey("HymnID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bishopric");

                    b.Navigation("Hymn");
                });

            modelBuilder.Entity("sacramentMeetingPlanner.Models.Speaker", b =>
                {
                    b.HasOne("sacramentMeetingPlanner.Models.SacramentMeeting", "SacramentMeeting")
                        .WithMany()
                        .HasForeignKey("SacramentMeetingID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SacramentMeeting");
                });
#pragma warning restore 612, 618
        }
    }
}