﻿// <auto-generated />
using System;
using Madera.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Madera.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201128172927_ajoutQuantite")]
    partial class ajoutQuantite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Madera.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AdresseClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CpClient")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateArchivage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateNaissanceClient")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUtilisateurCreation")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurModification")
                        .HasColumnType("int");

                    b.Property<string>("NomClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrenomClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.Property<string>("VilleClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Madera.Models.Commercial", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("DateArchivage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailCommercial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUtilisateurCreation")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurModification")
                        .HasColumnType("int");

                    b.Property<string>("MdpCommercial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomCommercial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrenomCommercial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Commercial");
                });

            modelBuilder.Entity("Madera.Models.Composant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CaractComposant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateArchivage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<int>("FamilleComposantID")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurCreation")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurModification")
                        .HasColumnType("int");

                    b.Property<string>("LibelleComposant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NatureComposant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UniteUsageComposant")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FamilleComposantID");

                    b.ToTable("Composant");
                });

            modelBuilder.Entity("Madera.Models.CoupePrincipale", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("LargeurCoupePrincipale")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("LibelleCoupePrincipale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("LongueurCoupePrincipale")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("ID");

                    b.ToTable("CoupePrincipale");
                });

            modelBuilder.Entity("Madera.Models.Couverture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("PrixHtCouverture")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("TypeCouverture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Couverture");
                });

            modelBuilder.Entity("Madera.Models.Devis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateArchivage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDebutDevis")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<string>("EtatDevis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUtilisateurCreation")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurModification")
                        .HasColumnType("int");

                    b.Property<string>("LibelleDevis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MargeCommercialDevis")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("MargeEntrepriseDevis")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("PlanID")
                        .HasColumnType("int");

                    b.Property<decimal>("PrixTotalHtDevis")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("PrixTotalTtcDevis")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("ID");

                    b.HasIndex("PlanID");

                    b.ToTable("Devis");
                });

            modelBuilder.Entity("Madera.Models.FamilleComposant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LibelleFamilleComposant")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("FamilleComposant");
                });

            modelBuilder.Entity("Madera.Models.Gamme", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LibelleGamme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("QualiteHuisserieGamme")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("TypeGamme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeIsolantGamme")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Gamme");
                });

            modelBuilder.Entity("Madera.Models.Modele", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LibelleModele")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Modele");
                });

            modelBuilder.Entity("Madera.Models.Module", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("DateArchivage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DdebutPointY")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("DebutPointX")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("FinPointX")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal>("FinPointY")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("IdUtilisateurCreation")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurModification")
                        .HasColumnType("int");

                    b.Property<string>("LibelleModule")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("Madera.Models.ModuleComposant", b =>
                {
                    b.Property<int>("ModuleID")
                        .HasColumnType("int");

                    b.Property<int>("ComposantID")
                        .HasColumnType("int");

                    b.Property<decimal>("PrixHt")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("PrixTotal")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("PrixTtc")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.HasKey("ModuleID", "ComposantID");

                    b.HasIndex("ComposantID");

                    b.ToTable("ModuleComposants");
                });

            modelBuilder.Entity("Madera.Models.ModuleGamme", b =>
                {
                    b.Property<int>("ModuleID")
                        .HasColumnType("int");

                    b.Property<int>("GammeID")
                        .HasColumnType("int");

                    b.HasKey("ModuleID", "GammeID");

                    b.HasIndex("GammeID");

                    b.ToTable("ModuleGammes");
                });

            modelBuilder.Entity("Madera.Models.ModuleModele", b =>
                {
                    b.Property<int>("ModuleID")
                        .HasColumnType("int");

                    b.Property<int>("ModeleID")
                        .HasColumnType("int");

                    b.Property<int>("quantite")
                        .HasColumnType("int");

                    b.HasKey("ModuleID", "ModeleID");

                    b.HasIndex("ModeleID");

                    b.ToTable("ModuleModeles");
                });

            modelBuilder.Entity("Madera.Models.ModulePlan", b =>
                {
                    b.Property<int>("ModuleID")
                        .HasColumnType("int");

                    b.Property<int>("PlanID")
                        .HasColumnType("int");

                    b.Property<int>("quantite")
                        .HasColumnType("int");

                    b.HasKey("ModuleID", "PlanID");

                    b.HasIndex("PlanID");

                    b.ToTable("ModulePlans");
                });

            modelBuilder.Entity("Madera.Models.ModuleSlot", b =>
                {
                    b.Property<int>("ModuleID")
                        .HasColumnType("int");

                    b.Property<int>("SlotID")
                        .HasColumnType("int");

                    b.HasKey("ModuleID", "SlotID");

                    b.HasIndex("SlotID");

                    b.ToTable("ModuleSlots");
                });

            modelBuilder.Entity("Madera.Models.Plan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AdressPlan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CoupePrincipaleID")
                        .HasColumnType("int");

                    b.Property<int>("CouvertureID")
                        .HasColumnType("int");

                    b.Property<int>("CpPlan")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateArchivage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUtilisateurCreation")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurModification")
                        .HasColumnType("int");

                    b.Property<int>("PlancherID")
                        .HasColumnType("int");

                    b.Property<string>("ReferencePlan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VillePlan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("libellePlan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CoupePrincipaleID");

                    b.HasIndex("CouvertureID");

                    b.HasIndex("PlancherID");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("Madera.Models.Plancher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("PrixPlancher")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("TypePlancher")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Plancher");
                });

            modelBuilder.Entity("Madera.Models.Projet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("CommercialID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateArchivage")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDebutProjet")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdUtilisateurCreation")
                        .HasColumnType("int");

                    b.Property<int>("IdUtilisateurModification")
                        .HasColumnType("int");

                    b.Property<string>("LibelleNom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibelleProjet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibelleRemarque")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("CommercialID");

                    b.ToTable("Projet");
                });

            modelBuilder.Entity("Madera.Models.ProjetPlan", b =>
                {
                    b.Property<int>("ProjetID")
                        .HasColumnType("int");

                    b.Property<int>("PlanID")
                        .HasColumnType("int");

                    b.HasKey("ProjetID", "PlanID");

                    b.HasIndex("PlanID");

                    b.ToTable("ProjetPlans");
                });

            modelBuilder.Entity("Madera.Models.Slot", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LibelleSlot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Slot");
                });

            modelBuilder.Entity("Madera.Models.Composant", b =>
                {
                    b.HasOne("Madera.Models.FamilleComposant", "FamilleComposant")
                        .WithMany("Composants")
                        .HasForeignKey("FamilleComposantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FamilleComposant");
                });

            modelBuilder.Entity("Madera.Models.Devis", b =>
                {
                    b.HasOne("Madera.Models.Plan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plan");
                });

            modelBuilder.Entity("Madera.Models.ModuleComposant", b =>
                {
                    b.HasOne("Madera.Models.Composant", "Composant")
                        .WithMany("ModuleComposant")
                        .HasForeignKey("ComposantID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Madera.Models.Module", "Module")
                        .WithMany("ModuleComposant")
                        .HasForeignKey("ModuleID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Composant");

                    b.Navigation("Module");
                });

            modelBuilder.Entity("Madera.Models.ModuleGamme", b =>
                {
                    b.HasOne("Madera.Models.Gamme", "Gamme")
                        .WithMany("ModuleGamme")
                        .HasForeignKey("GammeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Madera.Models.Module", "Module")
                        .WithMany("ModuleGamme")
                        .HasForeignKey("ModuleID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Gamme");

                    b.Navigation("Module");
                });

            modelBuilder.Entity("Madera.Models.ModuleModele", b =>
                {
                    b.HasOne("Madera.Models.Modele", "Modele")
                        .WithMany("ModuleModeles")
                        .HasForeignKey("ModeleID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Madera.Models.Module", "Module")
                        .WithMany("ModuleModeles")
                        .HasForeignKey("ModuleID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Modele");

                    b.Navigation("Module");
                });

            modelBuilder.Entity("Madera.Models.ModulePlan", b =>
                {
                    b.HasOne("Madera.Models.Module", "Module")
                        .WithMany("ModulePlan")
                        .HasForeignKey("ModuleID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Madera.Models.Plan", "Plan")
                        .WithMany("ModulePlan")
                        .HasForeignKey("PlanID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Module");

                    b.Navigation("Plan");
                });

            modelBuilder.Entity("Madera.Models.ModuleSlot", b =>
                {
                    b.HasOne("Madera.Models.Module", "Module")
                        .WithMany("ModuleSlots")
                        .HasForeignKey("ModuleID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Madera.Models.Slot", "Slot")
                        .WithMany("ModuleSlots")
                        .HasForeignKey("SlotID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Module");

                    b.Navigation("Slot");
                });

            modelBuilder.Entity("Madera.Models.Plan", b =>
                {
                    b.HasOne("Madera.Models.CoupePrincipale", "coupePrincipales")
                        .WithMany("plan")
                        .HasForeignKey("CoupePrincipaleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Madera.Models.Couverture", "couverture")
                        .WithMany("plans")
                        .HasForeignKey("CouvertureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Madera.Models.Plancher", "plancher")
                        .WithMany()
                        .HasForeignKey("PlancherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("coupePrincipales");

                    b.Navigation("couverture");

                    b.Navigation("plancher");
                });

            modelBuilder.Entity("Madera.Models.Projet", b =>
                {
                    b.HasOne("Madera.Models.Client", "client")
                        .WithMany("Projets")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Madera.Models.Commercial", "commercial")
                        .WithMany("Projets")
                        .HasForeignKey("CommercialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("client");

                    b.Navigation("commercial");
                });

            modelBuilder.Entity("Madera.Models.ProjetPlan", b =>
                {
                    b.HasOne("Madera.Models.Plan", "Plan")
                        .WithMany("ProjetPlans")
                        .HasForeignKey("PlanID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Madera.Models.Projet", "Projet")
                        .WithMany("ProjetPlans")
                        .HasForeignKey("ProjetID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Plan");

                    b.Navigation("Projet");
                });

            modelBuilder.Entity("Madera.Models.Client", b =>
                {
                    b.Navigation("Projets");
                });

            modelBuilder.Entity("Madera.Models.Commercial", b =>
                {
                    b.Navigation("Projets");
                });

            modelBuilder.Entity("Madera.Models.Composant", b =>
                {
                    b.Navigation("ModuleComposant");
                });

            modelBuilder.Entity("Madera.Models.CoupePrincipale", b =>
                {
                    b.Navigation("plan");
                });

            modelBuilder.Entity("Madera.Models.Couverture", b =>
                {
                    b.Navigation("plans");
                });

            modelBuilder.Entity("Madera.Models.FamilleComposant", b =>
                {
                    b.Navigation("Composants");
                });

            modelBuilder.Entity("Madera.Models.Gamme", b =>
                {
                    b.Navigation("ModuleGamme");
                });

            modelBuilder.Entity("Madera.Models.Modele", b =>
                {
                    b.Navigation("ModuleModeles");
                });

            modelBuilder.Entity("Madera.Models.Module", b =>
                {
                    b.Navigation("ModuleComposant");

                    b.Navigation("ModuleGamme");

                    b.Navigation("ModuleModeles");

                    b.Navigation("ModulePlan");

                    b.Navigation("ModuleSlots");
                });

            modelBuilder.Entity("Madera.Models.Plan", b =>
                {
                    b.Navigation("ModulePlan");

                    b.Navigation("ProjetPlans");
                });

            modelBuilder.Entity("Madera.Models.Projet", b =>
                {
                    b.Navigation("ProjetPlans");
                });

            modelBuilder.Entity("Madera.Models.Slot", b =>
                {
                    b.Navigation("ModuleSlots");
                });
#pragma warning restore 612, 618
        }
    }
}
