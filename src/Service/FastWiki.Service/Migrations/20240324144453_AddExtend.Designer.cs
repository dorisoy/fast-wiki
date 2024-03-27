﻿// <auto-generated />
using System;
using FastWiki.Service.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FastWiki.Service.Migrations
{
    [DbContext(typeof(WikiDbContext))]
    [Migration("20240324144453_AddExtend")]
    partial class AddExtend
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FastWiki.Service.Domain.ChatApplications.Aggregates.ChatApplication", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ChatModel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ChatType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("Creator")
                        .HasColumnType("uuid");

                    b.Property<string>("Extend")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("MaxResponseToken")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("Modifier")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NoReplyFoundTemplate")
                        .HasColumnType("text");

                    b.Property<string>("Opener")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Parameter")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Prompt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ReferenceUpperLimit")
                        .HasColumnType("integer");

                    b.Property<double>("Relevancy")
                        .HasColumnType("double precision");

                    b.Property<bool>("ShowSourceFile")
                        .HasColumnType("boolean");

                    b.Property<double>("Temperature")
                        .HasColumnType("double precision");

                    b.Property<string>("Template")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WikiIds")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("wiki-chat-application", (string)null);
                });

            modelBuilder.Entity("FastWiki.Service.Domain.ChatApplications.Aggregates.ChatDialog", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ApplicationId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ChatId")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Creator")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Modifier")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("wiki-chat-dialog", (string)null);
                });

            modelBuilder.Entity("FastWiki.Service.Domain.ChatApplications.Aggregates.ChatDialogHistory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ChatDialogId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(-1)
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Creator")
                        .HasColumnType("uuid");

                    b.Property<bool>("Current")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Modifier")
                        .HasColumnType("uuid");

                    b.Property<string>("ReferenceFile")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TokenConsumption")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ChatDialogId");

                    b.HasIndex("Creator");

                    b.ToTable("wiki-chat-dialog-history", (string)null);
                });

            modelBuilder.Entity("FastWiki.Service.Domain.ChatApplications.Aggregates.ChatShare", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("APIKey")
                        .HasColumnType("text");

                    b.Property<int>("AvailableQuantity")
                        .HasColumnType("integer");

                    b.Property<long>("AvailableToken")
                        .HasColumnType("bigint");

                    b.Property<string>("ChatApplicationId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Creator")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("Expires")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("Modifier")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("UsedToken")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ChatApplicationId");

                    b.ToTable("wiki-chat-share", (string)null);
                });

            modelBuilder.Entity("FastWiki.Service.Domain.Model.Aggregates.FastModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ApiKey")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("Creator")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<bool>("Enable")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Models")
                        .IsRequired()
                        .HasMaxLength(-1)
                        .HasColumnType("text");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("Modifier")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<long?>("TestTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Url")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<long>("UsedQuota")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.HasIndex("Type");

                    b.ToTable("wiki-fast-models", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "adf1fe462e7a4f7a93ee6951ca31d63c",
                            ApiKey = "",
                            CreationTime = new DateTime(2024, 3, 24, 14, 44, 52, 662, DateTimeKind.Utc).AddTicks(7163),
                            Description = "OpenAI",
                            Enable = true,
                            IsDeleted = false,
                            Models = "[\"gpt-3.5-turbo\",\"gpt-3.5-turbo-0125\",\"gpt-3.5-turbo-1106\",\"gpt-3.5-turbo-16k\",\"gpt-3.5-turbo-0613\",\"gpt-3.5-turbo-16k-0613\",\"gpt-4-0125-preview\",\"gpt-4-turbo-preview\",\"gpt-4-1106-preview\",\"gpt-4-vision-preview\",\"gpt-4-1106-vision-preview\",\"gpt-4\",\"gpt-4-0613\",\"gpt-4-32k\",\"gpt-4-32k-0613\"]",
                            ModificationTime = new DateTime(2024, 3, 24, 14, 44, 52, 662, DateTimeKind.Utc).AddTicks(7165),
                            Name = "OpenAI",
                            Order = 1,
                            Type = "OpenAI",
                            Url = "https://api.openai.com/",
                            UsedQuota = 0L
                        },
                        new
                        {
                            Id = "e124eb014a944dd79f3e4823461086d2",
                            ApiKey = "",
                            CreationTime = new DateTime(2024, 3, 24, 14, 44, 52, 662, DateTimeKind.Utc).AddTicks(7196),
                            Description = "星火大模型",
                            Enable = true,
                            IsDeleted = false,
                            Models = "[\"SparkDesk-v3.5\",\"SparkDesk-v3.1\",\"SparkDesk-v1.5\",\"SparkDesk-v2.1\"]",
                            ModificationTime = new DateTime(2024, 3, 24, 14, 44, 52, 662, DateTimeKind.Utc).AddTicks(7197),
                            Name = "SparkDesk",
                            Order = 1,
                            Type = "SparkDesk",
                            Url = "",
                            UsedQuota = 0L
                        });
                });

            modelBuilder.Entity("FastWiki.Service.Domain.Model.Aggregates.ModelLogger", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("ApiKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ApplicationId")
                        .HasColumnType("text");

                    b.Property<int>("ComplementCount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FastModelId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PromptCount")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ApiKey");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("CreationTime");

                    b.HasIndex("FastModelId");

                    b.HasIndex("Type");

                    b.HasIndex("UserId");

                    b.ToTable("wiki-model-logger", (string)null);
                });

            modelBuilder.Entity("FastWiki.Service.Domain.Storage.Aggregates.FileStorage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("Creator")
                        .HasColumnType("uuid");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsCompression")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("Modifier")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("wiki-file-storages", (string)null);
                });

            modelBuilder.Entity("FastWiki.Service.Domain.Users.Aggregates.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("Creator")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDisable")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("Modifier")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("wiki-users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("f0b2b97a-1f5f-4741-8110-7dc382b52025"),
                            Account = "admin",
                            Avatar = "https://blog-simple.oss-cn-shenzhen.aliyuncs.com/Avatar.jpg",
                            CreationTime = new DateTime(2024, 3, 24, 14, 44, 52, 662, DateTimeKind.Utc).AddTicks(5388),
                            Email = "239573049@qq.com",
                            IsDeleted = false,
                            IsDisable = false,
                            ModificationTime = new DateTime(2024, 3, 24, 14, 44, 52, 662, DateTimeKind.Utc).AddTicks(5390),
                            Name = "admin",
                            Password = "2a2e3a0f18f38c8ba99bee8e499ed572",
                            Phone = "13049809673",
                            Role = 2,
                            Salt = "124dc3dc26674fad9ea6adea9eb231b6"
                        });
                });

            modelBuilder.Entity("FastWiki.Service.Domain.Wikis.Aggregates.Wiki", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("Creator")
                        .HasColumnType("uuid");

                    b.Property<string>("EmbeddingModel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("Modifier")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("wiki-wikis", (string)null);
                });

            modelBuilder.Entity("FastWiki.Service.Domain.Wikis.Aggregates.WikiDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("Creator")
                        .HasColumnType("bigint");

                    b.Property<int>("DataCount")
                        .HasColumnType("integer");

                    b.Property<long>("FileId")
                        .HasColumnType("bigint");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("ModificationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("Modifier")
                        .HasColumnType("bigint");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<long>("WikiId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("wiki-wiki-details", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
