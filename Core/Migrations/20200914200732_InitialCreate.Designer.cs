﻿// <auto-generated />
using Core.SqlHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Core.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20200914200732_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Core.Objects.Note", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Key");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("Core.Objects.NoteTag", b =>
                {
                    b.Property<int>("NoteKey")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagKey")
                        .HasColumnType("INTEGER");

                    b.HasKey("NoteKey", "TagKey");

                    b.HasIndex("TagKey");

                    b.ToTable("NoteTag");
                });

            modelBuilder.Entity("Core.Objects.Tag", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Key");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Core.Objects.NoteTag", b =>
                {
                    b.HasOne("Core.Objects.Note", "Note")
                        .WithMany("NoteTags")
                        .HasForeignKey("NoteKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Objects.Tag", "Tag")
                        .WithMany("NoteTags")
                        .HasForeignKey("TagKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
