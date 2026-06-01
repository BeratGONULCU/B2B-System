using System;
using System.Collections.Generic;
using AvmB2B.Api.Entities;
using Microsoft.EntityFrameworkCore;
using AvmB2B.Api.Models;

namespace AvmB2B.Api.Data;

public partial class PetrolDbContext : DbContext
{
    public PetrolDbContext(DbContextOptions<PetrolDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<B2BUser> B2BUsers { get; set; }
    public DbSet<CariKartListesiOzet> CariKartListesiOzetleri => Set<CariKartListesiOzet>();

    public DbSet<B2BPayment> B2BPayments { get; set; }
    public DbSet<B2BPaymentLog> B2BPaymentLogs { get; set; }

    public DbSet<B2BPosAccount> B2BPosAccounts { get; set; }
    public DbSet<B2BPosInstallmentRule> B2BPosInstallmentRules { get; set; }
    public DbSet<B2BCariLock> B2BCariLocks { get; set; }
    public DbSet<B2BInstallmentAllowedBin> B2BInstallmentAllowedBins { get; set; }

    public virtual DbSet<AnaMenuHrk> AnaMenuHrks { get; set; }

    public virtual DbSet<AnaMenuMa> AnaMenuMas { get; set; }

    public virtual DbSet<AppIrsaliyeHrk> AppIrsaliyeHrks { get; set; }

    public virtual DbSet<AppIrsaliyeMa> AppIrsaliyeMas { get; set; }

    public virtual DbSet<AppRafEitketHrk> AppRafEitketHrks { get; set; }

    public virtual DbSet<AppRafEtiketMa> AppRafEtiketMas { get; set; }

    public virtual DbSet<AppSayim> AppSayims { get; set; }

    public virtual DbSet<BakiyeBanka> BakiyeBankas { get; set; }

    public virtual DbSet<BakiyeCari> BakiyeCaris { get; set; }

    public virtual DbSet<BakiyeFisCariGenelAy> BakiyeFisCariGenelAys { get; set; }

    public virtual DbSet<BakiyeFisCariTopAy> BakiyeFisCariTopAys { get; set; }

    public virtual DbSet<BakiyeGelGid> BakiyeGelGids { get; set; }

    public virtual DbSet<BakiyeIstkredi> BakiyeIstkredis { get; set; }

    public virtual DbSet<BakiyeKasa> BakiyeKasas { get; set; }

    public virtual DbSet<BakiyePerakende> BakiyePerakendes { get; set; }

    public virtual DbSet<BakiyePersonel> BakiyePersonels { get; set; }

    public virtual DbSet<BakiyePo> BakiyePos { get; set; }

    public virtual DbSet<BakiyePromPuan> BakiyePromPuans { get; set; }

    public virtual DbSet<BakiyePromUrunMiktar> BakiyePromUrunMiktars { get; set; }

    public virtual DbSet<BakiyeRehber> BakiyeRehbers { get; set; }

    public virtual DbSet<BakiyeStokMiktar> BakiyeStokMiktars { get; set; }

    public virtual DbSet<BakiyeStokMiktar1> BakiyeStokMiktars1 { get; set; }

    public virtual DbSet<BakiyeStokMiktarFirmaDep> BakiyeStokMiktarFirmaDeps { get; set; }

    public virtual DbSet<BakiyeTank> BakiyeTanks { get; set; }

    public virtual DbSet<BankaKartListesi> BankaKartListesis { get; set; }

    public virtual DbSet<Bankahrk> Bankahrks { get; set; }

    public virtual DbSet<Bankakart> Bankakarts { get; set; }

    public virtual DbSet<BanknotHrk> BanknotHrks { get; set; }

    public virtual DbSet<BanknotTip> BanknotTips { get; set; }

    public virtual DbSet<Barkod> Barkods { get; set; }

    public virtual DbSet<BarkodBedelsiz> BarkodBedelsizs { get; set; }

    public virtual DbSet<Bolum> Bolums { get; set; }

    public virtual DbSet<BulutTahsilat> BulutTahsilats { get; set; }

    public virtual DbSet<CariAracSayi> CariAracSayis { get; set; }

    public virtual DbSet<CariAvansBakiye> CariAvansBakiyes { get; set; }

    public virtual DbSet<CariCalismaSart> CariCalismaSarts { get; set; }

    public virtual DbSet<CariCalismaUrunIskonto> CariCalismaUrunIskontos { get; set; }

    public virtual DbSet<CariCekBakiye> CariCekBakiyes { get; set; }

    public virtual DbSet<CariCiroBakiye> CariCiroBakiyes { get; set; }

    public virtual DbSet<CariFatUrunIskonto> CariFatUrunIskontos { get; set; }

    public virtual DbSet<CariFisBakiye> CariFisBakiyes { get; set; }

    public virtual DbSet<CariFisBakiyeAy> CariFisBakiyeAys { get; set; }

    public virtual DbSet<CariFisBakiyeKap> CariFisBakiyeKaps { get; set; }

    public virtual DbSet<CariHrkBakiye> CariHrkBakiyes { get; set; }

    public virtual DbSet<CariHrkBakiyeAy> CariHrkBakiyeAys { get; set; }

    public virtual DbSet<CariIrsaliyeBakiye> CariIrsaliyeBakiyes { get; set; }

    public virtual DbSet<CariKartListesi> CariKartListesis { get; set; }

    public virtual DbSet<CariOtoFisVadeFarkTutar> CariOtoFisVadeFarkTutars { get; set; }

    public virtual DbSet<CariSonAlcHrk> CariSonAlcHrks { get; set; }

    public virtual DbSet<CariSonBrcHrk> CariSonBrcHrks { get; set; }

    public virtual DbSet<CariSonFi> CariSonFis { get; set; }

    public virtual DbSet<CariSurucu> CariSurucus { get; set; }

    public virtual DbSet<CariTeminat> CariTeminats { get; set; }

    public virtual DbSet<CariTeminatIlk> CariTeminatIlks { get; set; }

    public virtual DbSet<CariTip> CariTips { get; set; }

    public virtual DbSet<CariTur> CariTurs { get; set; }

    public virtual DbSet<CariVadefarkListe> CariVadefarkListes { get; set; }

    public virtual DbSet<Carihrk> Carihrks { get; set; }

    public virtual DbSet<Carikart> Carikarts { get; set; }

    public virtual DbSet<Cariteminat1> Cariteminats { get; set; }

    public virtual DbSet<Cariteminattip> Cariteminattips { get; set; }

    public virtual DbSet<CekKarne> CekKarnes { get; set; }

    public virtual DbSet<Cekhrk> Cekhrks { get; set; }

    public virtual DbSet<Cekkart> Cekkarts { get; set; }

    public virtual DbSet<Cektip> Cektips { get; set; }

    public virtual DbSet<DagitimFirma> DagitimFirmas { get; set; }

    public virtual DbSet<DepoKartListesi> DepoKartListesis { get; set; }

    public virtual DbSet<Depokart> Depokarts { get; set; }

    public virtual DbSet<EbelgeEntegrator> EbelgeEntegrators { get; set; }

    public virtual DbSet<EbelgeSeri> EbelgeSeris { get; set; }

    public virtual DbSet<EbelgeTip> EbelgeTips { get; set; }

    public virtual DbSet<EfaturaBrm> EfaturaBrms { get; set; }

    public virtual DbSet<EfaturaGelen> EfaturaGelens { get; set; }

    public virtual DbSet<EfaturaGelenHrk> EfaturaGelenHrks { get; set; }

    public virtual DbSet<EfaturaTip> EfaturaTips { get; set; }

    public virtual DbSet<Emtiasat> Emtiasats { get; set; }

    public virtual DbSet<Entegre> Entegres { get; set; }

    public virtual DbSet<EntegreMuhHesKod> EntegreMuhHesKods { get; set; }

    public virtual DbSet<Epostaayar> Epostaayars { get; set; }

    public virtual DbSet<EvrakNot> EvrakNots { get; set; }

    public virtual DbSet<FatDep> FatDeps { get; set; }

    public virtual DbSet<FatGrsAlanTip> FatGrsAlanTips { get; set; }

    public virtual DbSet<Fattip> Fattips { get; set; }

    public virtual DbSet<FaturaIadeDetay> FaturaIadeDetays { get; set; }

    public virtual DbSet<FaturaTur> FaturaTurs { get; set; }

    public virtual DbSet<Faturagiderlistesi> Faturagiderlistesis { get; set; }

    public virtual DbSet<Faturahrk> Faturahrks { get; set; }

    public virtual DbSet<FaturahrkTemp> FaturahrkTemps { get; set; }

    public virtual DbSet<Faturahrklistesi> Faturahrklistesis { get; set; }

    public virtual DbSet<Faturama> Faturamas { get; set; }

    public virtual DbSet<FaturamasTemp> FaturamasTemps { get; set; }

    public virtual DbSet<FilitreHrk> FilitreHrks { get; set; }

    public virtual DbSet<FilitreMa> FilitreMas { get; set; }

    public virtual DbSet<Firma> Firmas { get; set; }

    public virtual DbSet<Fisfatodelistesi> Fisfatodelistesis { get; set; }

    public virtual DbSet<Fisma> Fismas { get; set; }

    public virtual DbSet<Fistahodelistesi> Fistahodelistesis { get; set; }

    public virtual DbSet<Frm> Frms { get; set; }

    public virtual DbSet<Frmkont> Frmkonts { get; set; }

    public virtual DbSet<GelGidKartListesi> GelGidKartListesis { get; set; }

    public virtual DbSet<Gelgidkart> Gelgidkarts { get; set; }

    public virtual DbSet<Gelgidlistok> Gelgidlistoks { get; set; }

    public virtual DbSet<GenelCariKart> GenelCariKarts { get; set; }

    public virtual DbSet<GenelKart> GenelKarts { get; set; }

    public virtual DbSet<GenelrapGoster> GenelrapGosters { get; set; }

    public virtual DbSet<GrafikRapGoster> GrafikRapGosters { get; set; }

    public virtual DbSet<Grup> Grups { get; set; }

    public virtual DbSet<GunlukrapGoster> GunlukrapGosters { get; set; }

    public virtual DbSet<HariciKart> HariciKarts { get; set; }

    public virtual DbSet<HrkGrupKriter> HrkGrupKriters { get; set; }

    public virtual DbSet<HrkKriter> HrkKriters { get; set; }

    public virtual DbSet<Il> Ils { get; set; }

    public virtual DbSet<Ilce> Ilces { get; set; }

    public virtual DbSet<Irsaliyehrk> Irsaliyehrks { get; set; }

    public virtual DbSet<Irsaliyehrklistesi> Irsaliyehrklistesis { get; set; }

    public virtual DbSet<Irsaliyema> Irsaliyemas { get; set; }

    public virtual DbSet<Islemhrktip> Islemhrktips { get; set; }

    public virtual DbSet<Islemturtip> Islemturtips { get; set; }

    public virtual DbSet<Istkart> Istkarts { get; set; }

    public virtual DbSet<Istkhrk> Istkhrks { get; set; }

    public virtual DbSet<IstkrediKartListesi> IstkrediKartListesis { get; set; }

    public virtual DbSet<Kartsumalan> Kartsumalans { get; set; }

    public virtual DbSet<Karttip> Karttips { get; set; }

    public virtual DbSet<KasaKapa> KasaKapas { get; set; }

    public virtual DbSet<KasaKapat> KasaKapats { get; set; }

    public virtual DbSet<KasaKartListesi> KasaKartListesis { get; set; }

    public virtual DbSet<Kasahrk> Kasahrks { get; set; }

    public virtual DbSet<Kasakart> Kasakarts { get; set; }

    public virtual DbSet<KdvOran> KdvOrans { get; set; }

    public virtual DbSet<KdvtevkifatTip> KdvtevkifatTips { get; set; }

    public virtual DbSet<Kriterkayit> Kriterkayits { get; set; }

    public virtual DbSet<Kurgr> Kurgrs { get; set; }

    public virtual DbSet<LogAlan> LogAlans { get; set; }

    public virtual DbSet<LogFatura> LogFaturas { get; set; }

    public virtual DbSet<LogFaturaHareket> LogFaturaHarekets { get; set; }

    public virtual DbSet<LogMarketSati> LogMarketSatis { get; set; }

    public virtual DbSet<LogMarketSatisHareket> LogMarketSatisHarekets { get; set; }

    public virtual DbSet<LogUrunFiyatHistory> LogUrunFiyatHistories { get; set; }

    public virtual DbSet<LogUrunHareket> LogUrunHarekets { get; set; }

    public virtual DbSet<LogoTransferLog> LogoTransferLogs { get; set; }

    public virtual DbSet<MailAck> MailAcks { get; set; }

    public virtual DbSet<MarSatRecHrk> MarSatRecHrks { get; set; }

    public virtual DbSet<Markasahrk> Markasahrks { get; set; }

    public virtual DbSet<Marsathrk> Marsathrks { get; set; }

    public virtual DbSet<Marsatma> Marsatmas { get; set; }

    public virtual DbSet<Marvardikap> Marvardikaps { get; set; }

    public virtual DbSet<Marvardima> Marvardimas { get; set; }

    public virtual DbSet<Marvardiozet> Marvardiozets { get; set; }

    public virtual DbSet<Marvardirapgoster> Marvardirapgosters { get; set; }

    public virtual DbSet<MerkezKartLog> MerkezKartLogs { get; set; }

    public virtual DbSet<Mesaj> Mesajs { get; set; }

    public virtual DbSet<MicroStokListesi> MicroStokListesis { get; set; }

    public virtual DbSet<MsgAck> MsgAcks { get; set; }

    public virtual DbSet<Numarator> Numarators { get; set; }

    public virtual DbSet<Okunanotodosya> Okunanotodosyas { get; set; }

    public virtual DbSet<OtoOnlParam> OtoOnlParams { get; set; }

    public virtual DbSet<OtomasSati> OtomasSatis { get; set; }

    public virtual DbSet<OtomasWebServisHrk> OtomasWebServisHrks { get; set; }

    public virtual DbSet<Otomasdosya> Otomasdosyas { get; set; }

    public virtual DbSet<Otomasgenkod> Otomasgenkods { get; set; }

    public virtual DbSet<Otomaskart> Otomaskarts { get; set; }

    public virtual DbSet<Otomaskarthrk> Otomaskarthrks { get; set; }

    public virtual DbSet<Otomasoku> Otomasokus { get; set; }

    public virtual DbSet<Otomasonlineoku> Otomasonlineokus { get; set; }

    public virtual DbSet<Otomaspumphrk> Otomaspumphrks { get; set; }

    public virtual DbSet<Otomaspumptan> Otomaspumptans { get; set; }

    public virtual DbSet<Otomastip> Otomastips { get; set; }

    public virtual DbSet<OzelFisTablo> OzelFisTablos { get; set; }

    public virtual DbSet<OzelKod> OzelKods { get; set; }

    public virtual DbSet<ParaKur> ParaKurs { get; set; }

    public virtual DbSet<Parabrm> Parabrms { get; set; }

    public virtual DbSet<Parametre> Parametres { get; set; }

    public virtual DbSet<PdaFaturaSayimHrk> PdaFaturaSayimHrks { get; set; }

    public virtual DbSet<PdaFaturaSayimMa> PdaFaturaSayimMas { get; set; }

    public virtual DbSet<PdaOffSayimHrk> PdaOffSayimHrks { get; set; }

    public virtual DbSet<PdaOffSayimMa> PdaOffSayimMas { get; set; }

    public virtual DbSet<PerCari> PerCaris { get; set; }

    public virtual DbSet<PerakendeKartListesi> PerakendeKartListesis { get; set; }

    public virtual DbSet<Perakendekart> Perakendekarts { get; set; }

    public virtual DbSet<Perkart> Perkarts { get; set; }

    public virtual DbSet<Permaashrk> Permaashrks { get; set; }

    public virtual DbSet<PersonelKartListesi> PersonelKartListesis { get; set; }

    public virtual DbSet<PersonelMaasListe> PersonelMaasListes { get; set; }

    public virtual DbSet<PlakaLimitCariMiktar> PlakaLimitCariMiktars { get; set; }

    public virtual DbSet<PlakaLimitMiktar> PlakaLimitMiktars { get; set; }

    public virtual DbSet<Pomvardikap> Pomvardikaps { get; set; }

    public virtual DbSet<Pomvardima> Pomvardimas { get; set; }

    public virtual DbSet<Pomvardiozet> Pomvardiozets { get; set; }

    public virtual DbSet<Pomvardiper> Pomvardipers { get; set; }

    public virtual DbSet<Pomvardiperadum> Pomvardiperada { get; set; }

    public virtual DbSet<Pomvardirapgoster> Pomvardirapgosters { get; set; }

    public virtual DbSet<Pomvardisayac> Pomvardisayacs { get; set; }

    public virtual DbSet<Pomvardistok> Pomvardistoks { get; set; }

    public virtual DbSet<Pomvarditank> Pomvarditanks { get; set; }

    public virtual DbSet<PosKartListesi> PosKartListesis { get; set; }

    public virtual DbSet<Poshrk> Poshrks { get; set; }

    public virtual DbSet<Poskart> Poskarts { get; set; }

    public virtual DbSet<PromDahilUrunList> PromDahilUrunLists { get; set; }

    public virtual DbSet<PromLimit> PromLimits { get; set; }

    public virtual DbSet<PromMusteriListesi> PromMusteriListesis { get; set; }

    public virtual DbSet<PromPuanHrk> PromPuanHrks { get; set; }

    public virtual DbSet<PromPuanHrkTip> PromPuanHrkTips { get; set; }

    public virtual DbSet<PromSatBaslik> PromSatBasliks { get; set; }

    public virtual DbSet<PromSatHrk> PromSatHrks { get; set; }

    public virtual DbSet<PromSatisListesi> PromSatisListesis { get; set; }

    public virtual DbSet<PromUrunKartList> PromUrunKartLists { get; set; }

    public virtual DbSet<PromUrunPuan> PromUrunPuans { get; set; }

    public virtual DbSet<PromUrunPuanTip> PromUrunPuanTips { get; set; }

    public virtual DbSet<PromUrunSatTip> PromUrunSatTips { get; set; }

    public virtual DbSet<PromaksMarketSatisLog> PromaksMarketSatisLogs { get; set; }

    public virtual DbSet<RaporDeger> RaporDegers { get; set; }

    public virtual DbSet<RaporGrupKriter> RaporGrupKriters { get; set; }

    public virtual DbSet<RaporHrkKriter> RaporHrkKriters { get; set; }

    public virtual DbSet<RaporList> RaporLists { get; set; }

    public virtual DbSet<RaporMa> RaporMas { get; set; }

    public virtual DbSet<Raporlar> Raporlars { get; set; }

    public virtual DbSet<Raptip> Raptips { get; set; }

    public virtual DbSet<RehberBarkod> RehberBarkods { get; set; }

    public virtual DbSet<RehberBarkodListesi> RehberBarkodListesis { get; set; }

    public virtual DbSet<RehberGrup> RehberGrups { get; set; }

    public virtual DbSet<RehberGrupDetay> RehberGrupDetays { get; set; }

    public virtual DbSet<RehberGrupDetayListesi> RehberGrupDetayListesis { get; set; }

    public virtual DbSet<RehberKart> RehberKarts { get; set; }

    public virtual DbSet<RehberKartListesi> RehberKartListesis { get; set; }

    public virtual DbSet<ResSatHrk> ResSatHrks { get; set; }

    public virtual DbSet<ResSatKasaHrk> ResSatKasaHrks { get; set; }

    public virtual DbSet<ResSatMa> ResSatMas { get; set; }

    public virtual DbSet<ResSatRecHrk> ResSatRecHrks { get; set; }

    public virtual DbSet<ResVardiKap> ResVardiKaps { get; set; }

    public virtual DbSet<ResVardiMa> ResVardiMas { get; set; }

    public virtual DbSet<ResVardiOzet> ResVardiOzets { get; set; }

    public virtual DbSet<ResVardiRapGoster> ResVardiRapGosters { get; set; }

    public virtual DbSet<RezSatHrk> RezSatHrks { get; set; }

    public virtual DbSet<SayacTanklistesi> SayacTanklistesis { get; set; }

    public virtual DbSet<Sayachrk> Sayachrks { get; set; }

    public virtual DbSet<Sayackart> Sayackarts { get; set; }

    public virtual DbSet<Sayimhrk> Sayimhrks { get; set; }

    public virtual DbSet<Sayimkap> Sayimkaps { get; set; }

    public virtual DbSet<Sayimma> Sayimmas { get; set; }

    public virtual DbSet<Sayimstkgrp> Sayimstkgrps { get; set; }

    public virtual DbSet<Siparishrk> Siparishrks { get; set; }

    public virtual DbSet<Siparisma> Siparismas { get; set; }

    public virtual DbSet<Sistemtanim> Sistemtanims { get; set; }

    public virtual DbSet<SmsGonderimLog> SmsGonderimLogs { get; set; }

    public virtual DbSet<SmsSablon> SmsSablons { get; set; }

    public virtual DbSet<SoforKart> SoforKarts { get; set; }

    public virtual DbSet<SonCarAlcHrk> SonCarAlcHrks { get; set; }

    public virtual DbSet<SonCarBrcHrk> SonCarBrcHrks { get; set; }

    public virtual DbSet<SonCekHrk> SonCekHrks { get; set; }

    public virtual DbSet<SonFisHrk> SonFisHrks { get; set; }

    public virtual DbSet<StkTip> StkTips { get; set; }

    public virtual DbSet<Stkbrm> Stkbrms { get; set; }

    public virtual DbSet<Stkdeptr> Stkdeptrs { get; set; }

    public virtual DbSet<Stkdeptrsma> Stkdeptrsmas { get; set; }

    public virtual DbSet<Stkdrm> Stkdrms { get; set; }

    public virtual DbSet<Stkhrk> Stkhrks { get; set; }

    public virtual DbSet<Stkhrktip> Stkhrktips { get; set; }

    public virtual DbSet<StokDepoDurum> StokDepoDurums { get; set; }

    public virtual DbSet<StokFirmaAlisFiyat> StokFirmaAlisFiyats { get; set; }

    public virtual DbSet<StokFirmaDepoDurum> StokFirmaDepoDurums { get; set; }

    public virtual DbSet<StokFirmaDurum> StokFirmaDurums { get; set; }

    public virtual DbSet<StokFirmaFiyatDurum> StokFirmaFiyatDurums { get; set; }

    public virtual DbSet<StokFirmaFiyatList> StokFirmaFiyatLists { get; set; }

    public virtual DbSet<StokFirmaMiktar> StokFirmaMiktars { get; set; }

    public virtual DbSet<StokFiyat> StokFiyats { get; set; }

    public virtual DbSet<StokFiyatLog> StokFiyatLogs { get; set; }

    public virtual DbSet<StokGenelListe> StokGenelListes { get; set; }

    public virtual DbSet<StokGenelListesi> StokGenelListesis { get; set; }

    public virtual DbSet<StokIadeMiktarListesi> StokIadeMiktarListesis { get; set; }

    public virtual DbSet<StokKartAkaryakitListesi> StokKartAkaryakitListesis { get; set; }

    public virtual DbSet<StokKartBirim> StokKartBirims { get; set; }

    public virtual DbSet<StokKartListesi> StokKartListesis { get; set; }

    public virtual DbSet<StokKartMarket> StokKartMarkets { get; set; }

    public virtual DbSet<StokKartMarketListesi> StokKartMarketListesis { get; set; }

    public virtual DbSet<StokMuhTanim> StokMuhTanims { get; set; }

    public virtual DbSet<StokRecete> StokRecetes { get; set; }

    public virtual DbSet<StokSonKullanim> StokSonKullanims { get; set; }

    public virtual DbSet<Stokfiyathistory> Stokfiyathistories { get; set; }

    public virtual DbSet<Stokkart> Stokkarts { get; set; }

    public virtual DbSet<Tablelog> Tablelogs { get; set; }

    public virtual DbSet<Tablo> Tablos { get; set; }

    public virtual DbSet<TabloAlan> TabloAlans { get; set; }

    public virtual DbSet<TahsilatOdeme> TahsilatOdemes { get; set; }

    public virtual DbSet<TaksitHrk> TaksitHrks { get; set; }

    public virtual DbSet<TankKartListesi> TankKartListesis { get; set; }

    public virtual DbSet<Tankkart> Tankkarts { get; set; }

    public virtual DbSet<TarihKapat> TarihKapats { get; set; }

    public virtual DbSet<TasiyiciFirmaKart> TasiyiciFirmaKarts { get; set; }

    public virtual DbSet<Tatiller> Tatillers { get; set; }

    public virtual DbSet<Tesi> Teses { get; set; }

    public virtual DbSet<TeslimYerKart> TeslimYerKarts { get; set; }

    public virtual DbSet<TopluKayit> TopluKayits { get; set; }

    public virtual DbSet<TopluKayitHrk> TopluKayitHrks { get; set; }

    public virtual DbSet<TopluVirmanKayit> TopluVirmanKayits { get; set; }

    public virtual DbSet<TopluVirmanKayitHrk> TopluVirmanKayitHrks { get; set; }

    public virtual DbSet<TtsBankaTahsilat> TtsBankaTahsilats { get; set; }

    public virtual DbSet<TtsOdeTip> TtsOdeTips { get; set; }

    public virtual DbSet<UlkeList> UlkeLists { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Userformgrup> Userformgrups { get; set; }

    public virtual DbSet<Userformhak> Userformhaks { get; set; }

    public virtual DbSet<Userformhrk> Userformhrks { get; set; }

    public virtual DbSet<Userformlar> Userformlars { get; set; }

    public virtual DbSet<Userlog> Userlogs { get; set; }

    public virtual DbSet<Usrgrid> Usrgrids { get; set; }

    public virtual DbSet<Usrsplit> Usrsplits { get; set; }

    public virtual DbSet<VMarketSatisUrunIdReceteMaliyet> VMarketSatisUrunIdReceteMaliyets { get; set; }

    public virtual DbSet<VResGrup> VResGrups { get; set; }

    public virtual DbSet<VResSatHrk> VResSatHrks { get; set; }

    public virtual DbSet<VResSatMa> VResSatMas { get; set; }

    public virtual DbSet<VResSatisUrunIdReceteMaliyet> VResSatisUrunIdReceteMaliyets { get; set; }

    public virtual DbSet<VResStok01> VResStok01s { get; set; }

    public virtual DbSet<VStokFirmaSubeFiyat> VStokFirmaSubeFiyats { get; set; }

    public virtual DbSet<VStokSonKullanimList> VStokSonKullanimLists { get; set; }

    public virtual DbSet<Vardikasa> Vardikasas { get; set; }

    public virtual DbSet<VardiyaCekKartlar> VardiyaCekKartlars { get; set; }

    public virtual DbSet<VardiyaKasaKartlar> VardiyaKasaKartlars { get; set; }

    public virtual DbSet<VeresiVadeFarkHrk> VeresiVadeFarkHrks { get; set; }

    public virtual DbSet<Veresifarkhrk> Veresifarkhrks { get; set; }

    public virtual DbSet<Veresihrk> Veresihrks { get; set; }

    public virtual DbSet<Veresima> Veresimas { get; set; }

    public virtual DbSet<Veresiyenfiyhrk> Veresiyenfiyhrks { get; set; }

    public virtual DbSet<ViewCariHrkFisIskListesi> ViewCariHrkFisIskListesis { get; set; }

    public virtual DbSet<ViewCariHrkFisListesi> ViewCariHrkFisListesis { get; set; }

    public virtual DbSet<ViewCarilerKartBakiye> ViewCarilerKartBakiyes { get; set; }

    public virtual DbSet<ViewGrp1> ViewGrp1s { get; set; }

    public virtual DbSet<ViewGrp2> ViewGrp2s { get; set; }

    public virtual DbSet<ViewGrp3> ViewGrp3s { get; set; }

    public virtual DbSet<ViewHrklistesi> ViewHrklistesis { get; set; }

    public virtual DbSet<YazarKasaSati> YazarKasaSatis { get; set; }

    public virtual DbSet<Yazarkasa> Yazarkasas { get; set; }

    public virtual DbSet<Yazarkasakart> Yazarkasakarts { get; set; }

    public virtual DbSet<Yazkasagrpkart> Yazkasagrpkarts { get; set; }

    public virtual DbSet<Yedek> Yedeks { get; set; }

    public virtual DbSet<Yertipad> Yertipads { get; set; }

    public virtual DbSet<Yetki> Yetkis { get; set; }

    public virtual DbSet<Yetkibolum> Yetkibolums { get; set; }

    public virtual DbSet<Yetkifrm> Yetkifrms { get; set; }

    public virtual DbSet<Yetkikont> Yetkikonts { get; set; }

    public virtual DbSet<ZraporUrunKartListesi> ZraporUrunKartListesis { get; set; }

    public virtual DbSet<ZraporVardiya> ZraporVardiyas { get; set; }

    public virtual DbSet<Zraporhrk> Zraporhrks { get; set; }

    public virtual DbSet<Zraporma> Zrapormas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<B2BPayment>(entity =>
        {
            entity.ToTable("B2B_Payments");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18,2)");

            entity.Property(e => e.PaymentNo)
                .HasMaxLength(50);

            entity.Property(e => e.CariKod)
                .HasMaxLength(50);

            entity.Property(e => e.Currency)
                .HasMaxLength(10);

            entity.Property(e => e.Status)
                .HasMaxLength(50);

            entity.Property(e => e.BankCode)
                .HasMaxLength(50);

            entity.Property(e => e.OrderNumber)
                .HasMaxLength(100);
        });

        modelBuilder.Entity<CariKartListesiOzet>(entity =>
        {
            entity.HasNoKey();
            entity.ToView("cari_kart_listesi", "dbo");
        });

        modelBuilder.Entity<B2BPaymentLog>(entity =>
        {
            entity.ToTable("B2B_PaymentLogs");

            entity.HasKey(e => e.Id);
        });

        modelBuilder.Entity<B2BPosAccount>(entity =>
        {
            entity.ToTable("B2B_PosAccounts");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.BankCode)
                .HasMaxLength(50);

            entity.Property(e => e.BankName)
                .HasMaxLength(100);

            entity.Property(e => e.MerchantId)
                .HasMaxLength(250);

            entity.Property(e => e.MerchantUser)
                .HasMaxLength(250);
        });

        modelBuilder.Entity<B2BPosInstallmentRule>(entity =>
        {
            entity.ToTable("B2B_PosInstallmentRules");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.MinAmount)
                .HasColumnType("decimal(18,2)");

            entity.Property(e => e.MaxAmount)
                .HasColumnType("decimal(18,2)");

            entity.Property(e => e.CommissionRate)
                .HasColumnType("decimal(9,4)");
        });
        modelBuilder.Entity<B2BUser>(entity =>
        {
            entity.ToTable("B2B_Users");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.UserType)
                .HasMaxLength(20)
                .IsRequired();

            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsRequired();

            entity.Property(e => e.PasswordHash)
                .HasMaxLength(500)
                .IsRequired();

            entity.Property(e => e.CariKod)
                .HasMaxLength(50);

            entity.Property(e => e.IsActive)
                .HasDefaultValue(true);

            entity.Property(e => e.MustChangePassword)
                .HasDefaultValue(false);

            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasDefaultValueSql("GETDATE()");
        });

        modelBuilder.Entity<B2BPayment>(entity =>
        {
            entity.ToTable("B2B_Payments");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.PaymentNo)
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(e => e.CariKod)
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18,2)");

            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .IsRequired();

            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .IsRequired();

            entity.Property(e => e.BankCode)
                .HasMaxLength(50);

            entity.Property(e => e.OrderNumber)
                .HasMaxLength(100)
                .IsRequired();

            entity.Property(e => e.BankTransactionId)
                .HasMaxLength(200);

            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(1000);

            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasDefaultValueSql("GETDATE()");

            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<B2BPaymentLog>(entity =>
        {
            entity.ToTable("B2B_PaymentLogs");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Direction)
                .HasMaxLength(30)
                .IsRequired();

            entity.Property(e => e.RawData);

            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasDefaultValueSql("GETDATE()");
        });

        modelBuilder.Entity<B2BCariLock>(entity =>
        {
            entity.ToTable("B2B_CariLocks");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.CariKod)
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(e => e.IsLocked)
                .HasDefaultValue(true);

            entity.Property(e => e.Reason)
                .HasMaxLength(500);

            entity.Property(e => e.LockedAt)
                .HasColumnType("datetime")
                .HasDefaultValueSql("GETDATE()");

            entity.Property(e => e.UnlockedAt)
                .HasColumnType("datetime");

            entity.HasIndex(e => e.CariKod)
                .IsUnique()
                .HasDatabaseName("UX_B2B_CariLocks_CariKod");
        });
        
        modelBuilder.Entity<B2BInstallmentAllowedBin>(entity =>
        {
            entity.ToTable("B2B_InstallmentAllowedBins");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.BankCode)
                .HasMaxLength(50)
                .IsRequired();

            entity.Property(e => e.BankName)
                .HasMaxLength(100)
                .IsRequired();

            entity.Property(e => e.BinPrefix)
                .HasMaxLength(8)
                .IsRequired();

            entity.Property(e => e.Note)
                .HasMaxLength(500);

            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasDefaultValueSql("GETDATE()");

            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime");

            entity.HasIndex(e => new { e.BankCode, e.BinPrefix })
                .IsUnique()
                .HasDatabaseName("UX_B2B_InstallmentAllowedBins_BankCode_BinPrefix");
        });

        modelBuilder.Entity<AnaMenuHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ana_menu__3213E83F9D732E72");

            entity.ToTable("ana_menu_hrk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CapTr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cap_tr");
            entity.Property(e => e.Class)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("class");
            entity.Property(e => e.IconIndex).HasColumnName("icon_index");
            entity.Property(e => e.Modul)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.UserKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("user_kod");
        });

        modelBuilder.Entity<AnaMenuMa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ana_menu_mas");

            entity.Property(e => e.CokluSatir).HasColumnName("coklu_satir");
            entity.Property(e => e.EskiStyle)
                .HasDefaultValue(false)
                .HasColumnName("Eski_Style");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.KisayolCap).HasColumnName("kisayol_cap");
            entity.Property(e => e.Modul)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Style).HasColumnName("style");
            entity.Property(e => e.UserKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("user_kod");
        });

        modelBuilder.Entity<AppIrsaliyeHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AppIrsal__3214EC0708238C5B");

            entity.ToTable("AppIrsaliyeHrk");

            entity.Property(e => e.AppIrsaliyeId).HasDefaultValue(0);
            entity.Property(e => e.BarkodNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DeviceId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fiyat).HasDefaultValue(0.0);
            entity.Property(e => e.Miktar).HasDefaultValue(0.0);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusturmaUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SiraNo).HasDefaultValue(0);
            entity.Property(e => e.StokKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StokTip)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TarihSaat).HasColumnType("datetime");
        });

        modelBuilder.Entity<AppIrsaliyeMa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AppIrsal__3214EC07A9D680AC");

            entity.Property(e => e.CariKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepoKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeviceId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusturmaUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Seri)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SeriNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TarihSaat).HasColumnType("datetime");
        });

        modelBuilder.Entity<AppRafEitketHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AppRafEi__3214EC07F28D35CC");

            entity.ToTable("AppRafEitketHrk");

            entity.Property(e => e.AppRafEtiketId).HasDefaultValue(0);
            entity.Property(e => e.BarkodNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DeviceId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusturmaUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SiraNo).HasDefaultValue(0);
            entity.Property(e => e.TarihSaat).HasColumnType("datetime");
        });

        modelBuilder.Entity<AppRafEtiketMa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AppRafEt__3214EC07014D1872");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DeviceId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirmaNo).HasDefaultValue(0);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusturmaUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TarihSaat).HasColumnType("datetime");
        });

        modelBuilder.Entity<AppSayim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AppSayim__3214EC079DB37C91");

            entity.ToTable("AppSayim");

            entity.HasIndex(e => new { e.DeviceId, e.AppSayimId, e.SiraNo }, "AppSayim_AppSayimId_SiraNo_Index");

            entity.Property(e => e.AppSayimId).HasDefaultValue(0);
            entity.Property(e => e.BackSayimId).HasDefaultValue(0);
            entity.Property(e => e.BarkodNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DeviceId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Miktar).HasDefaultValue(0.0);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusturmaUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SiraNo).HasDefaultValue(0);
            entity.Property(e => e.StokKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StokTip)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TarihSaat).HasColumnType("datetime");
        });

        modelBuilder.Entity<BakiyeBanka>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_Banka");

            entity.Property(e => e.Alacak).HasColumnName("alacak");
            entity.Property(e => e.Borc).HasColumnName("borc");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
        });

        modelBuilder.Entity<BakiyeCari>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_Cari");

            entity.Property(e => e.Alacak).HasColumnName("alacak");
            entity.Property(e => e.AvansAlcbakiye).HasColumnName("Avans_alcbakiye");
            entity.Property(e => e.AvansBakiye).HasColumnName("Avans_bakiye");
            entity.Property(e => e.AvansBrcbakiye).HasColumnName("Avans_brcbakiye");
            entity.Property(e => e.Borc).HasColumnName("borc");
            entity.Property(e => e.CarBakiye).HasColumnName("car_bakiye");
            entity.Property(e => e.CekBakiye).HasColumnName("cek_bakiye");
            entity.Property(e => e.CirBakiye).HasColumnName("cir_bakiye");
            entity.Property(e => e.FisAdet).HasColumnName("fis_adet");
            entity.Property(e => e.FisAlcbakiye).HasColumnName("fis_alcbakiye");
            entity.Property(e => e.FisBakiye).HasColumnName("fis_bakiye");
            entity.Property(e => e.FisBrcbakiye).HasColumnName("fis_brcbakiye");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.IrsAdet).HasColumnName("irs_adet");
            entity.Property(e => e.IrsAlcbakiye).HasColumnName("irs_alcbakiye");
            entity.Property(e => e.IrsBakiye).HasColumnName("irs_bakiye");
            entity.Property(e => e.IrsBrcbakiye).HasColumnName("irs_brcbakiye");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.SonFisTarih)
                .HasColumnType("datetime")
                .HasColumnName("son_fis_tarih");
            entity.Property(e => e.SonFisTutar).HasColumnName("son_fis_tutar");
            entity.Property(e => e.SonalcTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonalc_tarih");
            entity.Property(e => e.SonalcTutar).HasColumnName("sonalc_tutar");
            entity.Property(e => e.SonbrcTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonbrc_tarih");
            entity.Property(e => e.SonbrcTutar).HasColumnName("sonbrc_tutar");
            entity.Property(e => e.SonhrkTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonhrk_tarih");
        });

        modelBuilder.Entity<BakiyeFisCariGenelAy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_Fis_Cari_Genel_Ay");

            entity.Property(e => e.Bakiye).HasColumnName("bakiye");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
        });

        modelBuilder.Entity<BakiyeFisCariTopAy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_Fis_Cari_Top_Ay");

            entity.Property(e => e.Ay).HasColumnName("ay");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
        });

        modelBuilder.Entity<BakiyeGelGid>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_Gel_Gid");

            entity.Property(e => e.Alacak).HasColumnName("alacak");
            entity.Property(e => e.Borc).HasColumnName("borc");
            entity.Property(e => e.CarBakiye).HasColumnName("car_bakiye");
            entity.Property(e => e.CekBakiye).HasColumnName("cek_bakiye");
            entity.Property(e => e.FisAdet).HasColumnName("fis_adet");
            entity.Property(e => e.FisBakiye).HasColumnName("fis_bakiye");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.SonFisTarih)
                .HasColumnType("datetime")
                .HasColumnName("son_fis_tarih");
            entity.Property(e => e.SonFisTutar).HasColumnName("son_fis_tutar");
            entity.Property(e => e.SonhrkTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonhrk_tarih");
        });

        modelBuilder.Entity<BakiyeIstkredi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_istkredi");

            entity.Property(e => e.Alacak).HasColumnName("alacak");
            entity.Property(e => e.Borc).HasColumnName("borc");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.VadGelen).HasColumnName("vad_gelen");
        });

        modelBuilder.Entity<BakiyeKasa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_Kasa");

            entity.Property(e => e.Cikan)
                .HasColumnType("decimal(38, 8)")
                .HasColumnName("cikan");
            entity.Property(e => e.Giren)
                .HasColumnType("decimal(38, 8)")
                .HasColumnName("giren");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
        });

        modelBuilder.Entity<BakiyePerakende>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_Perakende");

            entity.Property(e => e.Alacak).HasColumnName("alacak");
            entity.Property(e => e.Borc).HasColumnName("borc");
            entity.Property(e => e.CarBakiye).HasColumnName("car_bakiye");
            entity.Property(e => e.FisAdet).HasColumnName("fis_adet");
            entity.Property(e => e.FisBakiye).HasColumnName("fis_bakiye");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.SonFisTarih)
                .HasColumnType("datetime")
                .HasColumnName("son_fis_tarih");
            entity.Property(e => e.SonFisTutar).HasColumnName("son_fis_tutar");
            entity.Property(e => e.SonhrkTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonhrk_tarih");
        });

        modelBuilder.Entity<BakiyePersonel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_Personel");

            entity.Property(e => e.Alacak).HasColumnName("alacak");
            entity.Property(e => e.Borc).HasColumnName("borc");
            entity.Property(e => e.CarBakiye).HasColumnName("car_bakiye");
            entity.Property(e => e.CekBakiye).HasColumnName("cek_bakiye");
            entity.Property(e => e.FisAdet).HasColumnName("fis_adet");
            entity.Property(e => e.FisBakiye).HasColumnName("fis_bakiye");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.SonFisTarih)
                .HasColumnType("datetime")
                .HasColumnName("son_fis_tarih");
            entity.Property(e => e.SonFisTutar).HasColumnName("son_fis_tutar");
            entity.Property(e => e.SonhrkTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonhrk_tarih");
        });

        modelBuilder.Entity<BakiyePo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_Pos");

            entity.Property(e => e.BekBak).HasColumnName("bek_bak");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.KomBak).HasColumnName("kom_bak");
            entity.Property(e => e.VadGelen).HasColumnName("vad_gelen");
        });

        modelBuilder.Entity<BakiyePromPuan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_Prom_Puan");

            entity.Property(e => e.AlsTutar).HasColumnName("Als_Tutar");
            entity.Property(e => e.CarKartId).HasColumnName("Car_KartID");
            entity.Property(e => e.CikanPuan).HasColumnName("Cikan_Puan");
            entity.Property(e => e.GirenPuan).HasColumnName("Giren_Puan");
            entity.Property(e => e.KulTutar).HasColumnName("Kul_Tutar");
            entity.Property(e => e.MevcutPuan).HasColumnName("Mevcut_Puan");
            entity.Property(e => e.SonTarih).HasColumnType("datetime");
        });

        modelBuilder.Entity<BakiyePromUrunMiktar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_Prom_Urun_Miktar");

            entity.Property(e => e.CikanMiktar).HasColumnName("Cikan_Miktar");
            entity.Property(e => e.GirenMiktar).HasColumnName("Giren_Miktar");
            entity.Property(e => e.MevcutMiktar).HasColumnName("Mevcut_Miktar");
            entity.Property(e => e.StkId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Stk_id");
            entity.Property(e => e.TipId).HasColumnName("tip_id");
        });

        modelBuilder.Entity<BakiyeRehber>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_Rehber");

            entity.Property(e => e.Alacak).HasColumnName("alacak");
            entity.Property(e => e.Borc).HasColumnName("borc");
            entity.Property(e => e.CarBakiye).HasColumnName("car_bakiye");
            entity.Property(e => e.FisAdet).HasColumnName("fis_adet");
            entity.Property(e => e.FisBakiye).HasColumnName("fis_bakiye");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.SonFisTarih)
                .HasColumnType("datetime")
                .HasColumnName("son_fis_tarih");
            entity.Property(e => e.SonFisTutar).HasColumnName("son_fis_tutar");
            entity.Property(e => e.SonhrkTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonhrk_tarih");
        });

        modelBuilder.Entity<BakiyeStokMiktar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Bakiye_Stok_Miktar");

            entity.Property(e => e.AlsiadeMik).HasColumnName("alsiade_mik");
            entity.Property(e => e.AlsiadeTopkdvli).HasColumnName("alsiade_topkdvli");
            entity.Property(e => e.CikMiktar).HasColumnName("cik_miktar");
            entity.Property(e => e.CikTopkdvli).HasColumnName("cik_topkdvli");
            entity.Property(e => e.CikTopkdvsiz).HasColumnName("cik_topkdvsiz");
            entity.Property(e => e.GirMiktar).HasColumnName("gir_miktar");
            entity.Property(e => e.GirTopkdvli).HasColumnName("gir_topkdvli");
            entity.Property(e => e.GirTopkdvsiz).HasColumnName("gir_topkdvsiz");
            entity.Property(e => e.HarMiktar).HasColumnName("har_miktar");
            entity.Property(e => e.MevMiktar).HasColumnName("mev_miktar");
            entity.Property(e => e.OrtalsFiykdvli).HasColumnName("ortals_fiykdvli");
            entity.Property(e => e.OrtalsFiykdvsiz).HasColumnName("ortals_fiykdvsiz");
            entity.Property(e => e.SatiadeMik).HasColumnName("satiade_mik");
            entity.Property(e => e.SatiadeTopkdvli).HasColumnName("satiade_topkdvli");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
        });

        modelBuilder.Entity<BakiyeStokMiktar1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_Stok_Miktar");

            entity.Property(e => e.AlsiadeMik).HasColumnName("alsiade_mik");
            entity.Property(e => e.AlsiadeTopkdvli).HasColumnName("alsiade_topkdvli");
            entity.Property(e => e.CikMiktar).HasColumnName("cik_miktar");
            entity.Property(e => e.CikTopkdvli).HasColumnName("cik_topkdvli");
            entity.Property(e => e.CikTopkdvsiz).HasColumnName("cik_topkdvsiz");
            entity.Property(e => e.GirMiktar).HasColumnName("gir_miktar");
            entity.Property(e => e.GirTopkdvli).HasColumnName("gir_topkdvli");
            entity.Property(e => e.GirTopkdvsiz).HasColumnName("gir_topkdvsiz");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.HarMiktar).HasColumnName("har_miktar");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.MevMiktar).HasColumnName("mev_miktar");
            entity.Property(e => e.OrtalsFiykdvli).HasColumnName("ortals_fiykdvli");
            entity.Property(e => e.OrtalsFiykdvsiz).HasColumnName("ortals_fiykdvsiz");
            entity.Property(e => e.SatiadeMik).HasColumnName("satiade_mik");
            entity.Property(e => e.SatiadeTopkdvli).HasColumnName("satiade_topkdvli");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
        });

        modelBuilder.Entity<BakiyeStokMiktarFirmaDep>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_Stok_Miktar_Firma_Dep");

            entity.Property(e => e.AlsiadeMik).HasColumnName("alsiade_mik");
            entity.Property(e => e.AlsiadeTopkdvli).HasColumnName("alsiade_topkdvli");
            entity.Property(e => e.CikMiktar).HasColumnName("cik_miktar");
            entity.Property(e => e.CikTopkdvli).HasColumnName("cik_topkdvli");
            entity.Property(e => e.CikTopkdvsiz).HasColumnName("cik_topkdvsiz");
            entity.Property(e => e.Depkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.GirMiktar).HasColumnName("gir_miktar");
            entity.Property(e => e.GirTopkdvli).HasColumnName("gir_topkdvli");
            entity.Property(e => e.GirTopkdvsiz).HasColumnName("gir_topkdvsiz");
            entity.Property(e => e.HarMiktar).HasColumnName("har_miktar");
            entity.Property(e => e.MevMiktar).HasColumnName("mev_miktar");
            entity.Property(e => e.OrtalsFiykdvli).HasColumnName("ortals_fiykdvli");
            entity.Property(e => e.OrtalsFiykdvsiz).HasColumnName("ortals_fiykdvsiz");
            entity.Property(e => e.SatiadeMik).HasColumnName("satiade_mik");
            entity.Property(e => e.SatiadeTopkdvli).HasColumnName("satiade_topkdvli");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
        });

        modelBuilder.Entity<BakiyeTank>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Bakiye_Tank");

            entity.Property(e => e.CikMiktar).HasColumnName("cik_miktar");
            entity.Property(e => e.CikTopkdvli).HasColumnName("cik_topkdvli");
            entity.Property(e => e.CikTopkdvsiz).HasColumnName("cik_topkdvsiz");
            entity.Property(e => e.GirMiktar).HasColumnName("gir_miktar");
            entity.Property(e => e.GirTopkdvli).HasColumnName("gir_topkdvli");
            entity.Property(e => e.GirTopkdvsiz).HasColumnName("gir_topkdvsiz");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.MevMiktar).HasColumnName("mev_miktar");
        });

        modelBuilder.Entity<BankaKartListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Banka_Kart_Listesi");

            entity.Property(e => e.Actutar).HasColumnName("actutar");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Alacak).HasColumnName("alacak");
            entity.Property(e => e.AlcBakiye).HasColumnName("alc_bakiye");
            entity.Property(e => e.Borc).HasColumnName("borc");
            entity.Property(e => e.BrcBakiye).HasColumnName("brc_bakiye");
            entity.Property(e => e.Cekmuhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cekmuhkod");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Grp1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("grp1");
            entity.Property(e => e.Grp2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("grp2");
            entity.Property(e => e.Grp3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("grp3");
            entity.Property(e => e.Grup)
                .HasMaxLength(100)
                .HasColumnName("grup");
            entity.Property(e => e.Hesno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hesno");
            entity.Property(e => e.Iban)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Ilgili)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ilgili");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.TopBakiye).HasColumnName("top_bakiye");
        });

        modelBuilder.Entity<Bankahrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno, e.Masterid, e.Bankod, e.Bankhrkid }).HasName("PK__bankahrk__8FE79CF732C9E9A8");

            entity.ToTable("bankahrk", tb =>
                {
                    tb.HasTrigger("bankahrk_log_trd");
                    tb.HasTrigger("bankahrk_log_tri");
                    tb.HasTrigger("bankahrk_log_tru");
                    tb.HasTrigger("bankhrk_trd");
                    tb.HasTrigger("bankhrk_tri");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Masterid).HasColumnName("masterid");
            entity.Property(e => e.Bankod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("bankod");
            entity.Property(e => e.Bankhrkid).HasColumnName("bankhrkid");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Adaid).HasColumnName("adaid");
            entity.Property(e => e.Alacak)
                .HasDefaultValue(0.0)
                .HasColumnName("alacak");
            entity.Property(e => e.BankId).HasColumnName("bank_id");
            entity.Property(e => e.Belno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.BelrapId)
                .HasDefaultValue(0)
                .HasColumnName("belrap_id");
            entity.Property(e => e.Borc)
                .HasDefaultValue(0.0)
                .HasColumnName("borc");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.CariAvans).HasDefaultValue(false);
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Cartur)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cartur");
            entity.Property(e => e.Cekid)
                .HasDefaultValue(0)
                .HasColumnName("cekid");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Devir)
                .HasDefaultValue(false)
                .HasColumnName("devir");
            entity.Property(e => e.EntegreAktar)
                .HasColumnType("datetime")
                .HasColumnName("entegre_aktar");
            entity.Property(e => e.EntegreTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("entegre_tip");
            entity.Property(e => e.FaizOran)
                .HasDefaultValue(0.0)
                .HasColumnName("faiz_oran");
            entity.Property(e => e.FaizTutar)
                .HasDefaultValue(0.0)
                .HasColumnName("Faiz_tutar");
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Fisfatid)
                .HasDefaultValue(0.0)
                .HasColumnName("fisfatid");
            entity.Property(e => e.Fisfattip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("KENDI")
                .HasColumnName("fisfattip");
            entity.Property(e => e.Fisid).HasColumnName("fisid");
            entity.Property(e => e.Gctip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gctip");
            entity.Property(e => e.GidId).HasColumnName("gid_id");
            entity.Property(e => e.Gidkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("gidkod");
            entity.Property(e => e.Gidtutar)
                .HasDefaultValue(0.0)
                .HasColumnName("gidtutar");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmhrkad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmhrkad");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.KarsiKartKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Karsi_KartKod");
            entity.Property(e => e.KarsiKartTip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Karsi_KartTip");
            entity.Property(e => e.Karsiheskod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("karsiheskod");
            entity.Property(e => e.Karsihestip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("karsihestip");
            entity.Property(e => e.KasId).HasColumnName("kas_id");
            entity.Property(e => e.Kaskod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("kaskod");
            entity.Property(e => e.Kur).HasColumnName("kur");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Pro)
                .HasDefaultValue(1)
                .HasColumnName("pro");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Rg)
                .HasDefaultValue((byte)1)
                .HasColumnName("rg");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Tahodeid).HasColumnName("tahodeid");
            entity.Property(e => e.TaksitBasTar)
                .HasColumnType("datetime")
                .HasColumnName("Taksit_BasTar");
            entity.Property(e => e.TaksitBitTar)
                .HasColumnType("datetime")
                .HasColumnName("Taksit_BitTar");
            entity.Property(e => e.TaksitSay)
                .HasDefaultValue(0)
                .HasColumnName("Taksit_Say");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.Vadetar)
                .HasColumnType("datetime")
                .HasColumnName("vadetar");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Bankakart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod, e.Sil, e.Firmano }).HasName("PK__bankakar__DAB2FC2B70970815");

            entity.ToTable("bankakart", tb =>
                {
                    tb.HasTrigger("bankakart_log_trd");
                    tb.HasTrigger("bankakart_log_tri");
                    tb.HasTrigger("bankakart_log_tru");
                    tb.HasTrigger("bankakart_tri");
                    tb.HasTrigger("bankakart_tru");
                });

            entity.HasIndex(e => e.Kod, "bankakart_uq").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Actutar)
                .HasDefaultValue(0.0)
                .HasColumnName("actutar");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Alacak)
                .HasDefaultValue(0.0)
                .HasColumnName("alacak");
            entity.Property(e => e.Borc)
                .HasDefaultValue(0.0)
                .HasColumnName("borc");
            entity.Property(e => e.Cekmuhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cekmuhkod");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.Grp1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("grp1");
            entity.Property(e => e.Grp2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("grp2");
            entity.Property(e => e.Grp3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("grp3");
            entity.Property(e => e.Hesno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hesno");
            entity.Property(e => e.Iban)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ilgili)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ilgili");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.RemoteId).HasColumnName("Remote_id");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tel");
        });

        modelBuilder.Entity<BanknotHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Banknot___3213E83FADD70C92");

            entity.ToTable("Banknot_hrk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adet).HasColumnName("adet");
            entity.Property(e => e.Deger).HasColumnName("deger");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.HrkId).HasColumnName("hrk_id");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Varok).HasColumnName("varok");
            entity.Property(e => e.Yerad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<BanknotTip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Banknot___3213E83F1879D53A");

            entity.ToTable("Banknot_Tip");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer).HasColumnName("olususer");
            entity.Property(e => e.Sil)
                .HasDefaultValue((byte)0)
                .HasColumnName("sil");
        });

        modelBuilder.Entity<Barkod>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod }).HasName("PK__barkod__DFEE6686B05E93D4");

            entity.ToTable("barkod", tb =>
                {
                    tb.HasTrigger("barkod_log_trd");
                    tb.HasTrigger("barkod_log_tri");
                    tb.HasTrigger("barkod_log_tru");
                });

            entity.HasIndex(e => new { e.Tip, e.Kod }, "barkod_idx");

            entity.HasIndex(e => e.Kod, "barkod_kod_index");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Barkod1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("barkod");
            entity.Property(e => e.Brim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Carpan)
                .HasDefaultValue(1.0)
                .HasColumnName("carpan");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Master).HasDefaultValue(false);
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("Remote_id");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.StkId).HasColumnName("stk_id");
            entity.Property(e => e.Terazi).HasDefaultValue(false);
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.TipId).HasColumnName("tip_id");
        });

        modelBuilder.Entity<BarkodBedelsiz>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("BarkodBedelsiz_pk");

            entity.ToTable("BarkodBedelsiz");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aktif).HasDefaultValue(true);
            entity.Property(e => e.Barkod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Brim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Carpan)
                .HasDefaultValue(1.0)
                .HasColumnName("carpan");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("Remote_id");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.StkId).HasColumnName("stk_id");
            entity.Property(e => e.Terazi).HasDefaultValue(false);
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.TipId).HasColumnName("tip_id");
        });

        modelBuilder.Entity<Bolum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bolum");

            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Anaformnesne)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("anaformnesne");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Havuz).HasColumnName("havuz");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Modul)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sfirmano).HasColumnName("sfirmano");
        });

        modelBuilder.Entity<BulutTahsilat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BulutTah__3214EC077CAA0BA0");

            entity.ToTable("BulutTahsilat");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.AktarimId).HasDefaultValue(0);
            entity.Property(e => e.AktarimTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.BankAd)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.BankIban)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BankIBAN");
            entity.Property(e => e.BankKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BankaId).HasDefaultValue(0);
            entity.Property(e => e.CariId).HasDefaultValue(0);
            entity.Property(e => e.CariTipId).HasDefaultValue(1);
            entity.Property(e => e.EntegratorId).HasDefaultValue(0);
            entity.Property(e => e.Firmano).HasDefaultValue(0);
            entity.Property(e => e.KayitTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.TahsilatId).HasDefaultValue(0);
            entity.Property(e => e.TahsilatTipAd)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Tcvknno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TCVKNNo");
            entity.Property(e => e.Tutar).HasDefaultValue(0.0);
            entity.Property(e => e.Unvan)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CariAracSayi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Cari_AracSayi");

            entity.Property(e => e.AracSayi).HasColumnName("Arac_Sayi");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
        });

        modelBuilder.Entity<CariAvansBakiye>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Cari_Avans_Bakiye");

            entity.Property(e => e.Alacak).HasColumnName("alacak");
            entity.Property(e => e.Bakiye).HasColumnName("bakiye");
            entity.Property(e => e.Borc).HasColumnName("borc");
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
        });

        modelBuilder.Entity<CariCalismaSart>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Cari_Calisma_Sart");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AvansTakip).HasDefaultValue(false);
            entity.Property(e => e.DbsRefNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DBS_RefNo");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Fatisk)
                .HasDefaultValue(0.0)
                .HasColumnName("fatisk");
            entity.Property(e => e.Fatvadfark)
                .HasDefaultValue(0.0)
                .HasColumnName("fatvadfark");
            entity.Property(e => e.Fatvadsur)
                .HasDefaultValue(0)
                .HasColumnName("fatvadsur");
            entity.Property(e => e.Fatvadtip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fatvadtip");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Fisisk)
                .HasDefaultValue(0.0)
                .HasColumnName("fisisk");
            entity.Property(e => e.Fisvadfark)
                .HasDefaultValue(0.0)
                .HasColumnName("fisvadfark");
            entity.Property(e => e.Fisvadsur)
                .HasDefaultValue(0)
                .HasColumnName("fisvadsur");
            entity.Property(e => e.Fisvadtip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fisvadtip");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.LimitTip)
                .HasDefaultValue(0)
                .HasColumnName("limit_tip");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.OtoFisVadeFark)
                .HasDefaultValue(false)
                .HasColumnName("Oto_FisVadeFark");
            entity.Property(e => e.RiskLimit)
                .HasDefaultValue(0.0)
                .HasColumnName("Risk_Limit");
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.ToplamLimit).HasDefaultValue(0.0);
            entity.Property(e => e.TtsBayVadFark).HasDefaultValue(0.0);
            entity.Property(e => e.TtsBayisk).HasDefaultValue(0.0);
            entity.Property(e => e.TtsDagVadFark).HasDefaultValue(0.0);
            entity.Property(e => e.TtsDagisk).HasDefaultValue(0.0);
            entity.Property(e => e.TtsOdeTip)
                .HasDefaultValue(0)
                .HasColumnName("TTS_OdeTip");
            entity.Property(e => e.Web).HasDefaultValue(false);
            entity.Property(e => e.WebAvans).HasDefaultValue(false);
            entity.Property(e => e.WebCariBakiye).HasDefaultValue(false);
            entity.Property(e => e.WebCariHrk).HasDefaultValue(false);
            entity.Property(e => e.WebFatura).HasDefaultValue(false);
            entity.Property(e => e.WebFaturaIskontoluTahsil).HasDefaultValue(false);
            entity.Property(e => e.WebFaturaOdendi).HasDefaultValue(false);
            entity.Property(e => e.WebFaturaTahsil).HasDefaultValue(false);
            entity.Property(e => e.WebFis).HasDefaultValue(false);
            entity.Property(e => e.WebFisIskontoluTahsil).HasDefaultValue(false);
            entity.Property(e => e.WebFisOdendi).HasDefaultValue(false);
            entity.Property(e => e.WebFisTahsil).HasDefaultValue(false);
            entity.Property(e => e.WebPos).HasDefaultValue(false);
        });

        modelBuilder.Entity<CariCalismaUrunIskonto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Cari_Calisma_Urun_Iskonto");

            entity.Property(e => e.DegisTarSaat).HasColumnType("datetime");
            entity.Property(e => e.DegisUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IskontoOran).HasColumnName("Iskonto_Oran");
            entity.Property(e => e.MasId).HasColumnName("Mas_Id");
            entity.Property(e => e.OlusTarSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.StkId).HasColumnName("Stk_id");
            entity.Property(e => e.StkKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Stk_Kod");
            entity.Property(e => e.StkTip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("akykt");
            entity.Property(e => e.StkTipId)
                .HasDefaultValue(1)
                .HasColumnName("StkTip_id");
            entity.Property(e => e.Tip).HasDefaultValue(1);
        });

        modelBuilder.Entity<CariCekBakiye>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Cari_Cek_Bakiye");

            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CekBakiye).HasColumnName("cek_bakiye");
        });

        modelBuilder.Entity<CariCiroBakiye>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Cari_Ciro_Bakiye");

            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CekBakiye).HasColumnName("cek_bakiye");
        });

        modelBuilder.Entity<CariFatUrunIskonto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cari_Fat__3214EC07178347D1");

            entity.ToTable("Cari_Fat_Urun_Iskonto");

            entity.Property(e => e.CarId).HasColumnName("Car_id");
            entity.Property(e => e.CarKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Car_Kod");
            entity.Property(e => e.CartipId)
                .HasDefaultValue(1)
                .HasColumnName("cartip_id");
            entity.Property(e => e.Firmano).HasDefaultValue(0);
            entity.Property(e => e.IskontoOran).HasColumnName("Iskonto_Oran");
            entity.Property(e => e.IskontoTip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("%")
                .HasColumnName("Iskonto_Tip");
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.StkId).HasColumnName("Stk_id");
            entity.Property(e => e.StkKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Stk_Kod");
            entity.Property(e => e.StkTip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("akykt");
            entity.Property(e => e.StkTipId)
                .HasDefaultValue(1)
                .HasColumnName("StkTip_id");
        });

        modelBuilder.Entity<CariFisBakiye>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Cari_Fis_Bakiye");

            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.FisAdet).HasColumnName("fis_adet");
            entity.Property(e => e.FisAlcbakiye).HasColumnName("fis_alcbakiye");
            entity.Property(e => e.FisBakiye).HasColumnName("fis_bakiye");
            entity.Property(e => e.FisBrcbakiye).HasColumnName("fis_brcbakiye");
        });

        modelBuilder.Entity<CariFisBakiyeAy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Cari_Fis_Bakiye_Ay");

            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.FisAdet).HasColumnName("fis_adet");
            entity.Property(e => e.FisAlcbakiye).HasColumnName("fis_alcbakiye");
            entity.Property(e => e.FisBakiye).HasColumnName("fis_bakiye");
            entity.Property(e => e.FisBrcbakiye).HasColumnName("fis_brcbakiye");
        });

        modelBuilder.Entity<CariFisBakiyeKap>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Cari_Fis_Bakiye_Kap");

            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.FisAdet).HasColumnName("fis_adet");
            entity.Property(e => e.FisAlcbakiye).HasColumnName("fis_alcbakiye");
            entity.Property(e => e.FisBakiye).HasColumnName("fis_bakiye");
            entity.Property(e => e.FisBrcbakiye).HasColumnName("fis_brcbakiye");
        });

        modelBuilder.Entity<CariHrkBakiye>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Cari_Hrk_Bakiye");

            entity.Property(e => e.Alacak).HasColumnName("alacak");
            entity.Property(e => e.Bakiye).HasColumnName("bakiye");
            entity.Property(e => e.Borc).HasColumnName("borc");
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.SonhrkTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonhrk_tarih");
        });

        modelBuilder.Entity<CariHrkBakiyeAy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Cari_Hrk_Bakiye_Ay");

            entity.Property(e => e.Alacak).HasColumnName("alacak");
            entity.Property(e => e.Bakiye).HasColumnName("bakiye");
            entity.Property(e => e.Borc).HasColumnName("borc");
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
        });

        modelBuilder.Entity<CariIrsaliyeBakiye>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Cari_irsaliye_Bakiye");

            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.IrsAdet).HasColumnName("irs_adet");
            entity.Property(e => e.IrsAlcbakiye).HasColumnName("irs_alcbakiye");
            entity.Property(e => e.IrsBakiye).HasColumnName("irs_bakiye");
            entity.Property(e => e.IrsBrcbakiye).HasColumnName("irs_brcbakiye");
        });

        modelBuilder.Entity<CariKartListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Cari_Kart_Listesi");

            entity.Property(e => e.Actutar).HasColumnName("actutar");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.Adres2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("adres2");
            entity.Property(e => e.AdresPostaKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AlcBakiye).HasColumnName("alc_bakiye");
            entity.Property(e => e.AlcTopBakiye).HasColumnName("alc_top_bakiye");
            entity.Property(e => e.AracAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Arac_Ad");
            entity.Property(e => e.AracSayi).HasColumnName("Arac_Sayi");
            entity.Property(e => e.AvansBakiye).HasColumnName("avans_bakiye");
            entity.Property(e => e.BankaAd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("bankaAd");
            entity.Property(e => e.BankaDbs)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BankaKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BrcBakiye).HasColumnName("brc_bakiye");
            entity.Property(e => e.BrcTopBakiye).HasColumnName("brc_top_bakiye");
            entity.Property(e => e.CarBakiye).HasColumnName("car_bakiye");
            entity.Property(e => e.CekBakiye).HasColumnName("cek_bakiye");
            entity.Property(e => e.CekharcBakiye).HasColumnName("cekharc_bakiye");
            entity.Property(e => e.Cep)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cep");
            entity.Property(e => e.CirBakiye).HasColumnName("cir_bakiye");
            entity.Property(e => e.DbsRefNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DBS_RefNo");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Efatura).HasColumnName("EFatura");
            entity.Property(e => e.EpdkLisansNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Epdk_LisansNo");
            entity.Property(e => e.Epostagonder).HasColumnName("epostagonder");
            entity.Property(e => e.Evil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evil");
            entity.Property(e => e.Evilce)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evilce");
            entity.Property(e => e.FatCarId).HasColumnName("fat_car_id");
            entity.Property(e => e.FatCarKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("fat_car_kod");
            entity.Property(e => e.FatCarSec).HasColumnName("fat_car_sec");
            entity.Property(e => e.Fatisk).HasColumnName("fatisk");
            entity.Property(e => e.Fatunvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fatunvan");
            entity.Property(e => e.Fatvadfark).HasColumnName("fatvadfark");
            entity.Property(e => e.Fatvadsur).HasColumnName("fatvadsur");
            entity.Property(e => e.Fatvadtip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fatvadtip");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.FisAdet).HasColumnName("fis_adet");
            entity.Property(e => e.FisBakiye).HasColumnName("fis_bakiye");
            entity.Property(e => e.Fisadet).HasColumnName("fisadet");
            entity.Property(e => e.Fisakadet).HasColumnName("fisakadet");
            entity.Property(e => e.Fisaktut).HasColumnName("fisaktut");
            entity.Property(e => e.Fisisk).HasColumnName("fisisk");
            entity.Property(e => e.Fisvadfark).HasColumnName("fisvadfark");
            entity.Property(e => e.Fisvadsur).HasColumnName("fisvadsur");
            entity.Property(e => e.Fisvadtip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fisvadtip");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.Grup).HasMaxLength(100);
            entity.Property(e => e.Hesapno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hesapno");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Ilgili)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ilgili");
            entity.Property(e => e.IrsAdet).HasColumnName("irs_adet");
            entity.Property(e => e.IrsBakiye).HasColumnName("irs_bakiye");
            entity.Property(e => e.KalanLimit).HasColumnName("Kalan_limit");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.KulTutLimit).HasColumnName("kul_tut_limit");
            entity.Property(e => e.Kulkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kulkod");
            entity.Property(e => e.Kulsif)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kulsif");
            entity.Property(e => e.LimitTip).HasColumnName("limit_tip");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Notack)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("notack");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.OtoFisVadeFark).HasColumnName("Oto_FisVadeFark");
            entity.Property(e => e.Otofisak).HasColumnName("otofisak");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.PerId).HasColumnName("per_id");
            entity.Property(e => e.PerIdin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("perIDIN");
            entity.Property(e => e.RemoteId).HasColumnName("Remote_id");
            entity.Property(e => e.Resim)
                .HasColumnType("image")
                .HasColumnName("resim");
            entity.Property(e => e.RiskLimit).HasColumnName("Risk_Limit");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.SonFisTarih)
                .HasColumnType("datetime")
                .HasColumnName("son_fis_tarih");
            entity.Property(e => e.SonFisTutar).HasColumnName("son_fis_tutar");
            entity.Property(e => e.SonalcTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonalc_tarih");
            entity.Property(e => e.SonalcTutar).HasColumnName("sonalc_tutar");
            entity.Property(e => e.SonbrcTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonbrc_tarih");
            entity.Property(e => e.SonbrcTutar).HasColumnName("sonbrc_tutar");
            entity.Property(e => e.SonhrkTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonhrk_tarih");
            entity.Property(e => e.Soyad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("soyad");
            entity.Property(e => e.Tcno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tcno");
            entity.Property(e => e.Tel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.TeminatAck)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("teminat_ack");
            entity.Property(e => e.TeminatTutar).HasColumnName("teminat_tutar");
            entity.Property(e => e.TicSicilNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TopBakiye).HasColumnName("top_bakiye");
            entity.Property(e => e.Toplamlimit).HasColumnName("toplamlimit");
            entity.Property(e => e.Toplamteminat).HasColumnName("toplamteminat");
            entity.Property(e => e.TtsOdeTip).HasColumnName("TTS_OdeTip");
            entity.Property(e => e.TurAd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("unvan");
            entity.Property(e => e.ValorGun).HasColumnName("Valor_Gun");
            entity.Property(e => e.VergiEposta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vergidaire");
            entity.Property(e => e.Vergikimlikno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("vergikimlikno");
            entity.Property(e => e.Vergino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vergino");
            entity.Property(e => e.Webadres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("webadres");
            entity.Property(e => e.Webextre).HasColumnName("webextre");
            entity.Property(e => e.YktAlmDefNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ykt_alm_def_no");
        });

        modelBuilder.Entity<CariOtoFisVadeFarkTutar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("__CariOtoFisVadeFarkTutar");

            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
        });

        modelBuilder.Entity<CariSonAlcHrk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Cari_Son_Alc_Hrk");

            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.SonalcTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonalc_tarih");
            entity.Property(e => e.SonalcTutar).HasColumnName("sonalc_tutar");
        });

        modelBuilder.Entity<CariSonBrcHrk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Cari_Son_Brc_Hrk");

            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.SonbrcTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonbrc_tarih");
            entity.Property(e => e.SonbrcTutar).HasColumnName("sonbrc_tutar");
        });

        modelBuilder.Entity<CariSonFi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Cari_Son_Fis");

            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.FisTarih)
                .HasColumnType("datetime")
                .HasColumnName("fis_tarih");
            entity.Property(e => e.FisTutar).HasColumnName("fis_tutar");
        });

        modelBuilder.Entity<CariSurucu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cari_Sur__3213E83FE9019E56");

            entity.ToTable("Cari_Surucu");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.CarKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("car_kod");
            entity.Property(e => e.CartipId)
                .HasDefaultValue(1)
                .HasColumnName("cartip_id");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
        });

        modelBuilder.Entity<CariTeminat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Cari_Teminat");

            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Tip)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Tutar).HasColumnName("tutar");
        });

        modelBuilder.Entity<CariTeminatIlk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Cari_Teminat_Ilk");

            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.CarTip)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Tur)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tur");
        });

        modelBuilder.Entity<CariTip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cari_Tip__3213E83F3C788F3A");

            entity.ToTable("Cari_Tip");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AckAl)
                .HasMaxLength(50)
                .HasColumnName("ack_al");
            entity.Property(e => e.AckEn)
                .HasMaxLength(50)
                .HasColumnName("ack_en");
            entity.Property(e => e.AckRu)
                .HasMaxLength(50)
                .HasColumnName("ack_ru");
            entity.Property(e => e.AckTr)
                .HasMaxLength(50)
                .HasColumnName("ack_tr");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CariTur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cari_Tur__3213E83F6A6B5FD4");

            entity.ToTable("Cari_Tur");

            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
        });

        modelBuilder.Entity<CariVadefarkListe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Cari_Vadefark_Liste");

            entity.Property(e => e.Ack)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Belno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.Carhrkid).HasColumnName("carhrkid");
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Carvardmasid).HasColumnName("carvardmasid");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmhrkad)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("islmhrkad");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Tutar).HasColumnName("tutar");
            entity.Property(e => e.Unvan)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("unvan");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Carihrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Carhrkid }).HasName("PK__carihrk__141D4B54ACCBBA29");

            entity.ToTable("carihrk", tb =>
                {
                    tb.HasTrigger("carihrk_log_trd");
                    tb.HasTrigger("carihrk_log_tri");
                    tb.HasTrigger("carihrk_log_tru");
                    tb.HasTrigger("carihrk_trd");
                    tb.HasTrigger("carihrk_tri");
                });

            entity.HasIndex(e => new { e.Cartip, e.Carkod, e.Sil, e.Alacak }, "carihrk_cartip_carkod_sil_alacak");

            entity.HasIndex(e => new { e.Cartip, e.Sil }, "carihrk_cartip_sil");

            entity.HasIndex(e => new { e.Islmtip, e.Islmhrk, e.Sil }, "carihrk_islmtip_islmhrk_sil");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Carhrkid).HasColumnName("carhrkid");
            entity.Property(e => e.Ack)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Adaid).HasColumnName("adaid");
            entity.Property(e => e.Alacak)
                .HasDefaultValue(0.0)
                .HasColumnName("alacak");
            entity.Property(e => e.Bakiye)
                .HasDefaultValue(0.0)
                .HasColumnName("bakiye");
            entity.Property(e => e.BankahrkId).HasColumnName("Bankahrk_id");
            entity.Property(e => e.Belno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("belno");
            entity.Property(e => e.BelrapId)
                .HasDefaultValue(0)
                .HasColumnName("belrap_id");
            entity.Property(e => e.Borc)
                .HasDefaultValue(0.0)
                .HasColumnName("borc");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.CariAvans).HasDefaultValue(false);
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Carvardmasid)
                .HasDefaultValue(0)
                .HasColumnName("carvardmasid");
            entity.Property(e => e.CekId).HasColumnName("Cek_id");
            entity.Property(e => e.Cekid)
                .HasDefaultValue(0)
                .HasColumnName("cekid");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Devir)
                .HasDefaultValue(false)
                .HasColumnName("devir");
            entity.Property(e => e.Entegre).HasDefaultValue(false);
            entity.Property(e => e.EntegreAktar)
                .HasColumnType("datetime")
                .HasColumnName("entegre_aktar");
            entity.Property(e => e.EntegreTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("entegre_tip");
            entity.Property(e => e.FatKapTip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("FAT");
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.Fatstkhrkid)
                .HasDefaultValue(0.0)
                .HasColumnName("fatstkhrkid");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.FisAlcId).HasColumnName("fis_alc_id");
            entity.Property(e => e.FisBrcId).HasColumnName("fis_brc_id");
            entity.Property(e => e.FisCariborcId).HasColumnName("fis_cariborc_id");
            entity.Property(e => e.Fisaktip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("fisaktip");
            entity.Property(e => e.Fisfatid)
                .HasDefaultValue(0.0)
                .HasColumnName("fisfatid");
            entity.Property(e => e.Fisfattip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("KENDI")
                .HasColumnName("fisfattip");
            entity.Property(e => e.Fisid).HasColumnName("fisid");
            entity.Property(e => e.Fisstkhrkid)
                .HasDefaultValue(0.0)
                .HasColumnName("fisstkhrkid");
            entity.Property(e => e.Gctip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gctip");
            entity.Property(e => e.IrsStkAnaid).HasColumnName("irsStkAnaid");
            entity.Property(e => e.Irsid).HasColumnName("irsid");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmhrkad)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("islmhrkad");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.IsthrkId).HasColumnName("isthrk_id");
            entity.Property(e => e.KarsiKartKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Karsi_KartKod");
            entity.Property(e => e.KarsiKartTip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Karsi_KartTip");
            entity.Property(e => e.Karsiheskod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("karsiheskod");
            entity.Property(e => e.Karsihestip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("karsihestip");
            entity.Property(e => e.KasahrkId).HasColumnName("kasahrk_id");
            entity.Property(e => e.Kdvyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("kdvyuz");
            entity.Property(e => e.Kur)
                .HasDefaultValue(1.0)
                .HasColumnName("kur");
            entity.Property(e => e.MaasGun)
                .HasDefaultValue(0.0)
                .HasColumnName("maas_gun");
            entity.Property(e => e.Marsatid)
                .HasDefaultValue(0.0)
                .HasColumnName("marsatid");
            entity.Property(e => e.Masterid)
                .HasDefaultValue(0.0)
                .HasColumnName("masterid");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Perkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Permasmasid)
                .HasDefaultValue(0)
                .HasColumnName("permasmasid");
            entity.Property(e => e.Plaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("plaka");
            entity.Property(e => e.PoshrkId).HasColumnName("Poshrk_id");
            entity.Property(e => e.Pro)
                .HasDefaultValue(1)
                .HasColumnName("pro");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Rg)
                .HasDefaultValue((byte)1)
                .HasColumnName("rg");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.SayId).HasColumnName("say_id");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Surucu)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tahodeid).HasColumnName("tahodeid");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TvirmanKayitHrkId).HasColumnName("TVirmanKayitHrkId");
            entity.Property(e => e.TvirmanKayitId).HasColumnName("TVirmanKayitId");
            entity.Property(e => e.Vadetar)
                .HasColumnType("datetime")
                .HasColumnName("vadetar");
            entity.Property(e => e.Varno)
                .HasDefaultValue(0.0)
                .HasColumnName("varno");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Carikart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod, e.Sil }).HasName("PK__carikart__E033B95B0AD54F22");

            entity.ToTable("carikart", tb =>
                {
                    tb.HasTrigger("carikart_log_trd");
                    tb.HasTrigger("carikart_log_tri");
                    tb.HasTrigger("carikart_log_tru");
                    tb.HasTrigger("carikart_tri");
                    tb.HasTrigger("carikart_tru");
                });

            entity.HasIndex(e => new { e.Grp1, e.Grp2, e.Grp3 }, "carikart_grp_index");

            entity.HasIndex(e => e.Kod, "carikart_uq").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Actutar)
                .HasDefaultValue(0.0)
                .HasColumnName("actutar");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.Adres2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("adres2");
            entity.Property(e => e.AdresPostaKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AracAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Arac_Ad");
            entity.Property(e => e.AvansTakip).HasDefaultValue(false);
            entity.Property(e => e.BankaDbs)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BankaKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Carbak)
                .HasDefaultValue(0.0)
                .HasColumnName("carbak");
            entity.Property(e => e.Cekbak)
                .HasDefaultValue(0.0)
                .HasColumnName("cekbak");
            entity.Property(e => e.Cep)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cep");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.DbsRefNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DBS_RefNo");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.DogumTarih).HasColumnType("datetime");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Efatura).HasColumnName("EFatura");
            entity.Property(e => e.EfaturaTip).HasDefaultValue(0);
            entity.Property(e => e.EpdkLisansNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Epdk_LisansNo");
            entity.Property(e => e.Epostagonder)
                .HasDefaultValue(false)
                .HasColumnName("epostagonder");
            entity.Property(e => e.Evil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evil");
            entity.Property(e => e.Evilce)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evilce");
            entity.Property(e => e.FatCarId).HasColumnName("fat_car_id");
            entity.Property(e => e.FatCarKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Fat_car_kod");
            entity.Property(e => e.FatCarSec).HasColumnName("fat_car_sec");
            entity.Property(e => e.Fatisk).HasColumnName("fatisk");
            entity.Property(e => e.Fatunvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fatunvan");
            entity.Property(e => e.Fatvadfark).HasColumnName("fatvadfark");
            entity.Property(e => e.Fatvadsur)
                .HasDefaultValue(0)
                .HasColumnName("fatvadsur");
            entity.Property(e => e.Fatvadtip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fatvadtip");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Fisadet)
                .HasDefaultValue(0)
                .HasColumnName("fisadet");
            entity.Property(e => e.Fisakadet)
                .HasDefaultValue(0)
                .HasColumnName("fisakadet");
            entity.Property(e => e.Fisaktut)
                .HasDefaultValue(0.0)
                .HasColumnName("fisaktut");
            entity.Property(e => e.Fisbak)
                .HasDefaultValue(0.0)
                .HasColumnName("fisbak");
            entity.Property(e => e.Fisisk).HasColumnName("fisisk");
            entity.Property(e => e.Fisvadfark).HasColumnName("fisvadfark");
            entity.Property(e => e.Fisvadsur)
                .HasDefaultValue(0)
                .HasColumnName("fisvadsur");
            entity.Property(e => e.Fisvadtip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fisvadtip");
            entity.Property(e => e.Grp1)
                .HasDefaultValue(0)
                .HasColumnName("grp1");
            entity.Property(e => e.Grp2)
                .HasDefaultValue(0)
                .HasColumnName("grp2");
            entity.Property(e => e.Grp3)
                .HasDefaultValue(0)
                .HasColumnName("grp3");
            entity.Property(e => e.Hesapno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hesapno");
            entity.Property(e => e.Ilgili)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ilgili");
            entity.Property(e => e.Kulkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kulkod");
            entity.Property(e => e.Kulsif)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kulsif");
            entity.Property(e => e.LimitTip)
                .HasDefaultValue(0)
                .HasColumnName("limit_tip");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Notack)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("notack");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.OtoFisVadeFark)
                .HasDefaultValue(false)
                .HasColumnName("Oto_FisVadeFark");
            entity.Property(e => e.Otofisak)
                .HasDefaultValue(0)
                .HasColumnName("otofisak");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.PerId).HasColumnName("per_id");
            entity.Property(e => e.PerIdin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PerIDIN");
            entity.Property(e => e.PromGrp1).HasColumnName("Prom_Grp1");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("Remote_id");
            entity.Property(e => e.Resim)
                .HasColumnType("image")
                .HasColumnName("resim");
            entity.Property(e => e.RiskLimit)
                .HasDefaultValue(0.0)
                .HasColumnName("Risk_Limit");
            entity.Property(e => e.Sonfistarih)
                .HasColumnType("datetime")
                .HasColumnName("sonfistarih");
            entity.Property(e => e.Sonfistutar)
                .HasDefaultValue(0.0)
                .HasColumnName("sonfistutar");
            entity.Property(e => e.Sonhrktar)
                .HasColumnType("datetime")
                .HasColumnName("sonhrktar");
            entity.Property(e => e.Soyad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("soyad");
            entity.Property(e => e.Tcno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tcno");
            entity.Property(e => e.Tel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.TicSicilNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Toplamlimit)
                .HasDefaultValue(0.0)
                .HasColumnName("toplamlimit");
            entity.Property(e => e.Toplamteminat)
                .HasDefaultValue(0.0)
                .HasColumnName("toplamteminat");
            entity.Property(e => e.TtsBayVadFark).HasDefaultValue(0.0);
            entity.Property(e => e.TtsBayisk).HasDefaultValue(0.0);
            entity.Property(e => e.TtsDagVadFark).HasDefaultValue(0.0);
            entity.Property(e => e.TtsDagisk).HasDefaultValue(0.0);
            entity.Property(e => e.TtsNakit)
                .HasDefaultValue(false)
                .HasColumnName("TTS_Nakit");
            entity.Property(e => e.TtsOdeTip)
                .HasDefaultValue(2)
                .HasColumnName("TTS_OdeTip");
            entity.Property(e => e.TurId).HasDefaultValue(1);
            entity.Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("unvan");
            entity.Property(e => e.VadeOpsiyonGun)
                .HasDefaultValue(30)
                .HasColumnName("Vade_OpsiyonGun");
            entity.Property(e => e.VergiEposta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vergidaire");
            entity.Property(e => e.Vergikimlikno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("vergikimlikno");
            entity.Property(e => e.Vergino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vergino");
            entity.Property(e => e.Web).HasDefaultValue(false);
            entity.Property(e => e.WebAvans).HasDefaultValue(false);
            entity.Property(e => e.WebCariBakiye).HasDefaultValue(false);
            entity.Property(e => e.WebCariHrk).HasDefaultValue(false);
            entity.Property(e => e.WebFatura).HasDefaultValue(false);
            entity.Property(e => e.WebFaturaIskontoluTahsil).HasDefaultValue(false);
            entity.Property(e => e.WebFaturaOdendi).HasDefaultValue(false);
            entity.Property(e => e.WebFaturaTahsil).HasDefaultValue(false);
            entity.Property(e => e.WebFis).HasDefaultValue(false);
            entity.Property(e => e.WebFisIskontoluTahsil).HasDefaultValue(false);
            entity.Property(e => e.WebFisOdendi).HasDefaultValue(false);
            entity.Property(e => e.WebFisTahsil).HasDefaultValue(false);
            entity.Property(e => e.WebPos).HasDefaultValue(false);
            entity.Property(e => e.Webadres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("webadres");
            entity.Property(e => e.Webextre)
                .HasDefaultValue(false)
                .HasColumnName("webextre");
            entity.Property(e => e.YktAlmDefNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ykt_alm_def_no");
        });

        modelBuilder.Entity<Cariteminat1>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod }).HasName("PK__caritemi__DFEE66863285D601");

            entity.ToTable("cariteminat", tb =>
                {
                    tb.HasTrigger("cariteminat_log_trd");
                    tb.HasTrigger("cariteminat_log_tri");
                    tb.HasTrigger("cariteminat_log_tru");
                    tb.HasTrigger("cariteminat_trd");
                    tb.HasTrigger("cariteminat_triu");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Tip)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Tur)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tur");
            entity.Property(e => e.Tutar).HasColumnName("tutar");
        });

        modelBuilder.Entity<Cariteminattip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__caritemi__3213E83F4DA80363");

            entity.ToTable("cariteminattip");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Kod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("kod");
        });

        modelBuilder.Entity<CekKarne>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CekKarne__3213E83F1D37BDB8");

            entity.ToTable("CekKarne");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BankId).HasColumnName("Bank_id");
            entity.Property(e => e.BankKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Bank_kod");
            entity.Property(e => e.CekSeriNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Drm).HasDefaultValue(1);
            entity.Property(e => e.Firmano).HasDefaultValue(0);
            entity.Property(e => e.Sil).HasDefaultValue(false);
        });

        modelBuilder.Entity<Cekhrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Cekid, e.Sil }).HasName("PK__cekhrk__9E5BBA1BF3031C02");

            entity.ToTable("cekhrk", tb =>
                {
                    tb.HasTrigger("cekhrk_log_trd");
                    tb.HasTrigger("cekhrk_log_tri");
                    tb.HasTrigger("cekhrk_log_tru");
                    tb.HasTrigger("cekhrk_tri");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Cekid).HasColumnName("cekid");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Aktif).HasDefaultValue(false);
            entity.Property(e => e.Belno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Drmad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("drmad");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Gctip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gctip");
            entity.Property(e => e.Gidkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("gidkod");
            entity.Property(e => e.Gidtutar)
                .HasDefaultValue(0.0)
                .HasColumnName("gidtutar");
            entity.Property(e => e.HrkNo)
                .HasDefaultValue(0)
                .HasColumnName("hrk_no");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Tahcarkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tahcarkod");
            entity.Property(e => e.Tahcartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tahcartip");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Tutar)
                .HasDefaultValue(0.0)
                .HasColumnName("tutar");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Cekkart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Islmtip, e.Cekid }).HasName("PK__cekkart__408AE7E5A306C0F7");

            entity.ToTable("cekkart", tb =>
                {
                    tb.HasTrigger("cekkart_log_trd");
                    tb.HasTrigger("cekkart_log_tri");
                    tb.HasTrigger("cekkart_log_tru");
                    tb.HasTrigger("cekkart_trd");
                    tb.HasTrigger("cekkart_tri");
                    tb.HasTrigger("cekkart_tru");
                });

            entity.HasIndex(e => e.Refno, "cekkart_uq_refno").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Cekid).HasColumnName("cekid");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Adaid)
                .HasDefaultValue(0)
                .HasColumnName("adaid");
            entity.Property(e => e.Banka)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("banka");
            entity.Property(e => e.Bankod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("bankod");
            entity.Property(e => e.Banksub)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("banksub");
            entity.Property(e => e.Belno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.CekSeriNoId).HasColumnName("CekSeriNo_id");
            entity.Property(e => e.Cekkaskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cekkaskod");
            entity.Property(e => e.Ceksenno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ceksenno");
            entity.Property(e => e.Cikan)
                .HasDefaultValue(0.0)
                .HasColumnName("cikan");
            entity.Property(e => e.Cirotar)
                .HasColumnType("datetime")
                .HasColumnName("cirotar");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Devir)
                .HasDefaultValue(false)
                .HasColumnName("devir");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Drmad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("drmad");
            entity.Property(e => e.Eltahtar)
                .HasColumnType("datetime")
                .HasColumnName("eltahtar");
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.Firmaid).HasColumnName("firmaid");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0.0)
                .HasColumnName("firmano");
            entity.Property(e => e.Fisfatid)
                .HasDefaultValue(0.0)
                .HasColumnName("fisfatid");
            entity.Property(e => e.Fisfattip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("KENDI")
                .HasColumnName("fisfattip");
            entity.Property(e => e.Fisid).HasColumnName("fisid");
            entity.Property(e => e.Gctip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gctip");
            entity.Property(e => e.Geraltar)
                .HasColumnType("datetime")
                .HasColumnName("geraltar");
            entity.Property(e => e.Gidkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("gidkod");
            entity.Property(e => e.Gidtutar)
                .HasDefaultValue(0.0)
                .HasColumnName("gidtutar");
            entity.Property(e => e.Giren)
                .HasDefaultValue(0.0)
                .HasColumnName("giren");
            entity.Property(e => e.Hesepno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hesepno");
            entity.Property(e => e.Hrkid)
                .HasDefaultValue(0.0)
                .HasColumnName("hrkid");
            entity.Property(e => e.Iadetar)
                .HasColumnType("datetime")
                .HasColumnName("iadetar");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmhrkad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmhrkad");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.Kesideci)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("kesideci");
            entity.Property(e => e.Kur)
                .HasDefaultValue(0.0)
                .HasColumnName("kur");
            entity.Property(e => e.Masterid)
                .HasDefaultValue(0.0)
                .HasColumnName("masterid");
            entity.Property(e => e.Odetar)
                .HasColumnType("datetime")
                .HasColumnName("odetar");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Perkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Pro)
                .HasDefaultValue(1)
                .HasColumnName("pro");
            entity.Property(e => e.Refno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("refno");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Sonuc)
                .HasDefaultValue(0)
                .HasColumnName("sonuc");
            entity.Property(e => e.SonucTarih)
                .HasColumnType("datetime")
                .HasColumnName("Sonuc_Tarih");
            entity.Property(e => e.Tahcarkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tahcarkod");
            entity.Property(e => e.Tahcartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tahcartip");
            entity.Property(e => e.Tahodeid).HasColumnName("tahodeid");
            entity.Property(e => e.Taktahtar)
                .HasColumnType("datetime")
                .HasColumnName("taktahtar");
            entity.Property(e => e.Takvertar)
                .HasColumnType("datetime")
                .HasColumnName("takvertar");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Vadetar)
                .HasColumnType("datetime")
                .HasColumnName("vadetar");
            entity.Property(e => e.Varno)
                .HasDefaultValue(0.0)
                .HasColumnName("varno");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
            entity.Property(e => e.VercarId).HasColumnName("vercar_id");
            entity.Property(e => e.Vercarkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vercarkod");
            entity.Property(e => e.Vercartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vercartip");
            entity.Property(e => e.VercartipId).HasColumnName("vercartip_id");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Cektip>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cektip");

            entity.Property(e => e.Ad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
        });

        modelBuilder.Entity<DagitimFirma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__dagitim___3213E83FE4CB527A");

            entity.ToTable("dagitim_Firma");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
        });

        modelBuilder.Entity<DepoKartListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Depo_Kart_Listesi");

            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Bagak)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bagak");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.Tip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.TipId).HasColumnName("Tip_id");
            entity.Property(e => e.TipId1)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("TipID");
            entity.Property(e => e.Tipad)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("tipad");
        });

        modelBuilder.Entity<Depokart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod, e.Sil }).HasName("PK__depokart__E033B95B8B154C29");

            entity.ToTable("depokart", tb =>
                {
                    tb.HasTrigger("depokart_log_trd");
                    tb.HasTrigger("depokart_log_tri");
                    tb.HasTrigger("depokart_log_tru");
                    tb.HasTrigger("depokart_tri");
                    tb.HasTrigger("depokart_tru");
                });

            entity.HasIndex(e => e.Kod, "depokart_uq").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Deptip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("deptip");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.TipId)
                .HasDefaultValue(2)
                .HasColumnName("Tip_id");
        });

        modelBuilder.Entity<EbelgeEntegrator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EBelge_Entegrator");

            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.WebServis)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EbelgeSeri>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EBelge_S__3214EC07A5D08FBE");

            entity.ToTable("EBelge_Seri");

            entity.Property(e => e.DegTarSaat).HasColumnType("datetime");
            entity.Property(e => e.DegUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EbelgeTipId)
                .HasDefaultValue(1)
                .HasColumnName("EBelgeTipId");
            entity.Property(e => e.EntegratorBayiNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.EntegratorSeri)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.OlusTarSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
        });

        modelBuilder.Entity<EbelgeTip>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EBelge_Tip");

            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
        });

        modelBuilder.Entity<EfaturaBrm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EFatura_Brm");

            entity.Property(e => e.Ad)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EfaturaGelen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EFatura___3214EC07B6E65636");

            entity.ToTable("EFatura_Gelen");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AktarTarSaat).HasColumnType("datetime");
            entity.Property(e => e.AktarUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BelgeNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CarId).HasColumnName("Car_Id");
            entity.Property(e => e.CarTipId).HasColumnName("CarTip_Id");
            entity.Property(e => e.DepoTipId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DepoTipID");
            entity.Property(e => e.Durum)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DurumHata)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.EfaturaTip).HasColumnName("EFaturaTip");
            entity.Property(e => e.EntegreId).HasDefaultValue(0);
            entity.Property(e => e.EntegreTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.GenelIskToplam).HasDefaultValue(0.0);
            entity.Property(e => e.GenelKdvToplam).HasDefaultValue(0.0);
            entity.Property(e => e.GenelOtvToplam).HasDefaultValue(0.0);
            entity.Property(e => e.GenelToplam).HasDefaultValue(0.0);
            entity.Property(e => e.Guid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GUID");
            entity.Property(e => e.IrsaliyeIdIn)
                .HasMaxLength(800)
                .IsUnicode(false);
            entity.Property(e => e.OlusTarSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RapId).HasColumnName("Rap_Id");
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
            entity.Property(e => e.Tcvknno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TCVKNNo");
            entity.Property(e => e.Tcvkntip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TCVKNTip");
            entity.Property(e => e.Tip)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Tur)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Unvan)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.VadeTarih).HasColumnType("datetime");
        });

        modelBuilder.Entity<EfaturaGelenHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EFatura___3214EC070AB1DF56");

            entity.ToTable("EFatura_Gelen_Hrk");

            entity.Property(e => e.Ad)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Barkod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Birim)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Carpan).HasDefaultValue(1.0);
            entity.Property(e => e.DegTarSaat).HasColumnType("datetime");
            entity.Property(e => e.DegUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DepoTipId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DepoTipID");
            entity.Property(e => e.EfatId).HasColumnName("EFatId");
            entity.Property(e => e.EfaturaBirim)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EFaturaBirim");
            entity.Property(e => e.EfaturaFiyat)
                .HasDefaultValue(0.0)
                .HasColumnName("EFaturaFiyat");
            entity.Property(e => e.EfaturaMiktar)
                .HasDefaultValue(0.0)
                .HasColumnName("EFaturaMiktar");
            entity.Property(e => e.IskYuz).HasDefaultValue(0.0);
            entity.Property(e => e.KdvYuz).HasDefaultValue(0.0);
            entity.Property(e => e.Kesafet).HasDefaultValue(1.0);
            entity.Property(e => e.OlusTarSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.StkId).HasColumnName("Stk_Id");
            entity.Property(e => e.StkTip)
                .HasDefaultValue(2)
                .HasColumnName("Stk_Tip");
            entity.Property(e => e.StkUniqueId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Stk_UniqueId");
        });

        modelBuilder.Entity<EfaturaTip>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EFatura_Tip");

            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.WebServis)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Emtiasat>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno, e.Emtid }).HasName("PK__emtiasat__5B9C90C9D1CCE6F7");

            entity.ToTable("emtiasat", tb =>
                {
                    tb.HasTrigger("emtiasat_log_trd");
                    tb.HasTrigger("emtiasat_log_tri");
                    tb.HasTrigger("emtiasat_log_tru");
                    tb.HasTrigger("emtiasat_trd");
                    tb.HasTrigger("emtiasat_tri");
                    tb.HasTrigger("emtiasat_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Emtid).HasColumnName("emtid");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Adaid).HasColumnName("adaid");
            entity.Property(e => e.Belno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.Brmfiy).HasColumnName("brmfiy");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Depkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.FisId).HasColumnName("Fis_id");
            entity.Property(e => e.GecPerKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Gec_PerKod");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.Kdvyuz).HasColumnName("kdvyuz");
            entity.Property(e => e.Mik).HasColumnName("mik");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.StkId).HasColumnName("stk_id");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.StktipId).HasColumnName("stktip_id");
            entity.Property(e => e.Stktipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stktipad");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Tutar).HasColumnName("tutar");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Entegre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Entegre__3213E83FA94A41C9");

            entity.ToTable("Entegre");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Beg)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("beg");
            entity.Property(e => e.Dataname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("dataname");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Host)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("host");
            entity.Property(e => e.Pass)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("pass");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Users)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("users");
        });

        modelBuilder.Entity<EntegreMuhHesKod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__entegre___3213E83FB046565D");

            entity.ToTable("entegre_muh_hes_kod");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Deger)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("deger");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.KdvOran).HasColumnName("kdv_oran");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
        });

        modelBuilder.Entity<Epostaayar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("epostaayar");

            entity.Property(e => e.Alad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("alad");
            entity.Property(e => e.Alposta)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("alposta");
            entity.Property(e => e.Gonad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("gonad");
            entity.Property(e => e.Gonposta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("gonposta");
            entity.Property(e => e.Host)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("host");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Kulkod)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("kulkod");
            entity.Property(e => e.PostaGidenPort).HasDefaultValue(587);
            entity.Property(e => e.PostaSifreleme).HasDefaultValue(0);
            entity.Property(e => e.Sif)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sif");
            entity.Property(e => e.SmsAliciCepno)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("sms_alici_cepno");
            entity.Property(e => e.SmsFirmaKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sms_firma_kod");
            entity.Property(e => e.SmsKulKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sms_kul_kod");
            entity.Property(e => e.SmsSifre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sms_sifre");
            entity.Property(e => e.SmsSunucu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("sms_sunucu");
            entity.Property(e => e.SmsTip).HasColumnName("sms_tip");
        });

        modelBuilder.Entity<EvrakNot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Evrak_No__3213E83F61800409");

            entity.ToTable("Evrak_Not");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Firmano).HasDefaultValue(0);
            entity.Property(e => e.MasId).HasColumnName("mas_id");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sil)
                .HasDefaultValue(false)
                .HasColumnName("sil");
            entity.Property(e => e.TableAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Table_Ad");
        });

        modelBuilder.Entity<FatDep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fat_Dep__3213E83FC6289252");

            entity.ToTable("Fat_Dep");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Belno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cdepkod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cfirmano).HasColumnName("cfirmano");
            entity.Property(e => e.CstkId).HasColumnName("CStk_id");
            entity.Property(e => e.CstkKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CStk_kod");
            entity.Property(e => e.Cstktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CStktip");
            entity.Property(e => e.CstktipId).HasColumnName("CStktip_id");
            entity.Property(e => e.FatHrkId).HasColumnName("FatHrk_id");
            entity.Property(e => e.Gdepkod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gfirmano).HasColumnName("gfirmano");
            entity.Property(e => e.GstkId).HasColumnName("GStk_id");
            entity.Property(e => e.GstkKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GStk_kod");
            entity.Property(e => e.Gstktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GStktip");
            entity.Property(e => e.GstktipId).HasColumnName("GStktip_id");
            entity.Property(e => e.Miktar).HasDefaultValue(0.0);
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue((byte)0);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
            entity.Property(e => e.Yerad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Yertip)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FatGrsAlanTip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fat_Grs___3213E83F2FABE6DB");

            entity.ToTable("Fat_Grs_Alan_Tip");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AckAl)
                .HasMaxLength(400)
                .HasColumnName("ack_al");
            entity.Property(e => e.AckEn)
                .HasMaxLength(400)
                .HasColumnName("ack_en");
            entity.Property(e => e.AckRu)
                .HasMaxLength(400)
                .HasColumnName("ack_ru");
            entity.Property(e => e.AckTr)
                .HasMaxLength(400)
                .HasColumnName("ack_tr");
            entity.Property(e => e.TipId).HasColumnName("tip_id");
        });

        modelBuilder.Entity<Fattip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__fattip__3213E83F87D526FF");

            entity.ToTable("fattip");

            entity.HasIndex(e => e.Kod, "UQ__fattip__0D5AD24C").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .HasColumnName("ad");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Gc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gc");
            entity.Property(e => e.Gctip).HasColumnName("gctip");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Tip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.TurId).HasColumnName("tur_id");
        });

        modelBuilder.Entity<FaturaIadeDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tasiyici__3213E83F5920D841_IadeFaturaDetay");

            entity.ToTable("FaturaIadeDetay");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BelgeNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.FatId).HasDefaultValue(0);
            entity.Property(e => e.OlusturmaKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.RemoteId).HasDefaultValue(0);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Tarih).HasColumnType("datetime");
        });

        modelBuilder.Entity<FaturaTur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fatura_T__3213E83FE6E1731E");

            entity.ToTable("Fatura_Tur");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AckAl)
                .HasMaxLength(50)
                .HasColumnName("ack_al");
            entity.Property(e => e.AckEn)
                .HasMaxLength(50)
                .HasColumnName("ack_en");
            entity.Property(e => e.AckRu)
                .HasMaxLength(50)
                .HasColumnName("ack_ru");
            entity.Property(e => e.AckTr)
                .HasMaxLength(50)
                .HasColumnName("ack_tr");
        });

        modelBuilder.Entity<Faturagiderlistesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("faturagiderlistesi");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kdv).HasColumnName("kdv");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Tutar).HasColumnName("tutar");
        });

        modelBuilder.Entity<Faturahrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Fatid }).HasName("PK__faturahr__D918C0DEB990ED93");

            entity.ToTable("faturahrk", tb =>
                {
                    tb.HasTrigger("faturahrk_log_trd");
                    tb.HasTrigger("faturahrk_log_tri");
                    tb.HasTrigger("faturahrk_log_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.Ack)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.AkIskTut).HasColumnName("ak_isk_tut");
            entity.Property(e => e.AkIskYuz).HasColumnName("ak_isk_yuz");
            entity.Property(e => e.Barkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("barkod");
            entity.Property(e => e.Brim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Brmfiy).HasColumnName("brmfiy");
            entity.Property(e => e.Carpan)
                .HasDefaultValue(1.0)
                .HasColumnName("carpan");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.DepId).HasColumnName("dep_id");
            entity.Property(e => e.Depkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Genisktut)
                .HasDefaultValue(0.0)
                .HasColumnName("genisktut");
            entity.Property(e => e.Geniskyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("geniskyuz");
            entity.Property(e => e.GgIskTut).HasColumnName("gg_isk_tut");
            entity.Property(e => e.GgIskYuz).HasColumnName("gg_isk_yuz");
            entity.Property(e => e.Giderbrmtut)
                .HasDefaultValue(0.0)
                .HasColumnName("giderbrmtut");
            entity.Property(e => e.Grupid)
                .HasDefaultValue(0)
                .HasColumnName("grupid");
            entity.Property(e => e.HrkStkPro).HasColumnName("hrk_stk_pro");
            entity.Property(e => e.IslemKur).HasColumnName("Islem_Kur");
            entity.Property(e => e.IslemParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Islem_ParaBrm");
            entity.Property(e => e.Kaphrkid)
                .HasDefaultValue(0.0)
                .HasColumnName("kaphrkid");
            entity.Property(e => e.Kaptip)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("FAT")
                .HasColumnName("kaptip");
            entity.Property(e => e.KartKur).HasColumnName("Kart_Kur");
            entity.Property(e => e.KartParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kart_ParaBrm");
            entity.Property(e => e.Kayok)
                .HasDefaultValue(0)
                .HasColumnName("kayok");
            entity.Property(e => e.KdvTevkifatId).HasDefaultValue(0);
            entity.Property(e => e.KdvTevkifatTutar).HasDefaultValue(0.0);
            entity.Property(e => e.KdvTevkifatYuzde).HasDefaultValue(0.0);
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Hayır")
                .HasColumnName("kdvtip");
            entity.Property(e => e.Kdvtut).HasColumnName("kdvtut");
            entity.Property(e => e.Kdvyuz).HasColumnName("kdvyuz");
            entity.Property(e => e.Kesafet)
                .HasDefaultValue(0.0)
                .HasColumnName("kesafet");
            entity.Property(e => e.Kur)
                .HasDefaultValue(1.0)
                .HasColumnName("kur");
            entity.Property(e => e.MasrafTut).HasColumnName("masraf_tut");
            entity.Property(e => e.MasrafYuz).HasColumnName("masraf_yuz");
            entity.Property(e => e.Mik).HasColumnName("mik");
            entity.Property(e => e.MrIskTut).HasColumnName("mr_isk_tut");
            entity.Property(e => e.MrIskYuz).HasColumnName("mr_isk_yuz");
            entity.Property(e => e.NetMiktar)
                .HasDefaultValue(0.0)
                .HasColumnName("Net_Miktar");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.OtvCarpan)
                .HasDefaultValue(0.0)
                .HasColumnName("Otv_Carpan");
            entity.Property(e => e.Otvbrim)
                .HasDefaultValue(0.0)
                .HasColumnName("otvbrim");
            entity.Property(e => e.Otvtut)
                .HasDefaultValue(0.0)
                .HasColumnName("otvtut");
            entity.Property(e => e.Otvyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("otvyuz");
            entity.Property(e => e.Parabrim)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrim");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0L)
                .HasColumnName("remote_id");
            entity.Property(e => e.Satisktip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("%")
                .HasColumnName("satisktip");
            entity.Property(e => e.Satisktut)
                .HasDefaultValue(0.0)
                .HasColumnName("satisktut");
            entity.Property(e => e.Satiskyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("satiskyuz");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0.0)
                .HasColumnName("sil");
            entity.Property(e => e.StkId).HasColumnName("stk_id");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.StktipId).HasColumnName("stktip_id");
            entity.Property(e => e.TesisAlisFiyat)
                .HasDefaultValue(0.0)
                .HasColumnName("Tesis_AlisFiyat");
            entity.Property(e => e.TesisFiyat)
                .HasDefaultValue(false)
                .HasColumnName("Tesis_Fiyat");
            entity.Property(e => e.TesisId)
                .HasDefaultValue(0)
                .HasColumnName("Tesis_id");
            entity.Property(e => e.TesisPrimOran)
                .HasDefaultValue(0.0)
                .HasColumnName("Tesis_PrimOran");
            entity.Property(e => e.TopIskTut)
                .HasDefaultValue(0.0)
                .HasColumnName("top_isk_tut");
            entity.Property(e => e.TopIskYuz)
                .HasDefaultValue(0.0)
                .HasColumnName("top_isk_yuz");
            entity.Property(e => e.TopKdvTut)
                .HasDefaultValue(0.0)
                .HasColumnName("top_kdv_tut");
            entity.Property(e => e.TopTutIskKdvli)
                .HasDefaultValue(0.0)
                .HasColumnName("top_tut_isk_kdvli");
            entity.Property(e => e.TopTutIskKdvsiz).HasColumnName("top_tut_isk_kdvsiz");
            entity.Property(e => e.TopTutKdvsiz)
                .HasDefaultValue(0.0)
                .HasColumnName("top_tut_kdvsiz");
            entity.Property(e => e.Ustbrim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ustbrim");
        });

        modelBuilder.Entity<FaturahrkTemp>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Fatid }).HasName("PK__faturahr__D918C0DE6B4C5DD9");

            entity.ToTable("faturahrk_temp");

            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.AkIskTut).HasColumnName("ak_isk_tut");
            entity.Property(e => e.AkIskYuz).HasColumnName("ak_isk_yuz");
            entity.Property(e => e.Brim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Brmfiy).HasColumnName("brmfiy");
            entity.Property(e => e.Carpan).HasColumnName("carpan");
            entity.Property(e => e.Dataok).HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Depkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Genisktut).HasColumnName("genisktut");
            entity.Property(e => e.Geniskyuz).HasColumnName("geniskyuz");
            entity.Property(e => e.Giderbrmtut).HasColumnName("giderbrmtut");
            entity.Property(e => e.Grupid).HasColumnName("grupid");
            entity.Property(e => e.HrkStkPro).HasColumnName("hrk_stk_pro");
            entity.Property(e => e.Kaphrkid).HasColumnName("kaphrkid");
            entity.Property(e => e.Kaptip)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("kaptip");
            entity.Property(e => e.Kayok).HasColumnName("kayok");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Kdvtut).HasColumnName("kdvtut");
            entity.Property(e => e.Kdvyuz).HasColumnName("kdvyuz");
            entity.Property(e => e.Kesafet).HasColumnName("kesafet");
            entity.Property(e => e.Kur).HasColumnName("kur");
            entity.Property(e => e.Mik).HasColumnName("mik");
            entity.Property(e => e.MrIskTut).HasColumnName("mr_isk_tut");
            entity.Property(e => e.MrIskYuz).HasColumnName("mr_isk_yuz");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otvbrim).HasColumnName("otvbrim");
            entity.Property(e => e.Otvtut).HasColumnName("otvtut");
            entity.Property(e => e.Otvyuz).HasColumnName("otvyuz");
            entity.Property(e => e.Parabrim)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrim");
            entity.Property(e => e.Satisktut).HasColumnName("satisktut");
            entity.Property(e => e.Satiskyuz).HasColumnName("satiskyuz");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.Ustbrim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ustbrim");
        });

        modelBuilder.Entity<Faturahrklistesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("faturahrklistesi");

            entity.Property(e => e.AkIskTut).HasColumnName("ak_isk_tut");
            entity.Property(e => e.AkIskYuz).HasColumnName("ak_isk_yuz");
            entity.Property(e => e.Brim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Brmfiy).HasColumnName("brmfiy");
            entity.Property(e => e.Carpan).HasColumnName("carpan");
            entity.Property(e => e.Depkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Genisktut).HasColumnName("genisktut");
            entity.Property(e => e.Geniskyuz).HasColumnName("geniskyuz");
            entity.Property(e => e.Giderbrmtut).HasColumnName("giderbrmtut");
            entity.Property(e => e.Grupid).HasColumnName("grupid");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kaphrkid).HasColumnName("kaphrkid");
            entity.Property(e => e.Kaptip)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("kaptip");
            entity.Property(e => e.Kayok).HasColumnName("kayok");
            entity.Property(e => e.KdvtevkifatAck)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("kdvtevkifatAck");
            entity.Property(e => e.KdvtevkifatKod)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("kdvtevkifatKod");
            entity.Property(e => e.KdvtevkifatTutar).HasColumnName("kdvtevkifatTutar");
            entity.Property(e => e.KdvtevkifatYuzde).HasColumnName("kdvtevkifatYuzde");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Kdvtut).HasColumnName("kdvtut");
            entity.Property(e => e.Kdvyuz).HasColumnName("kdvyuz");
            entity.Property(e => e.MicroStktip).HasColumnName("Micro_Stktip");
            entity.Property(e => e.Mik).HasColumnName("mik");
            entity.Property(e => e.MrIskTut).HasColumnName("mr_isk_tut");
            entity.Property(e => e.MrIskYuz).HasColumnName("mr_isk_yuz");
            entity.Property(e => e.OtvCarpan).HasColumnName("otv_carpan");
            entity.Property(e => e.Otvbrim).HasColumnName("otvbrim");
            entity.Property(e => e.Otvtut).HasColumnName("otvtut");
            entity.Property(e => e.Otvyuz).HasColumnName("otvyuz");
            entity.Property(e => e.Parabrim)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrim");
            entity.Property(e => e.Satirtip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("satirtip");
            entity.Property(e => e.Satisktut).HasColumnName("satisktut");
            entity.Property(e => e.Satiskyuz).HasColumnName("satiskyuz");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.TopIskTut).HasColumnName("Top_isk_Tut");
            entity.Property(e => e.TopIskYuz).HasColumnName("Top_isk_Yuz");
            entity.Property(e => e.Ustbrim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ustbrim");
        });

        modelBuilder.Entity<Faturama>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Fatid }).HasName("PK__faturama__D918C0DECE3B3CA6");

            entity.ToTable("faturamas", tb =>
                {
                    tb.HasTrigger("faturamas_log_trd");
                    tb.HasTrigger("faturamas_log_tri");
                    tb.HasTrigger("faturamas_log_tru");
                    tb.HasTrigger("faturamas_trd");
                    tb.HasTrigger("faturamas_tru");
                });

            entity.HasIndex(e => new { e.Firmano, e.Fatid, e.Fatseri, e.Fatno, e.Sil }, "faturamas_FirmaSeriNo_index");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.Ack)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.AkIskTip).HasColumnName("ak_isk_tip");
            entity.Property(e => e.AkIskTop).HasColumnName("ak_isk_top");
            entity.Property(e => e.AkIskYuz).HasColumnName("ak_isk_yuz");
            entity.Property(e => e.AkMatrah).HasColumnName("ak_matrah");
            entity.Property(e => e.AvansTakip).HasDefaultValue(false);
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.DepDag)
                .HasDefaultValue(false)
                .HasColumnName("Dep_Dag");
            entity.Property(e => e.Depo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("depo");
            entity.Property(e => e.EbelgeEntegrasyonId)
                .HasDefaultValue(0)
                .HasColumnName("EBelgeEntegrasyonId");
            entity.Property(e => e.EbelgeGibSeriNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EBelgeGibSeriNo");
            entity.Property(e => e.EbelgeMailTarihSaat)
                .HasColumnType("datetime")
                .HasColumnName("EBelgeMailTarihSaat");
            entity.Property(e => e.EbelgeSeriId)
                .HasDefaultValue(0)
                .HasColumnName("EBelgeSeriId");
            entity.Property(e => e.EbelgeTipId)
                .HasDefaultValue(0)
                .HasColumnName("EBelgeTipId");
            entity.Property(e => e.Efatura).HasColumnName("EFatura");
            entity.Property(e => e.EfaturaAktar)
                .HasColumnType("datetime")
                .HasColumnName("Efatura_Aktar");
            entity.Property(e => e.EfaturaEfinansBelgeOid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EFaturaEFinansBelgeOId");
            entity.Property(e => e.EfaturaId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EFatura_Id");
            entity.Property(e => e.EfaturaTip).HasColumnName("EFatura_Tip");
            entity.Property(e => e.Entegre).HasDefaultValue(false);
            entity.Property(e => e.EntegreAktar)
                .HasColumnType("datetime")
                .HasColumnName("entegre_aktar");
            entity.Property(e => e.EntegreTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("entegre_tip");
            entity.Property(e => e.Fatad)
                .HasMaxLength(50)
                .HasColumnName("fatad");
            entity.Property(e => e.Fatno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fatno");
            entity.Property(e => e.FatrapId).HasColumnName("fatrap_id");
            entity.Property(e => e.Fatseri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fatseri");
            entity.Property(e => e.Fattip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fattip");
            entity.Property(e => e.FattipId).HasColumnName("fattip_id");
            entity.Property(e => e.Fattop)
                .HasDefaultValue(0.0)
                .HasColumnName("fattop");
            entity.Property(e => e.Fattur)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fattur");
            entity.Property(e => e.FatturId).HasColumnName("fattur_id");
            entity.Property(e => e.Fatturad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fatturad");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Gctip).HasColumnName("gctip");
            entity.Property(e => e.GenIndTip).HasColumnName("gen_ind_tip");
            entity.Property(e => e.GenelAraTop).HasColumnName("genel_ara_top");
            entity.Property(e => e.GenelIskTop).HasColumnName("genel_isk_top");
            entity.Property(e => e.GenelKdvTevkifatTop)
                .HasDefaultValue(0.0)
                .HasColumnName("genel_kdv_tevkifat_top");
            entity.Property(e => e.GenelKdvTop).HasColumnName("genel_kdv_top");
            entity.Property(e => e.GenelNetTop).HasColumnName("genel_net_top");
            entity.Property(e => e.GenelTop).HasColumnName("genel_top");
            entity.Property(e => e.Genisktop)
                .HasDefaultValue(0.0)
                .HasColumnName("genisktop");
            entity.Property(e => e.Geniskyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("geniskyuz");
            entity.Property(e => e.GgIskTip).HasColumnName("gg_isk_tip");
            entity.Property(e => e.GgIskTop).HasColumnName("gg_isk_top");
            entity.Property(e => e.GgIskYuz).HasColumnName("gg_isk_yuz");
            entity.Property(e => e.GgMatrah).HasColumnName("gg_matrah");
            entity.Property(e => e.Giderkdvtop)
                .HasDefaultValue(0.0)
                .HasColumnName("giderkdvtop");
            entity.Property(e => e.Gidertop)
                .HasDefaultValue(0.0)
                .HasColumnName("gidertop");
            entity.Property(e => e.GnMatrah).HasColumnName("gn_matrah");
            entity.Property(e => e.HrkCarPro).HasColumnName("hrk_car_pro");
            entity.Property(e => e.HrkKarsiPro)
                .HasDefaultValue(false)
                .HasColumnName("Hrk_Karsi_Pro");
            entity.Property(e => e.HrkStkPro).HasColumnName("hrk_stk_pro");
            entity.Property(e => e.IrsNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("irs_no");
            entity.Property(e => e.Irsaliyeirid).HasColumnName("irsaliyeirid");
            entity.Property(e => e.IskTip).HasColumnName("isk_tip");
            entity.Property(e => e.IslemKur).HasColumnName("Islem_Kur");
            entity.Property(e => e.IslemParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Islem_ParaBrm");
            entity.Property(e => e.Kapidler)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("kapidler");
            entity.Property(e => e.Kaptip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("FAT")
                .HasColumnName("kaptip");
            entity.Property(e => e.KarsiCarId).HasColumnName("Karsi_Car_id");
            entity.Property(e => e.KarsiCartipId).HasColumnName("Karsi_Cartip_id");
            entity.Property(e => e.KartKur).HasColumnName("Kart_Kur");
            entity.Property(e => e.KartParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kart_ParaBrm");
            entity.Property(e => e.Kayok)
                .HasDefaultValue(0)
                .HasColumnName("kayok");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Kdvtop)
                .HasDefaultValue(0.0)
                .HasColumnName("kdvtop");
            entity.Property(e => e.Kilit).HasColumnName("kilit");
            entity.Property(e => e.Kur)
                .HasDefaultValue(1.0)
                .HasColumnName("kur");
            entity.Property(e => e.Marsatid)
                .HasDefaultValue(0.0)
                .HasColumnName("marsatid");
            entity.Property(e => e.MrIskTip).HasColumnName("mr_isk_tip");
            entity.Property(e => e.MrIskTop).HasColumnName("mr_isk_top");
            entity.Property(e => e.MrIskYuz).HasColumnName("mr_isk_yuz");
            entity.Property(e => e.MrMatrah).HasColumnName("mr_matrah");
            entity.Property(e => e.Odeme).HasDefaultValue(false);
            entity.Property(e => e.Odemetop)
                .HasDefaultValue(0.0)
                .HasColumnName("odemetop");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otvtop)
                .HasDefaultValue(0.0)
                .HasColumnName("otvtop");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.PerId)
                .HasDefaultValue(0)
                .HasColumnName("Per_id");
            entity.Property(e => e.Plaka)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plaka");
            entity.Property(e => e.PromPro).HasColumnName("prom_pro");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0L)
                .HasColumnName("remote_id");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Satisktop)
                .HasDefaultValue(0.0)
                .HasColumnName("satisktop");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Siparissipid).HasColumnName("siparissipid");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Vadtar)
                .HasColumnType("datetime")
                .HasColumnName("vadtar");
            entity.Property(e => e.Yazildi).HasColumnName("yazildi");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
            entity.Property(e => e.Ykfisno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ykfisno");
            entity.Property(e => e.Yuvtop)
                .HasDefaultValue(0.0)
                .HasColumnName("yuvtop");
        });

        modelBuilder.Entity<FaturamasTemp>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Fatid }).HasName("PK__faturama__D918C0DE840AE63C");

            entity.ToTable("faturamas_temp");

            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.Ack)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.AkIskTip).HasColumnName("ak_isk_tip");
            entity.Property(e => e.AkIskTop).HasColumnName("ak_isk_top");
            entity.Property(e => e.AkIskYuz).HasColumnName("ak_isk_yuz");
            entity.Property(e => e.AkMatrah).HasColumnName("ak_matrah");
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Dataok).HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Depo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("depo");
            entity.Property(e => e.EntegreAktar)
                .HasColumnType("datetime")
                .HasColumnName("entegre_aktar");
            entity.Property(e => e.EntegreTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("entegre_tip");
            entity.Property(e => e.Fatad)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("fatad");
            entity.Property(e => e.Fatno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fatno");
            entity.Property(e => e.Fatseri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fatseri");
            entity.Property(e => e.Fattip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fattip");
            entity.Property(e => e.Fattop).HasColumnName("fattop");
            entity.Property(e => e.Fattur)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fattur");
            entity.Property(e => e.Fatturad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fatturad");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.GenIndTip).HasColumnName("gen_ind_tip");
            entity.Property(e => e.GenelAraTop).HasColumnName("genel_ara_top");
            entity.Property(e => e.GenelIskTop).HasColumnName("genel_isk_top");
            entity.Property(e => e.GenelKdvTop).HasColumnName("genel_kdv_top");
            entity.Property(e => e.GenelTop).HasColumnName("genel_top");
            entity.Property(e => e.Genisktop).HasColumnName("genisktop");
            entity.Property(e => e.Geniskyuz).HasColumnName("geniskyuz");
            entity.Property(e => e.Giderkdvtop).HasColumnName("giderkdvtop");
            entity.Property(e => e.Gidertop).HasColumnName("gidertop");
            entity.Property(e => e.GnMatrah).HasColumnName("gn_matrah");
            entity.Property(e => e.HrkCarPro).HasColumnName("hrk_car_pro");
            entity.Property(e => e.HrkStkPro).HasColumnName("hrk_stk_pro");
            entity.Property(e => e.IrsNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("irs_no");
            entity.Property(e => e.Irsaliyeirid).HasColumnName("irsaliyeirid");
            entity.Property(e => e.IskTip).HasColumnName("isk_tip");
            entity.Property(e => e.Kapidler)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("kapidler");
            entity.Property(e => e.Kaptip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("kaptip");
            entity.Property(e => e.Kayok).HasColumnName("kayok");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Kdvtop).HasColumnName("kdvtop");
            entity.Property(e => e.Kilit).HasColumnName("kilit");
            entity.Property(e => e.Kur).HasColumnName("kur");
            entity.Property(e => e.Marsatid).HasColumnName("marsatid");
            entity.Property(e => e.MrIskTip).HasColumnName("mr_isk_tip");
            entity.Property(e => e.MrIskTop).HasColumnName("mr_isk_top");
            entity.Property(e => e.MrIskYuz).HasColumnName("mr_isk_yuz");
            entity.Property(e => e.MrMatrah).HasColumnName("mr_matrah");
            entity.Property(e => e.Odemetop).HasColumnName("odemetop");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otvtop).HasColumnName("otvtop");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Plaka)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plaka");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Satisktop).HasColumnName("satisktop");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Siparissipid).HasColumnName("siparissipid");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Vadtar)
                .HasColumnType("datetime")
                .HasColumnName("vadtar");
            entity.Property(e => e.Yazildi).HasColumnName("yazildi");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
            entity.Property(e => e.Ykfisno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ykfisno");
            entity.Property(e => e.Yuvtop).HasColumnName("yuvtop");
        });

        modelBuilder.Entity<FilitreHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Filitre___3214EC079AEF3DEB");

            entity.ToTable("Filitre_Hrk");

            entity.Property(e => e.Deger)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.DegerSorgu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Deger_Sorgu");
            entity.Property(e => e.MasId).HasColumnName("MasID");
            entity.Property(e => e.SorguStr)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("Sorgu_Str");
            entity.Property(e => e.TanId).HasColumnName("TanID");
        });

        modelBuilder.Entity<FilitreMa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Filitre___3214EC07A77C779A");

            entity.ToTable("Filitre_Mas");

            entity.Property(e => e.AlanAck)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AlanAd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DegerTip).HasColumnName("DegerTIP");
            entity.Property(e => e.GrpAd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GrpId).HasColumnName("GrpID");
            entity.Property(e => e.QueryTable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Query_Table");
            entity.Property(e => e.QueryTableSorgu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Query_Table_Sorgu");
        });

        modelBuilder.Entity<Firma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Firma__3213E83F53F47E94");

            entity.ToTable("Firma");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .HasColumnName("ad");
            entity.Property(e => e.Adres1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Adres_1");
            entity.Property(e => e.Adres2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Adres_2");
            entity.Property(e => e.BulutTahsilatEntegratorId).HasDefaultValue(0);
            entity.Property(e => e.BulutTahsilatSirketKod)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BulutTahsilatUserKod)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BulutTahsilatUserSifre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.EarsivEntegratorId)
                .HasDefaultValue(0)
                .HasColumnName("EArsiv_EntegratorId");
            entity.Property(e => e.EarsivFaturaNo)
                .HasDefaultValue(false)
                .HasColumnName("EArsiv_FaturaNo");
            entity.Property(e => e.EarsivKasa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Earsiv_Kasa");
            entity.Property(e => e.EarsivSirketKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Earsiv_SirketKod");
            entity.Property(e => e.EarsivSube)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Earsiv_Sube");
            entity.Property(e => e.EarsivUserKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Earsiv_UserKod");
            entity.Property(e => e.EarsivUserSifre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Earsiv_UserSifre");
            entity.Property(e => e.EfaturaCariKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EFatura_CariKod");
            entity.Property(e => e.EfaturaEntegratorId)
                .HasDefaultValue(0)
                .HasColumnName("EFatura_EntegratorId");
            entity.Property(e => e.EfaturaEsasBirim)
                .HasDefaultValue(1)
                .HasColumnName("EFatura_EsasBirim");
            entity.Property(e => e.EfaturaIngFaturaNo)
                .HasDefaultValue(true)
                .HasColumnName("Efatura_IngFaturaNo");
            entity.Property(e => e.EfaturaSeri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Efatura_Seri");
            entity.Property(e => e.EfaturaSirketKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Efatura_SirketKod");
            entity.Property(e => e.EfaturaTip)
                .HasDefaultValue(0)
                .HasColumnName("EFatura_Tip");
            entity.Property(e => e.EfaturaUserKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Efatura_UserKod");
            entity.Property(e => e.EfaturaUserSifre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Efatura_UserSifre");
            entity.Property(e => e.EirsaliyeEntegratorId)
                .HasDefaultValue(0)
                .HasColumnName("EIrsaliye_EntegratorId");
            entity.Property(e => e.EirsaliyeFaturaNo)
                .HasDefaultValue(false)
                .HasColumnName("EIrsaliye_FaturaNo");
            entity.Property(e => e.EirsaliyeSirketKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EIrsaliye_SirketKod");
            entity.Property(e => e.EirsaliyeUserKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EIrsaliye_UserKod");
            entity.Property(e => e.EirsaliyeUserSifre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EIrsaliye_UserSifre");
            entity.Property(e => e.EntegreBankGidMuhKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Entegre_BankGidMuhKod");
            entity.Property(e => e.EntegreBankGidOnMuhKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Entegre_BankGidOnMuhKod");
            entity.Property(e => e.EntegreDepartmanKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntegreFirmaNo)
                .HasDefaultValue(0)
                .HasColumnName("Entegre_FirmaNo");
            entity.Property(e => e.EntegreMarketKdv0OnMuhKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntegreMarketKdv18OnMuhKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntegreMarketKdv1OnMuhKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntegreMarketKdv8OnMuhKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EntegrePeriot)
                .HasDefaultValue(0)
                .HasColumnName("Entegre_Periot");
            entity.Property(e => e.EntegrePosCarMuhKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Entegre_PosCarMuhKod");
            entity.Property(e => e.EntegrePosCarOnMuhKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Entegre_PosCarOnMuhKod");
            entity.Property(e => e.EntegrePosGidMuhKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Entegre_PosGidMuhKod");
            entity.Property(e => e.EntegrePosGidOnMuhKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Entegre_PosGidOnMuhKod");
            entity.Property(e => e.EntegreSubeNo).HasColumnName("Entegre_SubeNo");
            entity.Property(e => e.EntegreTip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Entegre_Tip");
            entity.Property(e => e.EntegreUserKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Entegre_UserKod");
            entity.Property(e => e.EntegreUserSifre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Entegre_UserSifre");
            entity.Property(e => e.EntegreZraporMuhKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Entegre_ZraporMuhKod");
            entity.Property(e => e.EntegreZraporOnMuhKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Entegre_ZraporOnMuhKod");
            entity.Property(e => e.FatIskGiderKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FaxNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Fax_No");
            entity.Property(e => e.FisIskGiderKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KartAkIsle).HasColumnName("Kart_Ak_isle");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.LogoId).HasColumnName("Logo_id");
            entity.Property(e => e.MarketSatisParaBirim).HasDefaultValue(0);
            entity.Property(e => e.MarketSatisParaBirim1)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MarketSatisParaBirim2)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MarketSatisParaBirim3)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MarketSatisParaBirim4)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MarketSatisPosKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MvAckFaz)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Mv_AckFaz");
            entity.Property(e => e.MvKasa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Mv_Kasa");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.OnOtomas)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("on_otomas");
            entity.Property(e => e.PvAckFaz)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Pv_AckFaz");
            entity.Property(e => e.PvKasa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Pv_Kasa");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.TelNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Tel_No");
            entity.Property(e => e.VarOtomas)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("var_otomas");
            entity.Property(e => e.ZraporCariKod)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Fisfatodelistesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("fisfatodelistesi");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("aciklama");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Belno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.Fisfatid).HasColumnName("fisfatid");
            entity.Property(e => e.Fisfattip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("fisfattip");
            entity.Property(e => e.Grp)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("grp");
            entity.Property(e => e.Grptip)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("grptip");
            entity.Property(e => e.Hrkad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("hrkad");
            entity.Property(e => e.Hrkid).HasColumnName("hrkid");
            entity.Property(e => e.Hrkidad)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("hrkidad");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Kur).HasColumnName("kur");
            entity.Property(e => e.Odetipad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("odetipad");
            entity.Property(e => e.Odetipkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("odetipkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Tipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipad");
            entity.Property(e => e.Tutar).HasColumnName("tutar");
            entity.Property(e => e.Vadetar)
                .HasColumnType("datetime")
                .HasColumnName("vadetar");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Varok).HasColumnName("varok");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Fisma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__fismas__3213E83F58CEC241");

            entity.ToTable("fismas", tb =>
                {
                    tb.HasTrigger("fismas_log_trd");
                    tb.HasTrigger("fismas_log_tri");
                    tb.HasTrigger("fismas_log_tru");
                });

            entity.HasIndex(e => e.Fisno, "UQ__fismas__6FD49106").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Fisid).HasColumnName("fisid");
            entity.Property(e => e.Fisno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fisno");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Toptut)
                .HasDefaultValue(0.0)
                .HasColumnName("toptut");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Fistahodelistesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("fistahodelistesi");

            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Belno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.Fisid).HasColumnName("fisid");
            entity.Property(e => e.Grp)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("grp");
            entity.Property(e => e.Grptip)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("grptip");
            entity.Property(e => e.Hrkad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("hrkad");
            entity.Property(e => e.Hrkid).HasColumnName("hrkid");
            entity.Property(e => e.Hrkidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("hrkidad");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Kur).HasColumnName("kur");
            entity.Property(e => e.Odetipad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("odetipad");
            entity.Property(e => e.Odetipkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("odetipkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Tipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipad");
            entity.Property(e => e.Tutar).HasColumnName("tutar");
            entity.Property(e => e.Vadetar)
                .HasColumnType("datetime")
                .HasColumnName("vadetar");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Varok).HasColumnName("varok");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Frm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("frm");

            entity.Property(e => e.Anaformnesne)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("anaformnesne");
            entity.Property(e => e.Bolumid).HasColumnName("bolumid");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Frm1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("frm");
            entity.Property(e => e.Frmen)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("frmen");
            entity.Property(e => e.Frmtr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("frmtr");
            entity.Property(e => e.Havuz).HasColumnName("havuz");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Modul)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sfirmano).HasColumnName("sfirmano");
            entity.Property(e => e.Yetkialan).HasColumnName("yetkialan");
        });

        modelBuilder.Entity<Frmkont>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("frmkont");

            entity.Property(e => e.Anafrmid).HasColumnName("anafrmid");
            entity.Property(e => e.Bolumid).HasColumnName("bolumid");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.FatFisKontId).HasColumnName("fat_fis_kont_id");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Frmid).HasColumnName("frmid");
            entity.Property(e => e.Havuz).HasColumnName("havuz");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Kont)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kont");
            entity.Property(e => e.KontMenu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kont_menu");
            entity.Property(e => e.Konten)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("konten");
            entity.Property(e => e.Konttr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("konttr");
            entity.Property(e => e.Modul)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RapId).HasColumnName("Rap_id");
            entity.Property(e => e.Sfirmano).HasColumnName("sfirmano");
            entity.Property(e => e.Yetkialan).HasColumnName("yetkialan");
        });

        modelBuilder.Entity<GelGidKartListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Gel_Gid_Kart_Listesi");

            entity.Property(e => e.Actutar).HasColumnName("actutar");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Brim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.CarBakiye).HasColumnName("car_bakiye");
            entity.Property(e => e.Carbak).HasColumnName("carbak");
            entity.Property(e => e.CekharcBakiye).HasColumnName("cekharc_bakiye");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Firmaad)
                .HasMaxLength(100)
                .HasColumnName("firmaad");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.FisAdet).HasColumnName("fis_adet");
            entity.Property(e => e.FisBakiye).HasColumnName("fis_bakiye");
            entity.Property(e => e.Fisadet).HasColumnName("fisadet");
            entity.Property(e => e.Fisakadet).HasColumnName("fisakadet");
            entity.Property(e => e.Fisaktut).HasColumnName("fisaktut");
            entity.Property(e => e.Fisbak).HasColumnName("fisbak");
            entity.Property(e => e.Fiyat).HasColumnName("fiyat");
            entity.Property(e => e.Gizli).HasColumnName("gizli");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.Grup)
                .HasMaxLength(100)
                .HasColumnName("grup");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kdv).HasColumnName("kdv");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.LimitTip).HasColumnName("limit_tip");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.SonFisTarih)
                .HasColumnType("datetime")
                .HasColumnName("son_fis_tarih");
            entity.Property(e => e.SonFisTutar).HasColumnName("son_fis_tutar");
            entity.Property(e => e.SonhrkTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonhrk_tarih");
            entity.Property(e => e.TopBakiye).HasColumnName("top_bakiye");
            entity.Property(e => e.Topbak).HasColumnName("topbak");
            entity.Property(e => e.Toplim).HasColumnName("toplim");
        });

        modelBuilder.Entity<Gelgidkart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod, e.Sil }).HasName("PK__gelgidka__E033B95BE69A79EA");

            entity.ToTable("gelgidkart", tb =>
                {
                    tb.HasTrigger("gelgidkart_log_trd");
                    tb.HasTrigger("gelgidkart_log_tri");
                    tb.HasTrigger("gelgidkart_log_tru");
                    tb.HasTrigger("gelgidkart_tri");
                    tb.HasTrigger("gelgidkart_tru");
                });

            entity.HasIndex(e => e.Kod, "gelgidkart_uq").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Actutar)
                .HasDefaultValue(0.0)
                .HasColumnName("actutar");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Brim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Carbak)
                .HasDefaultValue(0.0)
                .HasColumnName("carbak");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Fisadet)
                .HasDefaultValue(0)
                .HasColumnName("fisadet");
            entity.Property(e => e.Fisakadet)
                .HasDefaultValue(0)
                .HasColumnName("fisakadet");
            entity.Property(e => e.Fisaktut)
                .HasDefaultValue(0.0)
                .HasColumnName("fisaktut");
            entity.Property(e => e.Fisbak)
                .HasDefaultValue(0.0)
                .HasColumnName("fisbak");
            entity.Property(e => e.Fiyat)
                .HasDefaultValue(0.0)
                .HasColumnName("fiyat");
            entity.Property(e => e.Gizli).HasColumnName("gizli");
            entity.Property(e => e.Grp1)
                .HasDefaultValue(0)
                .HasColumnName("grp1");
            entity.Property(e => e.Grp2)
                .HasDefaultValue(0)
                .HasColumnName("grp2");
            entity.Property(e => e.Grp3)
                .HasDefaultValue(0)
                .HasColumnName("grp3");
            entity.Property(e => e.Kdv)
                .HasDefaultValue(0.0)
                .HasColumnName("kdv");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.LimitTip)
                .HasDefaultValue(0)
                .HasColumnName("limit_tip");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.PromKacSatis).HasColumnName("Prom_Kac_Satis");
            entity.Property(e => e.PromSatPuan).HasColumnName("Prom_Sat_Puan");
            entity.Property(e => e.PromSatTip).HasColumnName("Prom_Sat_Tip");
            entity.Property(e => e.PromUrun).HasColumnName("Prom_Urun");
            entity.Property(e => e.PuanBrm).HasColumnName("Puan_Brm");
            entity.Property(e => e.PuanFis).HasColumnName("Puan_Fis");
            entity.Property(e => e.PuanKk).HasColumnName("Puan_KK");
            entity.Property(e => e.PuanNakit).HasColumnName("Puan_Nakit");
            entity.Property(e => e.PuanTip).HasColumnName("Puan_Tip");
            entity.Property(e => e.RemoteId).HasColumnName("Remote_id");
            entity.Property(e => e.TipId).HasColumnName("tip_id");
            entity.Property(e => e.Toplim)
                .HasDefaultValue(0.0)
                .HasColumnName("toplim");
        });

        modelBuilder.Entity<Gelgidlistok>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("gelgidlistok");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Brim)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.Gtip)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Muhckskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhckskod");
            entity.Property(e => e.Muhgrskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhgrskod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Sat1fiy).HasColumnName("sat1fiy");
            entity.Property(e => e.Sat1kdv).HasColumnName("sat1kdv");
            entity.Property(e => e.Sat1kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat1kdvtip");
            entity.Property(e => e.Sat2fiy).HasColumnName("sat2fiy");
            entity.Property(e => e.Sat2kdv).HasColumnName("sat2kdv");
            entity.Property(e => e.Sat2kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat2kdvtip");
            entity.Property(e => e.Stktur)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("stktur");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.TipId).HasColumnName("Tip_id");
        });

        modelBuilder.Entity<GenelCariKart>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Genel_Cari_Kart");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.Adres2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("adres2");
            entity.Property(e => e.AdresPostaKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CarTipId).HasColumnName("CarTip_id");
            entity.Property(e => e.Cartip)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Cep)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cep");
            entity.Property(e => e.Crno).HasColumnName("crno");
            entity.Property(e => e.Evil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evil");
            entity.Property(e => e.Evilce)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evilce");
            entity.Property(e => e.FatIskonto).HasColumnName("fat_iskonto");
            entity.Property(e => e.Fatunvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fatunvan");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.FisIskonto).HasColumnName("fis_iskonto");
            entity.Property(e => e.Fisvadsur).HasColumnName("fisvadsur");
            entity.Property(e => e.Fisvadtip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fisvadtip");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.Grupad1)
                .HasMaxLength(100)
                .HasColumnName("grupad1");
            entity.Property(e => e.Iban)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IBAN");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.OtoFisVadeFark).HasColumnName("Oto_FisVadeFark");
            entity.Property(e => e.PerId).HasColumnName("per_id");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Soyad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Tcno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tcno");
            entity.Property(e => e.Tel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.TicSicilNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.UniqId)
                .HasMaxLength(52)
                .IsUnicode(false)
                .HasColumnName("Uniq_id");
            entity.Property(e => e.Unvan)
                .HasMaxLength(201)
                .IsUnicode(false);
            entity.Property(e => e.VergiEposta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VergiKno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("VergiKNo");
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vergidaire");
            entity.Property(e => e.Vergino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vergino");
            entity.Property(e => e.Webadres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("webadres");
        });

        modelBuilder.Entity<GenelKart>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Genel_Kart");

            entity.Property(e => e.Ad)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.Adres2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("adres2");
            entity.Property(e => e.BankaAd)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BankaDbs)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BankaKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Cartp)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("cartp");
            entity.Property(e => e.Cep)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cep");
            entity.Property(e => e.Crno).HasColumnName("crno");
            entity.Property(e => e.Evil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evil");
            entity.Property(e => e.Evilce)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evilce");
            entity.Property(e => e.FatIskonto).HasColumnName("fat_iskonto");
            entity.Property(e => e.Fatunvan)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fatunvan");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.FisIskonto).HasColumnName("fis_iskonto");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.Grupad1)
                .HasMaxLength(100)
                .HasColumnName("grupad1");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.OtoFisVadeFark).HasColumnName("Oto_FisVadeFark");
            entity.Property(e => e.PerId).HasColumnName("Per_id");
            entity.Property(e => e.PromGrp1).HasColumnName("Prom_Grp1");
            entity.Property(e => e.Sl).HasColumnName("sl");
            entity.Property(e => e.Tcno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tcno");
            entity.Property(e => e.Tel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.TicSicilNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.TipId).HasColumnName("Tip_id");
            entity.Property(e => e.VergiEposta)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VergiKno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("VergiKNo");
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vergidaire");
            entity.Property(e => e.Vergino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vergino");
            entity.Property(e => e.Webadres)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("webadres");
        });

        modelBuilder.Entity<GenelrapGoster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("genelrap_goster");

            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<GrafikRapGoster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Grafik_Rap_Goster");

            entity.Property(e => e.AckEn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Ack_En");
            entity.Property(e => e.AckTr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Ack_Tr");
            entity.Property(e => e.Goster).HasDefaultValue(true);
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Grup>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Tabload }).HasName("PK__grup__379B761F35D3D0F6");

            entity.ToTable("grup", tb =>
                {
                    tb.HasTrigger("grup_log_trd");
                    tb.HasTrigger("grup_log_tri");
                    tb.HasTrigger("grup_log_tru");
                });

            entity.HasIndex(e => new { e.Tabload, e.Sil }, "grup_Tabload");

            entity.HasIndex(e => e.Sr, "grup_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Tabload)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tabload");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .HasColumnName("ad");
            entity.Property(e => e.CalismaSartId)
                .HasDefaultValue(0)
                .HasColumnName("Calisma_SartId");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Grp1)
                .HasDefaultValue(0)
                .HasColumnName("grp1");
            entity.Property(e => e.Grp2)
                .HasDefaultValue(0)
                .HasColumnName("grp2");
            entity.Property(e => e.Kar1)
                .HasDefaultValue(0.0)
                .HasColumnName("kar1");
            entity.Property(e => e.Kar2)
                .HasDefaultValue(0.0)
                .HasColumnName("kar2");
            entity.Property(e => e.Kar3)
                .HasDefaultValue(0.0)
                .HasColumnName("kar3");
            entity.Property(e => e.Kar4)
                .HasDefaultValue(0.0)
                .HasColumnName("kar4");
            entity.Property(e => e.Kdv)
                .HasDefaultValue(0.0)
                .HasColumnName("kdv");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MuhAlsIadKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_iad_kod");
            entity.Property(e => e.MuhAlsIskKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_isk_kod");
            entity.Property(e => e.MuhAlsOtvKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_otv_kod");
            entity.Property(e => e.MuhSatIadKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_iad_kod");
            entity.Property(e => e.MuhSatIskKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_isk_kod");
            entity.Property(e => e.MuhSatMalKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_mal_kod");
            entity.Property(e => e.MuhSatOtvKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_otv_kod");
            entity.Property(e => e.MuhasebeGrupKodu)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Muhckskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhckskod");
            entity.Property(e => e.Muhgrskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhgrskod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.PerIdin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PerIDIN");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("Remote_id");
            entity.Property(e => e.Restaurant).HasDefaultValue(false);
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Sr)
                .HasDefaultValue(0)
                .HasColumnName("sr");
            entity.Property(e => e.UretimYerId).HasDefaultValue(0);
            entity.Property(e => e.UserIdIn)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Yerli).HasDefaultValue(false);
            entity.Property(e => e.YkKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ykkisno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ykkisno");
        });

        modelBuilder.Entity<GunlukrapGoster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Gunlukrap_Goster");

            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<HariciKart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Harici_K__3213E83F127755F8");

            entity.ToTable("Harici_Kart");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Cartip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Sil)
                .HasDefaultValue((byte)0)
                .HasColumnName("sil");
            entity.Property(e => e.Tip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.TipId).HasColumnName("tip_id");
        });

        modelBuilder.Entity<HrkGrupKriter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hrk_Grup__3213E83F85EE369B");

            entity.ToTable("Hrk_Grup_Kriter");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AckTr)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("Ack_Tr");
            entity.Property(e => e.Genel).HasDefaultValue(1);
            entity.Property(e => e.UserId).HasColumnName("User_Id");
        });

        modelBuilder.Entity<HrkKriter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hrk_Krit__3213E83F0A92C160");

            entity.ToTable("Hrk_Kriter");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GrpId).HasColumnName("Grp_Id");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Raptip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("raptip");
            entity.Property(e => e.Sec).HasColumnName("sec");
            entity.Property(e => e.UserId).HasColumnName("User_Id");
        });

        modelBuilder.Entity<Il>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__il__3213E83FC1B6D2F0");

            entity.ToTable("il");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Kod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
        });

        modelBuilder.Entity<Ilce>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ilce__3213E83F1FEB7FB4");

            entity.ToTable("ilce");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Anakod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("anakod");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
        });

        modelBuilder.Entity<Irsaliyehrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Irid }).HasName("PK__irsaliye__AB4860DBC96FBEC2");

            entity.ToTable("irsaliyehrk", tb =>
                {
                    tb.HasTrigger("irsaliyehrk_log_trd");
                    tb.HasTrigger("irsaliyehrk_log_tri");
                    tb.HasTrigger("irsaliyehrk_log_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Irid).HasColumnName("irid");
            entity.Property(e => e.AppSiraNo).HasDefaultValue(0);
            entity.Property(e => e.Barkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("barkod");
            entity.Property(e => e.Brim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Brmfiy)
                .HasDefaultValue(0.0)
                .HasColumnName("brmfiy");
            entity.Property(e => e.Carpan).HasColumnName("carpan");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.DepId).HasColumnName("dep_id");
            entity.Property(e => e.Depkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("depkod");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Genisktut)
                .HasDefaultValue(0.0)
                .HasColumnName("genisktut");
            entity.Property(e => e.Geniskyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("geniskyuz");
            entity.Property(e => e.Grupid)
                .HasDefaultValue(0.0)
                .HasColumnName("grupid");
            entity.Property(e => e.IslemKur).HasColumnName("Islem_Kur");
            entity.Property(e => e.IslemParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Islem_ParaBrm");
            entity.Property(e => e.KartKur).HasColumnName("Kart_Kur");
            entity.Property(e => e.KartParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kart_ParaBrm");
            entity.Property(e => e.Kayok)
                .HasDefaultValue(0)
                .HasColumnName("kayok");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Kdvtut).HasColumnName("kdvtut");
            entity.Property(e => e.Kdvyuz).HasColumnName("kdvyuz");
            entity.Property(e => e.Kesafet).HasColumnName("kesafet");
            entity.Property(e => e.Kur)
                .HasDefaultValue(1.0)
                .HasColumnName("kur");
            entity.Property(e => e.Mik)
                .HasDefaultValue(0.0)
                .HasColumnName("mik");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otvbrim).HasColumnName("otvbrim");
            entity.Property(e => e.Parabrim)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrim");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0L)
                .HasColumnName("remote_id");
            entity.Property(e => e.Satisktut)
                .HasDefaultValue(0.0)
                .HasColumnName("satisktut");
            entity.Property(e => e.Satiskyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("satiskyuz");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Sipid)
                .HasDefaultValue(0.0)
                .HasColumnName("sipid");
            entity.Property(e => e.StkId).HasColumnName("stk_id");
            entity.Property(e => e.Stkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.StktipId).HasColumnName("stktip_id");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Ustbrim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ustbrim");
            entity.Property(e => e.Vadtar)
                .HasColumnType("datetime")
                .HasColumnName("vadtar");
        });

        modelBuilder.Entity<Irsaliyehrklistesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("irsaliyehrklistesi");

            entity.Property(e => e.Brim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Brmfiy).HasColumnName("brmfiy");
            entity.Property(e => e.Carpan).HasColumnName("carpan");
            entity.Property(e => e.Depkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Grupid).HasColumnName("grupid");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Irid).HasColumnName("irid");
            entity.Property(e => e.Kayok).HasColumnName("kayok");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Kdvtut).HasColumnName("kdvtut");
            entity.Property(e => e.Kdvyuz).HasColumnName("kdvyuz");
            entity.Property(e => e.Mik).HasColumnName("mik");
            entity.Property(e => e.Parabrim)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrim");
            entity.Property(e => e.Satirtip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("satirtip");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Stkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.Ustbrim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ustbrim");
        });

        modelBuilder.Entity<Irsaliyema>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Irid }).HasName("PK__irsaliye__AB4860DB76BA7263");

            entity.ToTable("irsaliyemas", tb =>
                {
                    tb.HasTrigger("irsaliyemas_log_trd");
                    tb.HasTrigger("irsaliyemas_log_tri");
                    tb.HasTrigger("irsaliyemas_log_tru");
                    tb.HasTrigger("irsaliyemas_trd");
                    tb.HasTrigger("irsaliyemas_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Irid).HasColumnName("irid");
            entity.Property(e => e.Ack)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Akid)
                .HasDefaultValue(0.0)
                .HasColumnName("akid");
            entity.Property(e => e.Aktar)
                .HasColumnType("datetime")
                .HasColumnName("aktar");
            entity.Property(e => e.Aktip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("BK")
                .HasColumnName("aktip");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Depo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("depo");
            entity.Property(e => e.EbelgeEntegrasyon)
                .HasDefaultValue(false)
                .HasColumnName("EBelgeEntegrasyon");
            entity.Property(e => e.EbelgeEntegrasyonId).HasColumnName("EBelgeEntegrasyonId");
            entity.Property(e => e.EbelgeEntegrasyonTarihSaat)
                .HasColumnType("datetime")
                .HasColumnName("EBelgeEntegrasyonTarihSaat");
            entity.Property(e => e.EbelgeGibSeriNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EBelgeGibSeriNo");
            entity.Property(e => e.EbelgeId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EBelgeId");
            entity.Property(e => e.EbelgeMailTarihSaat)
                .HasColumnType("datetime")
                .HasColumnName("EBelgeMailTarihSaat");
            entity.Property(e => e.EbelgeSeriId)
                .HasDefaultValue(0)
                .HasColumnName("EBelgeSeriId");
            entity.Property(e => e.EbelgeSoforId)
                .HasDefaultValue(0)
                .HasColumnName("EBelgeSoforId");
            entity.Property(e => e.EbelgeTasiyiciFirmaId)
                .HasDefaultValue(0)
                .HasColumnName("EBelgeTasiyiciFirmaId");
            entity.Property(e => e.EbelgeTeslimYerId)
                .HasDefaultValue(0)
                .HasColumnName("EBelgeTeslimYerId");
            entity.Property(e => e.EbelgeTipId)
                .HasDefaultValue(0)
                .HasColumnName("EBelgeTipId");
            entity.Property(e => e.Entegre).HasDefaultValue(false);
            entity.Property(e => e.EntegreAktar)
                .HasColumnType("datetime")
                .HasColumnName("Entegre_Aktar");
            entity.Property(e => e.EntegreTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Entegre_Tip");
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Gctip).HasColumnName("gctip");
            entity.Property(e => e.GenelAraTop).HasColumnName("genel_ara_top");
            entity.Property(e => e.GenelKdvTop).HasColumnName("genel_kdv_top");
            entity.Property(e => e.GenelNetTop).HasColumnName("genel_net_top");
            entity.Property(e => e.GenelTop).HasColumnName("genel_top");
            entity.Property(e => e.HrkCarPro).HasColumnName("hrk_car_pro");
            entity.Property(e => e.HrkStkPro).HasColumnName("hrk_stk_pro");
            entity.Property(e => e.Irad)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("irad");
            entity.Property(e => e.Irno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("irno");
            entity.Property(e => e.Irseri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("irseri");
            entity.Property(e => e.IrsrapId).HasColumnName("irsrap_id");
            entity.Property(e => e.IrstipId).HasColumnName("irstip_id");
            entity.Property(e => e.IrsturId).HasColumnName("irstur_id");
            entity.Property(e => e.Irtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("irtip");
            entity.Property(e => e.Irtop)
                .HasDefaultValue(0.0)
                .HasColumnName("irtop");
            entity.Property(e => e.Irtur)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("irtur");
            entity.Property(e => e.Irturad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("irturad");
            entity.Property(e => e.IslemKur).HasColumnName("Islem_Kur");
            entity.Property(e => e.IslemParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Islem_ParaBrm");
            entity.Property(e => e.KartKur).HasColumnName("Kart_Kur");
            entity.Property(e => e.KartParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kart_ParaBrm");
            entity.Property(e => e.Kayok)
                .HasDefaultValue(0)
                .HasColumnName("kayok");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Kdvtop)
                .HasDefaultValue(0.0)
                .HasColumnName("kdvtop");
            entity.Property(e => e.Kdvtut).HasColumnName("kdvtut");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Plaka)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0L)
                .HasColumnName("remote_id");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.SevkSaat)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Sevktar)
                .HasColumnType("datetime")
                .HasColumnName("sevktar");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Sofor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Vadtar)
                .HasColumnType("datetime")
                .HasColumnName("vadtar");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
            entity.Property(e => e.Yuvtop).HasColumnName("yuvtop");
        });

        modelBuilder.Entity<Islemhrktip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__islemhrk__3213E83F683DD5C0");

            entity.ToTable("islemhrktip");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Gc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gc");
            entity.Property(e => e.Hrk)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("hrk");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Tip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("tip");
        });

        modelBuilder.Entity<Islemturtip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__islemtur__3213E83FE6F7A32E");

            entity.ToTable("islemturtip");

            entity.HasIndex(e => e.Tip, "UQ__islemturtip__5FD3FEBE").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Tip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("tip");
        });

        modelBuilder.Entity<Istkart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod }).HasName("PK__istkart__DFEE6686F8B80E13");

            entity.ToTable("istkart", tb =>
                {
                    tb.HasTrigger("istkart_log_trd");
                    tb.HasTrigger("istkart_log_tri");
                    tb.HasTrigger("istkart_log_tru");
                    tb.HasTrigger("istkart_tri");
                    tb.HasTrigger("istkart_tru");
                });

            entity.HasIndex(e => e.Kod, "istkart_uq").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Actutar)
                .HasDefaultValue(0.0)
                .HasColumnName("actutar");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Alacak)
                .HasDefaultValue(0.0)
                .HasColumnName("alacak");
            entity.Property(e => e.Bankod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("bankod");
            entity.Property(e => e.Borc)
                .HasDefaultValue(0.0)
                .HasColumnName("borc");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Heskesgun).HasColumnName("heskesgun");
            entity.Property(e => e.Hessongun).HasColumnName("hessongun");
            entity.Property(e => e.Karttur)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("karttur");
            entity.Property(e => e.Lim).HasColumnName("lim");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Sahibi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sahibi");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Sonkultar)
                .HasColumnType("datetime")
                .HasColumnName("sonkultar");
        });

        modelBuilder.Entity<Istkhrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Istkhrkid, e.Istkkod, e.Firmano }).HasName("PK__istkhrk__D2897F62AB882B78");

            entity.ToTable("istkhrk", tb =>
                {
                    tb.HasTrigger("istkhrk_log_trd");
                    tb.HasTrigger("istkhrk_log_tri");
                    tb.HasTrigger("istkhrk_log_tru");
                    tb.HasTrigger("istkhrk_trd");
                    tb.HasTrigger("istkhrk_triu");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Istkhrkid).HasColumnName("istkhrkid");
            entity.Property(e => e.Istkkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("istkkod");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Adaid)
                .HasDefaultValue(0)
                .HasColumnName("adaid");
            entity.Property(e => e.Alacak)
                .HasDefaultValue(0.0)
                .HasColumnName("alacak");
            entity.Property(e => e.Belno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.BelrapId)
                .HasDefaultValue(0)
                .HasColumnName("belrap_id");
            entity.Property(e => e.Borc).HasColumnName("borc");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Carslip).HasColumnName("carslip");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Cartur)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartur");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Devir)
                .HasDefaultValue(false)
                .HasColumnName("devir");
            entity.Property(e => e.Entegre).HasDefaultValue(false);
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.Fisfatid)
                .HasDefaultValue(0.0)
                .HasColumnName("fisfatid");
            entity.Property(e => e.Fisfattip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("KENDI")
                .HasColumnName("fisfattip");
            entity.Property(e => e.Fisid).HasColumnName("fisid");
            entity.Property(e => e.Gctip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gctip");
            entity.Property(e => e.IskkId).HasColumnName("iskk_id");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmhrkad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmhrkad");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.IstkkId).HasColumnName("istkk_id");
            entity.Property(e => e.KarsiKartKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Karsi_KartKod");
            entity.Property(e => e.KarsiKartTip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Karsi_KartTip");
            entity.Property(e => e.Karsiheskod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("karsiheskod");
            entity.Property(e => e.Karsihestip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("karsihestip");
            entity.Property(e => e.Kur)
                .HasDefaultValue(0.0)
                .HasColumnName("kur");
            entity.Property(e => e.Masterid)
                .HasDefaultValue(0.0)
                .HasColumnName("masterid");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Rg)
                .HasDefaultValue((byte)1)
                .HasColumnName("rg");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Tahodeid).HasColumnName("tahodeid");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.Vadetar)
                .HasColumnType("datetime")
                .HasColumnName("vadetar");
            entity.Property(e => e.Varno)
                .HasDefaultValue(0.0)
                .HasColumnName("varno");
            entity.Property(e => e.Varok)
                .HasDefaultValue(1)
                .HasColumnName("varok");
            entity.Property(e => e.Yerad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<IstkrediKartListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("istkredi_Kart_Listesi");

            entity.Property(e => e.Actutar).HasColumnName("actutar");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Alacak).HasColumnName("alacak");
            entity.Property(e => e.Bankod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("bankod");
            entity.Property(e => e.Borc).HasColumnName("borc");
            entity.Property(e => e.Dataok).HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.HesKesTar)
                .HasColumnType("datetime")
                .HasColumnName("hes_kes_tar");
            entity.Property(e => e.Heskesgun).HasColumnName("heskesgun");
            entity.Property(e => e.Hessongun).HasColumnName("hessongun");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.KalLimit).HasColumnName("kal_limit");
            entity.Property(e => e.Karttur)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("karttur");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Lim).HasColumnName("lim");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Sahibi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sahibi");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.SonOdeTar)
                .HasColumnType("datetime")
                .HasColumnName("son_ode_tar");
            entity.Property(e => e.Sonkultar)
                .HasColumnType("datetime")
                .HasColumnName("sonkultar");
            entity.Property(e => e.TopBakiye).HasColumnName("top_bakiye");
            entity.Property(e => e.VadGelen).HasColumnName("vad_gelen");
        });

        modelBuilder.Entity<Kartsumalan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__kartsuma__3213E83F82392546");

            entity.ToTable("kartsumalan");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alanad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("alanad");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Tabload)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tabload");
        });

        modelBuilder.Entity<Karttip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__karttip__3213E83F020B9412");

            entity.ToTable("karttip");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
        });

        modelBuilder.Entity<KasaKapa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__kasa_kap__3213E83F814B7F0F");

            entity.ToTable("kasa_kapa", tb =>
                {
                    tb.HasTrigger("kasa_kapa_log_trd");
                    tb.HasTrigger("kasa_kapa_log_tri");
                    tb.HasTrigger("kasa_kapa_log_tru");
                });

            entity.HasIndex(e => new { e.Firmano, e.Tarih }, "kasakapama_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Kapat)
                .HasDefaultValue(true)
                .HasColumnName("kapat");
            entity.Property(e => e.KasaId).HasColumnName("kasa_id");
            entity.Property(e => e.Kaskod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kaskod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
        });

        modelBuilder.Entity<KasaKapat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__kasa_kap__3213E83F726A9085");

            entity.ToTable("kasa_kapat");

            entity.HasIndex(e => new { e.Firmano, e.Tarih }, "kasakapama_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasDefaultValue((byte)0)
                .HasColumnName("drm");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.KasaId).HasColumnName("kasa_id");
            entity.Property(e => e.Kaskod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kaskod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
        });

        modelBuilder.Entity<KasaKartListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Kasa_Kart_Listesi");

            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.CikanBakiye)
                .HasColumnType("decimal(38, 8)")
                .HasColumnName("cikan_bakiye");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.GirenBakiye)
                .HasColumnType("decimal(38, 8)")
                .HasColumnName("giren_bakiye");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tip).HasColumnName("tip");
            entity.Property(e => e.TopBakiye)
                .HasColumnType("decimal(38, 8)")
                .HasColumnName("top_bakiye");
        });

        modelBuilder.Entity<Kasahrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno, e.Masterid, e.Kaskod, e.Kashrkid }).HasName("PK__kasahrk__6276BA827E11A768");

            entity.ToTable("kasahrk", tb =>
                {
                    tb.HasTrigger("kasahrk_log_trd");
                    tb.HasTrigger("kasahrk_log_tri");
                    tb.HasTrigger("kasahrk_log_tru");
                    tb.HasTrigger("kasahrk_trd");
                    tb.HasTrigger("kasahrk_tri");
                });

            entity.HasIndex(e => e.Id, "UQ__kasahrk__3213E83E60268E7E").IsUnique();

            entity.HasIndex(e => new { e.Firmano, e.Kaskod, e.Tarih, e.Sil }, "kasahrk_index2");

            entity.HasIndex(e => new { e.Firmano, e.Kaskod, e.Sil, e.Tarih, e.Varno, e.Islmhrk }, "kasahrk_index3");

            entity.HasIndex(e => e.Id, "kasahrk_uq").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Masterid).HasColumnName("masterid");
            entity.Property(e => e.Kaskod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kaskod");
            entity.Property(e => e.Kashrkid).HasColumnName("kashrkid");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Adaid).HasColumnName("adaid");
            entity.Property(e => e.Bakiye)
                .HasDefaultValue(0.0)
                .HasColumnName("bakiye");
            entity.Property(e => e.Banknot).HasDefaultValue((byte)0);
            entity.Property(e => e.Belno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.CariAvans).HasDefaultValue(false);
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Cekid)
                .HasDefaultValue(0)
                .HasColumnName("cekid");
            entity.Property(e => e.Cikan)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(38, 8)")
                .HasColumnName("cikan");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Devir)
                .HasDefaultValue(false)
                .HasColumnName("devir");
            entity.Property(e => e.Entegre).HasDefaultValue(false);
            entity.Property(e => e.EntegreAktar)
                .HasColumnType("datetime")
                .HasColumnName("entegre_aktar");
            entity.Property(e => e.EntegreTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("entegre_tip");
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Fisfatid)
                .HasDefaultValue(0.0)
                .HasColumnName("fisfatid");
            entity.Property(e => e.Fisfattip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("KENDI")
                .HasColumnName("fisfattip");
            entity.Property(e => e.Fisid).HasColumnName("fisid");
            entity.Property(e => e.Gctip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gctip");
            entity.Property(e => e.GecPerKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Gec_PerKod");
            entity.Property(e => e.Giren)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(38, 8)")
                .HasColumnName("giren");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmhrkad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmhrkad");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.KarsiKartKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Karsi_KartKod");
            entity.Property(e => e.KarsiKartTip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Karsi_KartTip");
            entity.Property(e => e.Karsiheskod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("karsiheskod");
            entity.Property(e => e.Karsihestip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("karsihestip");
            entity.Property(e => e.KasId).HasColumnName("kas_id");
            entity.Property(e => e.Kur).HasColumnName("kur");
            entity.Property(e => e.MarBozukParaId).HasColumnName("MarBozukPara_id");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Pro)
                .HasDefaultValue(1)
                .HasColumnName("pro");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Rg)
                .HasDefaultValue((byte)1)
                .HasColumnName("rg");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Tahodeid).HasColumnName("tahodeid");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Transfer).HasDefaultValue(false);
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TransferTarSaat)
                .HasColumnType("datetime")
                .HasColumnName("Transfer_TarSaat");
            entity.Property(e => e.Vadetar)
                .HasColumnType("datetime")
                .HasColumnName("vadetar");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Kasakart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod, e.Tip }).HasName("PK__kasakart__ED3276DD50DE6573");

            entity.ToTable("kasakart", tb =>
                {
                    tb.HasTrigger("kasakart_log_trd");
                    tb.HasTrigger("kasakart_log_tri");
                    tb.HasTrigger("kasakart_log_tru");
                    tb.HasTrigger("kasakart_trd");
                    tb.HasTrigger("kasakart_tru");
                });

            entity.HasIndex(e => e.Kod, "kasakart_uq").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Tip).HasColumnName("tip");
            entity.Property(e => e.AcTarih)
                .HasColumnType("datetime")
                .HasColumnName("Ac_Tarih");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Cekmuhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cekmuhkod");
            entity.Property(e => e.Cikan)
                .HasDefaultValue(0.0)
                .HasColumnName("cikan");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0.0)
                .HasColumnName("firmano");
            entity.Property(e => e.Giren)
                .HasDefaultValue(0.0)
                .HasColumnName("giren");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Sr)
                .HasDefaultValue(1)
                .HasColumnName("sr");
            entity.Property(e => e.UserIdIn)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KdvOran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__kdv_oran__3213E83FF9E54ADB");

            entity.ToTable("kdv_oran");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Oran).HasColumnName("oran");
        });

        modelBuilder.Entity<KdvtevkifatTip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__KDVTevki__3214EC07931B5A56");

            entity.ToTable("KDVTevkifat_Tip");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Ad)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Kod)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
        });

        modelBuilder.Entity<Kriterkayit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__kriterka__3213E83FD78C431F");

            entity.ToTable("kriterkayit");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Alisfatin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alisfatin");
            entity.Property(e => e.Carigrupin)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("carigrupin");
            entity.Property(e => e.Cekin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cekin");
            entity.Property(e => e.ChBakSifir).HasColumnName("ch_bak_sifir");
            entity.Property(e => e.ChDevir).HasColumnName("ch_devir");
            entity.Property(e => e.ChTarih).HasColumnName("ch_tarih");
            entity.Property(e => e.ChYazdir).HasColumnName("ch_yazdir");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.FatOrtBrm).HasColumnName("fat_ort_brm");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Fisin)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("fisin");
            entity.Property(e => e.Form)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("form");
            entity.Property(e => e.NesneAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nesne_Ad");
            entity.Property(e => e.NesneDeger)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nesne_Deger");
            entity.Property(e => e.NesneTip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Nesne_Tip");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Satfatin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("satfatin");
            entity.Property(e => e.Slipin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("slipin");
            entity.Property(e => e.Users)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("users");
            entity.Property(e => e.VadKrd)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("vad_krd");
            entity.Property(e => e.VarBasin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Var_Basin");
        });

        modelBuilder.Entity<Kurgr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__kurgrs__3213E83FDFF0D4A1");

            entity.ToTable("kurgrs");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Euro).HasColumnName("euro");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Gbp).HasColumnName("gbp");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Tar)
                .HasColumnType("datetime")
                .HasColumnName("tar");
            entity.Property(e => e.Usd).HasColumnName("usd");
            entity.Property(e => e.Ytl).HasColumnName("ytl");
        });

        modelBuilder.Entity<LogAlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LogAlan");

            entity.Property(e => e.Alan)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sfirmano).HasColumnName("sfirmano");
            entity.Property(e => e.Tablo)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LogFatura>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__Log_Fatu__5E54864811BA53FB");

            entity.ToTable("Log_Fatura");

            entity.Property(e => e.Aciklama).HasMaxLength(500);
            entity.Property(e => e.DegistirmeKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.EfaturaAktarimTarih)
                .HasColumnType("datetime")
                .HasColumnName("EFaturaAktarimTarih");
            entity.Property(e => e.EfaturaId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EFaturaId");
            entity.Property(e => e.EfaturaNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EFaturaNo");
            entity.Property(e => e.EfaturaTipId).HasColumnName("EFaturaTipId");
            entity.Property(e => e.EntegreAktarimTarih).HasColumnType("datetime");
            entity.Property(e => e.FaturaAd)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FaturaNo).HasMaxLength(100);
            entity.Property(e => e.FaturaSeri).HasMaxLength(100);
            entity.Property(e => e.GenelIskontoTutar).HasDefaultValue(0.0);
            entity.Property(e => e.GenelMatrah).HasDefaultValue(0.0);
            entity.Property(e => e.KapTipId).HasDefaultValue(0);
            entity.Property(e => e.Kilit).HasDefaultValue(false);
            entity.Property(e => e.Odeme).HasDefaultValue(false);
            entity.Property(e => e.OlusturmaKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Plaka)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RemoteId).HasDefaultValue(0L);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.SyncStatus).HasDefaultValue((byte)1);
            entity.Property(e => e.TarihSaat).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TransferTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.VadeTarih).HasColumnType("datetime");
            entity.Property(e => e.VergiNumarasi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.YazarKasaFisno)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LogFaturaHareket>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__Log_Fatu__5E5486483FC9CCDF");

            entity.ToTable("Log_FaturaHareket");

            entity.Property(e => e.Aciklama).HasMaxLength(500);
            entity.Property(e => e.Barkod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusturmaKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.RemoteId).HasDefaultValue(0L);
            entity.Property(e => e.SatirIskontoTutar).HasDefaultValue(0.0);
            entity.Property(e => e.SatirIskontoYuzde).HasDefaultValue(0.0);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.SyncStatus).HasDefaultValue((byte)1);
            entity.Property(e => e.ToplamIskontoTutar).HasDefaultValue(0.0);
            entity.Property(e => e.ToplamIskontoYuzde).HasDefaultValue(0.0);
            entity.Property(e => e.ToplamKdvTutar).HasDefaultValue(0.0);
            entity.Property(e => e.ToplamTutarIskontoluKdvli).HasDefaultValue(0.0);
            entity.Property(e => e.ToplamTutarIskontoluKdvsiz).HasDefaultValue(0.0);
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TransferTarihSaat).HasColumnType("datetime");
        });

        modelBuilder.Entity<LogMarketSati>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__Log_Mark__5E548648F0686EC3");

            entity.ToTable("Log_MarketSatis");

            entity.Property(e => e.DegistirmeKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.DepoKartId).HasDefaultValue(0);
            entity.Property(e => e.FaturaId).HasDefaultValue(0);
            entity.Property(e => e.GiderTutar).HasDefaultValue(0.0);
            entity.Property(e => e.IadeTutar).HasDefaultValue(0.0);
            entity.Property(e => e.IndirimTutar).HasDefaultValue(0.0);
            entity.Property(e => e.IslemTipId).HasDefaultValue(0);
            entity.Property(e => e.KartId).HasDefaultValue(0);
            entity.Property(e => e.KartTipId).HasDefaultValue(0);
            entity.Property(e => e.KayitDurum).HasDefaultValue(false);
            entity.Property(e => e.NakitTutar).HasDefaultValue(0.0);
            entity.Property(e => e.OlusturmaKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.PosTutar).HasDefaultValue(0.0);
            entity.Property(e => e.RemoteId).HasDefaultValue(0L);
            entity.Property(e => e.SatisTutar).HasDefaultValue(0.0);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.SyncStatus).HasDefaultValue((byte)1);
            entity.Property(e => e.TarihSaat).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TransferTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.VeresiyeId).HasDefaultValue(0);
            entity.Property(e => e.VeresiyeTutar).HasDefaultValue(0.0);
            entity.Property(e => e.YazarKasaTipId).HasDefaultValue(0);
            entity.Property(e => e.YuvarlamaTutar).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<LogMarketSatisHareket>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__Log_Mark__5E54864860F128D9");

            entity.ToTable("Log_MarketSatisHareket");

            entity.Property(e => e.Barkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.BirimFiyat).HasDefaultValue(0.0);
            entity.Property(e => e.BirimId).HasDefaultValue(1);
            entity.Property(e => e.DegistirmeKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.FiyatNo).HasDefaultValue(1);
            entity.Property(e => e.IndirimYuzde).HasDefaultValue(0.0);
            entity.Property(e => e.KartId).HasDefaultValue(0);
            entity.Property(e => e.KartTipId).HasDefaultValue(0);
            entity.Property(e => e.KdvTipId).HasDefaultValue(0);
            entity.Property(e => e.KdvYuzde).HasDefaultValue(0.0);
            entity.Property(e => e.Miktar).HasDefaultValue(0.0);
            entity.Property(e => e.OlusturmaKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.ParaBirimId).HasDefaultValue(1);
            entity.Property(e => e.ParaBirimKur).HasDefaultValue(1.0);
            entity.Property(e => e.Recete).HasDefaultValue(false);
            entity.Property(e => e.RemoteId).HasDefaultValue(0);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.SyncStatus).HasDefaultValue((byte)1);
            entity.Property(e => e.TarihSaat).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TransferTarihSaat).HasColumnType("datetime");
        });

        modelBuilder.Entity<LogUrunFiyatHistory>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__Log_Urun__5E548648724BC0C6");

            entity.ToTable("Log_UrunFiyatHistory");

            entity.Property(e => e.DegistirmeKullanici)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.EskiFiyat).HasDefaultValue(0.0);
            entity.Property(e => e.FiyatNo).HasDefaultValue(1);
            entity.Property(e => e.FiyatTip).HasDefaultValue(2);
            entity.Property(e => e.KartTipId).HasDefaultValue(10);
            entity.Property(e => e.OlusturmaKullaniciId).HasColumnType("datetime");
            entity.Property(e => e.OlusturmaKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.RemoteId).HasDefaultValue(0);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.SyncStatus).HasDefaultValue((byte)1);
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TransferTarihSaat).HasColumnType("datetime");
        });

        modelBuilder.Entity<LogUrunHareket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Log_Urun__3214EC0784C1D36B");

            entity.ToTable("Log_UrunHareket");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BayiId).HasDefaultValue(0);
            entity.Property(e => e.BelgeNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BirimFiyatBrutKdvli).HasDefaultValue(0.0);
            entity.Property(e => e.BirimFiyatNetKdvli).HasDefaultValue(0.0);
            entity.Property(e => e.Cikan).HasDefaultValue(0.0);
            entity.Property(e => e.DegistirmeKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.DepoId).HasDefaultValue(0);
            entity.Property(e => e.FaturaHareketId).HasDefaultValue(0);
            entity.Property(e => e.FaturaId).HasDefaultValue(0);
            entity.Property(e => e.Giren).HasDefaultValue(0.0);
            entity.Property(e => e.IrsaliyeHareketId).HasDefaultValue(0);
            entity.Property(e => e.IrsaliyeId).HasDefaultValue(0);
            entity.Property(e => e.KayitDurum).HasDefaultValue(true);
            entity.Property(e => e.KdvYuzde).HasDefaultValue(0.0);
            entity.Property(e => e.MarketSatisHareketId).HasDefaultValue(0);
            entity.Property(e => e.MarketSatisId).HasDefaultValue(0);
            entity.Property(e => e.MarketVardiyaId).HasDefaultValue(0);
            entity.Property(e => e.OlusturmaKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Otv).HasDefaultValue(0.0);
            entity.Property(e => e.PompaciVardiyaId).HasDefaultValue(0);
            entity.Property(e => e.RemoteId).HasDefaultValue(0L);
            entity.Property(e => e.SadakatHarcananPuan).HasDefaultValue(0.0);
            entity.Property(e => e.SadakatKartNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.SayimId)
                .HasDefaultValue(0m)
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciTipId).HasDefaultValue(1);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.StokBarkod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StokKodu)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SyncStatus).HasDefaultValue((byte)1);
            entity.Property(e => e.TankId).HasDefaultValue(0);
            entity.Property(e => e.TarihSaat).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TransferTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.VeresiyeHareketId).HasDefaultValue(0);
            entity.Property(e => e.VeresiyeId).HasDefaultValue(0);
        });

        modelBuilder.Entity<LogoTransferLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Logo_Tra__3214EC071021A95E");

            entity.ToTable("Logo_Transfer_Log");

            entity.Property(e => e.Ack)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.BelgeNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
            entity.Property(e => e.Tip)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MailAck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mail_Ack__3213E83F391BA343");

            entity.ToTable("Mail_Ack");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack).HasMaxLength(4000);
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
        });

        modelBuilder.Entity<MarSatRecHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MarSatRe__3214EC072738705D");

            entity.ToTable("MarSatRecHrk");

            entity.Property(e => e.BirimFiyat).HasDefaultValue(0.0);
            entity.Property(e => e.BirimMaliyetFiyat).HasDefaultValue(0.0);
            entity.Property(e => e.Brm)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Miktar).HasDefaultValue(0.0);
            entity.Property(e => e.OlusturmaKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.RemoteId).HasDefaultValue(0L);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.StokKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.StokTip)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TransferTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.UretimTipId).HasDefaultValue((byte)1);
        });

        modelBuilder.Entity<Markasahrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno, e.Kashrkid }).HasName("PK__markasah__DB642EC44DB0984A");

            entity.ToTable("markasahrk", tb =>
                {
                    tb.HasTrigger("markasahrk_log_trd");
                    tb.HasTrigger("markasahrk_log_tri");
                    tb.HasTrigger("markasahrk_log_tru");
                    tb.HasTrigger("markasahrk_tri");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Kashrkid).HasColumnName("kashrkid");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Cikan)
                .HasDefaultValue(0.0)
                .HasColumnName("cikan");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Gctip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gctip");
            entity.Property(e => e.Giren)
                .HasDefaultValue(0.0)
                .HasColumnName("giren");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmhrkad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmhrkad");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.KasaId).HasColumnName("kasa_id");
            entity.Property(e => e.Kaskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kaskod");
            entity.Property(e => e.Kur).HasColumnName("kur");
            entity.Property(e => e.Marsatid)
                .HasDefaultValue(0.0)
                .HasColumnName("marsatid");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Transfer).HasDefaultValue(false);
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TransferTarSaat)
                .HasColumnType("datetime")
                .HasColumnName("Transfer_TarSaat");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Marsathrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno, e.Marsatid }).HasName("PK__marsathr__52FB2F43F9AF2911");

            entity.ToTable("marsathrk", tb =>
                {
                    tb.HasTrigger("marsathrk_log_trd");
                    tb.HasTrigger("marsathrk_log_tri");
                    tb.HasTrigger("marsathrk_log_tru");
                });

            entity.HasIndex(e => e.Sil, "marsathrk_SilGrupIndex1");

            entity.HasIndex(e => new { e.Varno, e.Sil }, "marsathrk_VarnoSilGrupIndex1");

            entity.HasIndex(e => new { e.Marsatid, e.Sil }, "marsathrk_marsatid_index");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Marsatid).HasColumnName("marsatid");
            entity.Property(e => e.Barkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("barkod");
            entity.Property(e => e.Bedelsiz).HasDefaultValue(false);
            entity.Property(e => e.Brim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Brmfiy).HasColumnName("brmfiy");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Depkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Gctip).HasColumnName("gctip");
            entity.Property(e => e.Gtip)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Indyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("indyuz");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.Kayok)
                .HasDefaultValue(0)
                .HasColumnName("kayok");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Kdvyuz).HasColumnName("kdvyuz");
            entity.Property(e => e.Kur)
                .HasDefaultValue(1.0)
                .HasColumnName("kur");
            entity.Property(e => e.Mik).HasColumnName("mik");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Recete).HasDefaultValue(false);
            entity.Property(e => e.RehberIndirimYuzde).HasDefaultValue(0.0);
            entity.Property(e => e.RehberKomisyonYuzde).HasDefaultValue(0.0);
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Satfiyno).HasColumnName("satfiyno");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.StkAd)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.StkId).HasColumnName("stk_id");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.StktipId).HasColumnName("stktip_id");
            entity.Property(e => e.Stktipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stktipad");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Transfer).HasDefaultValue(false);
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TransferTarSaat)
                .HasColumnType("datetime")
                .HasColumnName("Transfer_TarSaat");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
            entity.Property(e => e.YazarKasaServisLogId).HasDefaultValue(0L);
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
            entity.Property(e => e.Ykno)
                .HasDefaultValue(0)
                .HasColumnName("ykno");
        });

        modelBuilder.Entity<Marsatma>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno, e.Marsatid }).HasName("PK__marsatma__52FB2F439C75A62D");

            entity.ToTable("marsatmas", tb =>
                {
                    tb.HasTrigger("marsatmas_trd");
                    tb.HasTrigger("marsatmas_triu");
                });

            entity.HasIndex(e => new { e.Marsatid, e.Sil }, "marsatmas_marsatid_index");

            entity.HasIndex(e => e.Varno, "marsatmas_varno_index");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Marsatid).HasColumnName("marsatid");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Cikis).HasDefaultValue(false);
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.FisNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Fis_No");
            entity.Property(e => e.FisYazdirildi).HasDefaultValue(false);
            entity.Property(e => e.Gidertop)
                .HasDefaultValue(0.0)
                .HasColumnName("gidertop");
            entity.Property(e => e.Iadetop)
                .HasDefaultValue(0.0)
                .HasColumnName("iadetop");
            entity.Property(e => e.Indtop)
                .HasDefaultValue(0.0)
                .HasColumnName("indtop");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmhrkad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmhrkad");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.Kayok)
                .HasDefaultValue(0)
                .HasColumnName("kayok");
            entity.Property(e => e.Kur)
                .HasDefaultValue(1.0)
                .HasColumnName("kur");
            entity.Property(e => e.Naktop)
                .HasDefaultValue(0.0)
                .HasColumnName("naktop");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Postop)
                .HasDefaultValue(0.0)
                .HasColumnName("postop");
            entity.Property(e => e.RehberBarkodId).HasDefaultValue(0);
            entity.Property(e => e.RehberGrupId).HasDefaultValue(0);
            entity.Property(e => e.RehberId).HasDefaultValue(0);
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Satistop)
                .HasDefaultValue(0.0)
                .HasColumnName("satistop");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Transfer).HasDefaultValue(false);
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TransferTarSaat)
                .HasColumnType("datetime")
                .HasColumnName("Transfer_TarSaat");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
            entity.Property(e => e.Veresitop)
                .HasDefaultValue(0.0)
                .HasColumnName("veresitop");
            entity.Property(e => e.YazarKasaBankaTerminalNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.YazarKasaId)
                .HasDefaultValue(0)
                .HasColumnName("YazarKasa_id");
            entity.Property(e => e.YazarKasaIslemId).HasDefaultValue(0);
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yertip");
            entity.Property(e => e.Yuvtop)
                .HasDefaultValue(0.0)
                .HasColumnName("yuvtop");
            entity.Property(e => e.Zno).HasDefaultValue(0);
        });

        modelBuilder.Entity<Marvardikap>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno }).HasName("PK__marvardi__76322BA29839570B");

            entity.ToTable("marvardikap", tb =>
                {
                    tb.HasTrigger("marvardikap_log_trd");
                    tb.HasTrigger("marvardikap_log_tri");
                    tb.HasTrigger("marvardikap_log_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Ackfaz)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ackfaz");
            entity.Property(e => e.Cartip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Kaptip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kaptip");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.Tutar).HasColumnName("tutar");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
        });

        modelBuilder.Entity<Marvardima>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno }).HasName("PK__marvardi__76322BA21F4CD4ED");

            entity.ToTable("marvardimas", tb =>
                {
                    tb.HasTrigger("marvardimas_log_trd");
                    tb.HasTrigger("marvardimas_log_tri");
                    tb.HasTrigger("marvardimas_log_tru");
                    tb.HasTrigger("marvardimas_trd");
                    tb.HasTrigger("marvardimas_tri");
                });

            entity.HasIndex(e => e.Varno, "marvardimas_varno_index");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Bankatop)
                .HasDefaultValue(0.0)
                .HasColumnName("bankatop");
            entity.Property(e => e.Bozukpara)
                .HasDefaultValue(0.0)
                .HasColumnName("bozukpara");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Depkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.EntegreAktar)
                .HasColumnType("datetime")
                .HasColumnName("entegre_aktar");
            entity.Property(e => e.EntegreTip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("entegre_tip");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.FisNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Fis_No");
            entity.Property(e => e.Gelirtop)
                .HasDefaultValue(0.0)
                .HasColumnName("gelirtop");
            entity.Property(e => e.Gidertop)
                .HasDefaultValue(0.0)
                .HasColumnName("gidertop");
            entity.Property(e => e.Iadetop)
                .HasDefaultValue(0.0)
                .HasColumnName("iadetop");
            entity.Property(e => e.Indtop)
                .HasDefaultValue(0.0)
                .HasColumnName("indtop");
            entity.Property(e => e.Kapsaat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("kapsaat");
            entity.Property(e => e.Kaptar)
                .HasColumnType("datetime")
                .HasColumnName("kaptar");
            entity.Property(e => e.KasKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kas_kod");
            entity.Property(e => e.Naksattop)
                .HasDefaultValue(0.0)
                .HasColumnName("naksattop");
            entity.Property(e => e.Naktestop)
                .HasDefaultValue(0.0)
                .HasColumnName("naktestop");
            entity.Property(e => e.Odetop)
                .HasDefaultValue(0.0)
                .HasColumnName("odetop");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Perkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Poscartop)
                .HasDefaultValue(0.0)
                .HasColumnName("poscartop");
            entity.Property(e => e.Postop)
                .HasDefaultValue(0.0)
                .HasColumnName("postop");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Satistop)
                .HasDefaultValue(0.0)
                .HasColumnName("satistop");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Tahtop)
                .HasDefaultValue(0.0)
                .HasColumnName("tahtop");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Transfer).HasDefaultValue(false);
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TransferTarSaat)
                .HasColumnType("datetime")
                .HasColumnName("Transfer_TarSaat");
            entity.Property(e => e.Varackfaztip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("varackfaztip");
            entity.Property(e => e.Varad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("varad");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
            entity.Property(e => e.Veresitop)
                .HasDefaultValue(0.0)
                .HasColumnName("veresitop");
            entity.Property(e => e.YazKno)
                .HasDefaultValue(0)
                .HasColumnName("Yaz_KNo");
            entity.Property(e => e.YazarKasaKasiyerKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.YazarKasaKontrol).HasDefaultValue(false);
            entity.Property(e => e.YazarKasaModel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.YazarKasaSeriNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.YazarKasaServis).HasDefaultValue(false);
            entity.Property(e => e.YazarKasaVardiyaNo).HasDefaultValue(0);
            entity.Property(e => e.Zno)
                .HasDefaultValue(0)
                .HasColumnName("ZNo");
        });

        modelBuilder.Entity<Marvardiozet>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno }).HasName("PK__marvardi__76322BA2DB94B5B4");

            entity.ToTable("marvardiozet");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Bakiye)
                .HasDefaultValue(0.0)
                .HasColumnName("bakiye");
            entity.Property(e => e.Cikis)
                .HasDefaultValue(0.0)
                .HasColumnName("cikis");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Giris)
                .HasDefaultValue(0.0)
                .HasColumnName("giris");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Sr).HasColumnName("sr");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Tipack)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipack");
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.Varok).HasColumnName("varok");
        });

        modelBuilder.Entity<Marvardirapgoster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("marvardirapgoster");

            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.FilitreDegerIn)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("Filitre_DegerIn");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RapTip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Rap_Tip");
        });

        modelBuilder.Entity<MerkezKartLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Merkez_K__3213E83FD5830585");

            entity.ToTable("Merkez_Kart_Log");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.TabloAd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Tip).HasDefaultValue(0);
        });

        modelBuilder.Entity<Mesaj>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Mesaj__3213E83F1894E35F");

            entity.ToTable("Mesaj");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Drm)
                .HasDefaultValue(false)
                .HasColumnName("drm");
            entity.Property(e => e.Firmano).HasDefaultValue(0);
            entity.Property(e => e.KimeUser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Kime_User");
            entity.Property(e => e.KimeUserId).HasColumnName("Kime_UserId");
            entity.Property(e => e.OlusTarSaat)
                .HasColumnType("datetime")
                .HasColumnName("Olus_TarSaat");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Olus_User");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("Remote_Id");
        });

        modelBuilder.Entity<MicroStokListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Micro_Stok_Listesi");

            entity.Property(e => e.Birimad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("birimad");
            entity.Property(e => e.Sat1fiy).HasColumnName("sat1fiy");
            entity.Property(e => e.Sat1kdv).HasColumnName("sat1kdv");
            entity.Property(e => e.Sat1pbrm).HasColumnName("sat1pbrm");
            entity.Property(e => e.Sat2fiy).HasColumnName("sat2fiy");
            entity.Property(e => e.Sat2pbrm).HasColumnName("sat2pbrm");
            entity.Property(e => e.Sat3fiy).HasColumnName("sat3fiy");
            entity.Property(e => e.Sat3pbrm).HasColumnName("sat3pbrm");
            entity.Property(e => e.Sat4fiy).HasColumnName("sat4fiy");
            entity.Property(e => e.Sat4pbrm).HasColumnName("sat4pbrm");
            entity.Property(e => e.Stokad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("stokad");
            entity.Property(e => e.Stokkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stokkod");
        });

        modelBuilder.Entity<MsgAck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Msg_Ack__3213E83F6540D10D");

            entity.ToTable("Msg_Ack");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AckAl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack_al");
            entity.Property(e => e.AckEn)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack_en");
            entity.Property(e => e.AckRu)
                .HasMaxLength(100)
                .HasColumnName("ack_ru");
            entity.Property(e => e.AckTr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack_tr");
            entity.Property(e => e.FrmId).HasColumnName("frm_id");
            entity.Property(e => e.No).HasColumnName("no");
            entity.Property(e => e.Tip).HasColumnName("tip");
        });

        modelBuilder.Entity<Numarator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__numarato__3213E83FDB48B30D");

            entity.ToTable("numarator");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Numara)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("numara");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Seri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seri");
            entity.Property(e => e.Tip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Tipack)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipack");
            entity.Property(e => e.Uzunluk).HasColumnName("uzunluk");
        });

        modelBuilder.Entity<Okunanotodosya>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("okunanotodosya");

            entity.Property(e => e.Aktarkayit).HasColumnName("aktarkayit");
            entity.Property(e => e.Bastarih)
                .HasColumnType("datetime")
                .HasColumnName("bastarih");
            entity.Property(e => e.Dosya)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("dosya");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Otomasad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("otomasad");
            entity.Property(e => e.Sontarih)
                .HasColumnType("datetime")
                .HasColumnName("sontarih");
            entity.Property(e => e.Topkayit).HasColumnName("topkayit");
        });

        modelBuilder.Entity<OtoOnlParam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__oto_onl___3213E83F7BB29C3B");

            entity.ToTable("oto_onl_param");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChGecmis).HasColumnName("ch_gecmis");
            entity.Property(e => e.FilterTip).HasColumnName("Filter_Tip");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.OtoFis)
                .HasDefaultValue(false)
                .HasColumnName("Oto_Fis");
            entity.Property(e => e.Otomasad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("otomasad");
            entity.Property(e => e.PrintFisSayi)
                .HasDefaultValue(1)
                .HasColumnName("Print_Fis_Sayi");
            entity.Property(e => e.Satir).HasColumnName("satir");
            entity.Property(e => e.Sondosya)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sondosya");
            entity.Property(e => e.Sonsatirno)
                .HasDefaultValue(0)
                .HasColumnName("sonsatirno");
            entity.Property(e => e.Sontarih)
                .HasColumnType("datetime")
                .HasColumnName("sontarih");
            entity.Property(e => e.Sure)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sure");
            entity.Property(e => e.Tip).HasColumnName("tip");
            entity.Property(e => e.YenileCh).HasColumnName("yenile_ch");
            entity.Property(e => e.YenileSure)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("yenile_sure");
        });

        modelBuilder.Entity<OtomasSati>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Otomasid, e.Tarih, e.Saat }).HasName("PK__Otomas_S__E8812104BB05B71B");

            entity.ToTable("Otomas_Satis");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Otomasid).HasColumnName("otomasid");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Adano)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("adano");
            entity.Property(e => e.Brimfiy)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("brimfiy");
            entity.Property(e => e.Carad)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("carad");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.FisNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Km)
                .HasDefaultValue(0.0)
                .HasColumnName("km");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("miktar");
            entity.Property(e => e.Perad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Plaka)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plaka");
            entity.Property(e => e.Sayackod)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("sayackod");
            entity.Property(e => e.Tabanca)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("tabanca");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("tutar");
            entity.Property(e => e.Varno)
                .HasDefaultValue(0.0)
                .HasColumnName("varno");
            entity.Property(e => e.Yakit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("yakit");
            entity.Property(e => e.Ykodemetip)
                .HasDefaultValue(0)
                .HasColumnName("ykodemetip");
        });

        modelBuilder.Entity<OtomasWebServisHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OtomasWe__3213E83F484974FD");

            entity.ToTable("OtomasWebServisHrk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BrmFiyat).HasDefaultValue(0.0);
            entity.Property(e => e.FisNo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Miktar).HasDefaultValue(0.0);
            entity.Property(e => e.OdemeTip).HasDefaultValue(0);
            entity.Property(e => e.OtomasTip)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PersonelKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PersonelUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Plaka)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
            entity.Property(e => e.Tutar).HasDefaultValue(0.0);
            entity.Property(e => e.YakitUnvan)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Otomasdosya>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__otomasdo__3213E83FC6F5701D");

            entity.ToTable("otomasdosya");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aktarim).HasColumnName("aktarim");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Dosya)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dosya");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otomastip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("otomastip");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
        });

        modelBuilder.Entity<Otomasgenkod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__otomasge__3213E83F1E7939EF");

            entity.ToTable("otomasgenkod", tb =>
                {
                    tb.HasTrigger("otomasgenkod_log_trd");
                    tb.HasTrigger("otomasgenkod_log_tri");
                    tb.HasTrigger("otomasgenkod_log_tru");
                });

            entity.HasIndex(e => e.Cartip, "otomasgenkod_idx");

            entity.HasIndex(e => e.Kod, "otomasgenkod_idx2");

            entity.HasIndex(e => e.Plaka, "otomasgenkod_index3");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.FisGrs).HasColumnName("Fis_Grs");
            entity.Property(e => e.Hrktip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("hrktip");
            entity.Property(e => e.Kartno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kartno");
            entity.Property(e => e.Km).HasDefaultValue(0.0);
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Limit).HasColumnName("limit");
            entity.Property(e => e.Limitturu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("limitturu");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.OtoFis).HasDefaultValue(false);
            entity.Property(e => e.Otomaskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("otomaskod");
            entity.Property(e => e.Otomastip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("otomastip");
            entity.Property(e => e.Perkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("perkod");
            entity.Property(e => e.Plaka)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("plaka");
            entity.Property(e => e.PlakaGidKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Plaka_Gid_Kod");
            entity.Property(e => e.PromGrs).HasColumnName("Prom_Grs");
            entity.Property(e => e.RemoteId).HasColumnName("Remote_id");
            entity.Property(e => e.Stkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stkod");
        });

        modelBuilder.Entity<Otomaskart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Otmaskod }).HasName("PK__otomaska__FAA2E7A82FE9E4D1");

            entity.ToTable("otomaskart", tb =>
                {
                    tb.HasTrigger("otomaskart_log_trd");
                    tb.HasTrigger("otomaskart_log_tri");
                    tb.HasTrigger("otomaskart_log_tru");
                    tb.HasTrigger("otomaskart_trd");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Otmaskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("otmaskod");
            entity.Property(e => e.Basid)
                .HasDefaultValue(0.0)
                .HasColumnName("basid");
            entity.Property(e => e.Bassatir).HasColumnName("bassatir");
            entity.Property(e => e.Beg)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("beg");
            entity.Property(e => e.CariFisNakitCevir).HasDefaultValue(false);
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Dostan)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("dostan");
            entity.Property(e => e.Dosuznti)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("dosuznti");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Host)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("host");
            entity.Property(e => e.KartanPlaka)
                .HasDefaultValue(false)
                .HasColumnName("Kartan_Plaka");
            entity.Property(e => e.Klasor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("klasor");
            entity.Property(e => e.Olustar)
                .HasColumnType("datetime")
                .HasColumnName("olustar");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otofiload)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("otofiload");
            entity.Property(e => e.OtomasGift).HasDefaultValue(false);
            entity.Property(e => e.OtomasGiftcari)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OtomasPartner).HasDefaultValue(false);
            entity.Property(e => e.OtomasPartnercari)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("otomasPartnercari");
            entity.Property(e => e.Otomascari)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("otomascari");
            entity.Property(e => e.Otomascartip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("otomascartip");
            entity.Property(e => e.Otomasper)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("otomasper");
            entity.Property(e => e.Pass)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pass");
            entity.Property(e => e.SaleTag)
                .HasDefaultValue((byte)0)
                .HasColumnName("Sale_Tag");
            entity.Property(e => e.Sonid)
                .HasDefaultValue(0.0)
                .HasColumnName("sonid");
            entity.Property(e => e.SubeKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sube_kod");
            entity.Property(e => e.Tarformat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tarformat");
            entity.Property(e => e.TtsKey)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tts_Key");
            entity.Property(e => e.Ttsseri)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TTSSeri");
            entity.Property(e => e.Users)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("users");
        });

        modelBuilder.Entity<Otomaskarthrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Otmaskod }).HasName("PK__otomaska__FAA2E7A84B9792AE");

            entity.ToTable("otomaskarthrk", tb =>
                {
                    tb.HasTrigger("otomaskarthrk_log_trd");
                    tb.HasTrigger("otomaskarthrk_log_tri");
                    tb.HasTrigger("otomaskarthrk_log_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Otmaskod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("otmaskod");
            entity.Property(e => e.Ad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Iptkar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("iptkar");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Oku).HasColumnName("oku");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Onpos).HasColumnName("onpos");
            entity.Property(e => e.Onuzn).HasColumnName("onuzn");
            entity.Property(e => e.Pos).HasColumnName("pos");
            entity.Property(e => e.Sr)
                .HasDefaultValue(1)
                .HasColumnName("sr");
            entity.Property(e => e.Uzn).HasColumnName("uzn");
        });

        modelBuilder.Entity<Otomasoku>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Otomasid, e.Tarih, e.Saat }).HasName("PK__otomasok__E8812104EFB90C3A");

            entity.ToTable("otomasoku");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Otomasid).HasColumnName("otomasid");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Adano)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("adano");
            entity.Property(e => e.Aktar).HasColumnName("aktar");
            entity.Property(e => e.Aktarid)
                .HasDefaultValue(0)
                .HasColumnName("aktarid");
            entity.Property(e => e.Brimfiy)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("brimfiy");
            entity.Property(e => e.Carad)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("carad");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Dosya)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("dosya");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Fisno).HasColumnName("fisno");
            entity.Property(e => e.Km).HasColumnName("km");
            entity.Property(e => e.Kodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kodu");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(10, 5)")
                .HasColumnName("miktar");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.OtoAck)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("oto_ack");
            entity.Property(e => e.OtoFis).HasDefaultValue(false);
            entity.Property(e => e.OtoMiktar).HasColumnName("oto_miktar");
            entity.Property(e => e.Otocarad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("otocarad");
            entity.Property(e => e.Otomasad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("otomasad");
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Plaka)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plaka");
            entity.Property(e => e.Promid).HasDefaultValue(0L);
            entity.Property(e => e.Sattip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sattip");
            entity.Property(e => e.Sayackod)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("sayackod");
            entity.Property(e => e.Stkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Tabanca)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("tabanca");
            entity.Property(e => e.Tag).HasColumnName("tag");
            entity.Property(e => e.Tankod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tankod");
            entity.Property(e => e.Tip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("tutar");
            entity.Property(e => e.Unvan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("unvan");
            entity.Property(e => e.Utts)
                .HasDefaultValue(false)
                .HasColumnName("UTTS");
            entity.Property(e => e.Varno)
                .HasDefaultValue(0.0)
                .HasColumnName("varno");
            entity.Property(e => e.Yakit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("yakit");
            entity.Property(e => e.Ykodemetip)
                .HasDefaultValue(0)
                .HasColumnName("ykodemetip");
        });

        modelBuilder.Entity<Otomasonlineoku>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Otomasid, e.Tarih, e.Saat }).HasName("PK__otomason__E8812104E9EB860E");

            entity.ToTable("otomasonlineoku", tb => tb.HasTrigger("otomasonlineoku_trd"));

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Otomasid).HasColumnName("otomasid");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Adano)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("adano");
            entity.Property(e => e.Aktar).HasColumnName("aktar");
            entity.Property(e => e.Aktarid)
                .HasDefaultValue(0L)
                .HasColumnName("aktarid");
            entity.Property(e => e.Brimfiy)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("brimfiy");
            entity.Property(e => e.Carad)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("carad");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Dosya)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("dosya");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Fisno).HasColumnName("fisno");
            entity.Property(e => e.Islem).HasColumnName("islem");
            entity.Property(e => e.Km)
                .HasDefaultValue(0)
                .HasColumnName("km");
            entity.Property(e => e.Kodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kodu");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(10, 5)")
                .HasColumnName("miktar");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.OtoAck)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("oto_ack");
            entity.Property(e => e.OtoFis).HasDefaultValue(false);
            entity.Property(e => e.OtoFisYazdir).HasDefaultValue(false);
            entity.Property(e => e.OtoFisYazdirTarSaat).HasColumnType("datetime");
            entity.Property(e => e.OtoMiktar).HasColumnName("oto_miktar");
            entity.Property(e => e.Otocarad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("otocarad");
            entity.Property(e => e.Otomasad)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("otomasad");
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Plaka)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plaka");
            entity.Property(e => e.Promid).HasDefaultValue(0L);
            entity.Property(e => e.Sattip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sattip");
            entity.Property(e => e.Sayackod)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("sayackod");
            entity.Property(e => e.Stkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Tabanca)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("tabanca");
            entity.Property(e => e.Tag).HasColumnName("tag");
            entity.Property(e => e.Tankod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tankod");
            entity.Property(e => e.Tip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("tutar");
            entity.Property(e => e.Unvan)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("unvan");
            entity.Property(e => e.Utts)
                .HasDefaultValue(false)
                .HasColumnName("UTTS");
            entity.Property(e => e.Varno)
                .HasDefaultValue(0.0)
                .HasColumnName("varno");
            entity.Property(e => e.Yakit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("yakit");
            entity.Property(e => e.Ykodemetip)
                .HasDefaultValue(0)
                .HasColumnName("ykodemetip");
        });

        modelBuilder.Entity<Otomaspumphrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__otomaspu__3213E83FA4143485");

            entity.ToTable("otomaspumphrk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BirimFiyat)
                .HasDefaultValue(0.0)
                .HasColumnName("Birim_Fiyat");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Dosya)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("dosya");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.KayitTarSaat)
                .HasColumnType("datetime")
                .HasColumnName("Kayit_Tar_Saat");
            entity.Property(e => e.Litre).HasDefaultValue(0.0);
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otomasid).HasColumnName("otomasid");
            entity.Property(e => e.PerKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Per_Kod");
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.SayacKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Sayac_Kod");
            entity.Property(e => e.StokKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Stok_Kod");
            entity.Property(e => e.TankKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Tank_kod");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Tutar).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<Otomaspumptan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__otomaspu__3213E83F0380D9C5");

            entity.ToTable("otomaspumptan");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Sira).HasColumnName("sira");
            entity.Property(e => e.Tip).HasColumnName("tip");
        });

        modelBuilder.Entity<Otomastip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__otomasti__3213E83F4F2F71AB");

            entity.ToTable("otomastip");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Dosyatip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("dosyatip");
            entity.Property(e => e.Onli)
                .HasDefaultValue(0)
                .HasColumnName("onli");
        });

        modelBuilder.Entity<OzelFisTablo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ozel_fis__3213E83FE73372A8");

            entity.ToTable("Ozel_fis_tablo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Tip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tip");
        });

        modelBuilder.Entity<OzelKod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ozel_Kod__3213E83FCBBB4854");

            entity.ToTable("Ozel_Kod");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Tip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tip");
        });

        modelBuilder.Entity<ParaKur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__para_kur__3213E83F805274C9");

            entity.ToTable("para_kur");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.DovAlis).HasColumnName("dov_alis");
            entity.Property(e => e.DovSatis).HasColumnName("dov_satis");
            entity.Property(e => e.EfkAlis).HasColumnName("efk_alis");
            entity.Property(e => e.EfkSatis).HasColumnName("efk_satis");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
        });

        modelBuilder.Entity<Parabrm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__parabrm__3213E83FB9CA0BC8");

            entity.ToTable("parabrm", tb => tb.HasTrigger("parabrm_tri"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Kod)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.KurusKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kurus_kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sabit).HasColumnName("sabit");
        });

        modelBuilder.Entity<Parametre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Parametre");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Bolum)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Deger)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.UserKod)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PdaFaturaSayimHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pda_Fatu__3213E83F4B6F9CED");

            entity.ToTable("Pda_FaturaSayim_Hrk", tb => tb.HasTrigger("Pda_FaturaSayim_Hrk_triu"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fatsayid).HasColumnName("fatsayid");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Miktar).HasColumnName("miktar");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.StkBarkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stk_barkod");
            entity.Property(e => e.StkKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stk_kod");
            entity.Property(e => e.StkTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stk_tip");
        });

        modelBuilder.Entity<PdaFaturaSayimMa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pda_Fatu__3213E83F5559846B");

            entity.ToTable("Pda_FaturaSayim_Mas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.BarCapran)
                .HasDefaultValue(1.0)
                .HasColumnName("bar_capran");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Drm)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.StkTopMik)
                .HasDefaultValue(0.0)
                .HasColumnName("Stk_Top_Mik");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
        });

        modelBuilder.Entity<PdaOffSayimHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pda_OffS__3213E83FB982035F");

            entity.ToTable("Pda_OffSayim_Hrk", tb => tb.HasTrigger("Pda_OffSayim_Hrk_triu"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Kaymiktar)
                .HasDefaultValue(0.0)
                .HasColumnName("kaymiktar");
            entity.Property(e => e.Miktar).HasColumnName("miktar");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.StkBarkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stk_barkod");
            entity.Property(e => e.StkKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stk_kod");
            entity.Property(e => e.StkTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stk_tip");
        });

        modelBuilder.Entity<PdaOffSayimMa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pda_OffS__3213E83F667D78B8");

            entity.ToTable("Pda_OffSayim_Mas", tb => tb.HasTrigger("Pda_OffSayim_Mas_trd"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Aktarid)
                .HasDefaultValue(0.0)
                .HasColumnName("aktarid");
            entity.Property(e => e.Aktartarsaat)
                .HasColumnType("datetime")
                .HasColumnName("aktartarsaat");
            entity.Property(e => e.Aktaruser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("aktaruser");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.StkTopMik)
                .HasDefaultValue(0.0)
                .HasColumnName("Stk_Top_Mik");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
        });

        modelBuilder.Entity<PerCari>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Per_Cari__3213E83F7E1ABB8E");

            entity.ToTable("Per_Cari", tb =>
                {
                    tb.HasTrigger("Per_Cari_trd");
                    tb.HasTrigger("Per_Cari_triu");
                });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.CarKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("car_kod");
            entity.Property(e => e.CarTipId).HasColumnName("CarTip_id");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.PerId).HasColumnName("Per_id");
            entity.Property(e => e.PerKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Per_Kod");
        });

        modelBuilder.Entity<PerakendeKartListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Perakende_Kart_listesi");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.Adres2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("adres2");
            entity.Property(e => e.CarBakiye).HasColumnName("car_bakiye");
            entity.Property(e => e.Carbak).HasColumnName("carbak");
            entity.Property(e => e.Cep)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cep");
            entity.Property(e => e.Dataok).HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.DogumTarih).HasColumnType("datetime");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Efatura).HasColumnName("EFatura");
            entity.Property(e => e.Evil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evil");
            entity.Property(e => e.Evilce)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evilce");
            entity.Property(e => e.Fatunvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("fatunvan");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.FisAdet).HasColumnName("fis_adet");
            entity.Property(e => e.FisBakiye).HasColumnName("fis_bakiye");
            entity.Property(e => e.Fisadet).HasColumnName("fisadet");
            entity.Property(e => e.Fisbak).HasColumnName("fisbak");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.Grup).HasMaxLength(100);
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Ilgili)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ilgili");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Kulkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kulkod");
            entity.Property(e => e.Kulsif)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kulsif");
            entity.Property(e => e.Mail)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.PromGrp1).HasColumnName("Prom_Grp1");
            entity.Property(e => e.Resim)
                .HasColumnType("image")
                .HasColumnName("resim");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.SonFisTarih)
                .HasColumnType("datetime")
                .HasColumnName("son_fis_tarih");
            entity.Property(e => e.SonFisTutar).HasColumnName("son_fis_tutar");
            entity.Property(e => e.SonhrkTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonhrk_tarih");
            entity.Property(e => e.Soyad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("soyad");
            entity.Property(e => e.Tcno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tcno");
            entity.Property(e => e.Tel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.TicSicilNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TopBakiye).HasColumnName("top_bakiye");
            entity.Property(e => e.Topbak).HasColumnName("topbak");
            entity.Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("unvan");
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("vergidaire");
            entity.Property(e => e.Vergieposta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vergieposta");
            entity.Property(e => e.Vergino)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("vergino");
            entity.Property(e => e.Webextre).HasColumnName("webextre");
        });

        modelBuilder.Entity<Perakendekart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod, e.Sil, e.Firmano }).HasName("PK__perakend__DAB2FC2B8DD86140");

            entity.ToTable("perakendekart", tb =>
                {
                    tb.HasTrigger("perakendekart_log_trd");
                    tb.HasTrigger("perakendekart_log_tri");
                    tb.HasTrigger("perakendekart_log_tru");
                    tb.HasTrigger("perakendekart_tri");
                    tb.HasTrigger("perakendekart_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.Adres2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("adres2");
            entity.Property(e => e.Carbak)
                .HasDefaultValue(0.0)
                .HasColumnName("carbak");
            entity.Property(e => e.Cep)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cep");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.DogumTarih).HasColumnType("datetime");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Efatura)
                .HasDefaultValue(false)
                .HasColumnName("EFatura");
            entity.Property(e => e.EfaturaTip).HasDefaultValue(0);
            entity.Property(e => e.Evil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evil");
            entity.Property(e => e.Evilce)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evilce");
            entity.Property(e => e.Fatunvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("fatunvan");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.Fisadet)
                .HasDefaultValue(0)
                .HasColumnName("fisadet");
            entity.Property(e => e.Fisbak)
                .HasDefaultValue(0.0)
                .HasColumnName("fisbak");
            entity.Property(e => e.Grp1)
                .HasDefaultValue(0)
                .HasColumnName("grp1");
            entity.Property(e => e.Grp2)
                .HasDefaultValue(0)
                .HasColumnName("grp2");
            entity.Property(e => e.Grp3)
                .HasDefaultValue(0)
                .HasColumnName("grp3");
            entity.Property(e => e.Ilgili)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ilgili");
            entity.Property(e => e.Kulkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kulkod");
            entity.Property(e => e.Kulsif)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kulsif");
            entity.Property(e => e.Mail)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.PromGrp1).HasColumnName("Prom_Grp1");
            entity.Property(e => e.Resim)
                .HasColumnType("image")
                .HasColumnName("resim");
            entity.Property(e => e.Soyad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("soyad");
            entity.Property(e => e.Tcno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tcno");
            entity.Property(e => e.Tel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.TicSicilNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("unvan");
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("vergidaire");
            entity.Property(e => e.Vergieposta)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vergieposta");
            entity.Property(e => e.Vergino)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("vergino");
            entity.Property(e => e.Webextre).HasColumnName("webextre");
        });

        modelBuilder.Entity<Perkart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod }).HasName("PK__perkart__DFEE66863F6B1DD2");

            entity.ToTable("perkart", tb =>
                {
                    tb.HasTrigger("perkart_log_trd");
                    tb.HasTrigger("perkart_log_tri");
                    tb.HasTrigger("perkart_log_tru");
                    tb.HasTrigger("perkart_tri");
                    tb.HasTrigger("perkart_tru");
                });

            entity.HasIndex(e => e.Kod, "perkart_uq").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Actutar)
                .HasDefaultValue(0.0)
                .HasColumnName("actutar");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.Adres2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("adres2");
            entity.Property(e => e.BankaAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("banka_ad");
            entity.Property(e => e.BankaSube)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("banka_sube");
            entity.Property(e => e.Carbak)
                .HasDefaultValue(0.0)
                .HasColumnName("carbak");
            entity.Property(e => e.Cep)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cep");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Evil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evil");
            entity.Property(e => e.Evilce)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evilce");
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.FileName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Fisadet)
                .HasDefaultValue(0)
                .HasColumnName("fisadet");
            entity.Property(e => e.Fisakadet)
                .HasDefaultValue(0)
                .HasColumnName("fisakadet");
            entity.Property(e => e.Fisaktut)
                .HasDefaultValue(0.0)
                .HasColumnName("fisaktut");
            entity.Property(e => e.Fisbak)
                .HasDefaultValue(0.0)
                .HasColumnName("fisbak");
            entity.Property(e => e.Gos)
                .HasDefaultValue(1)
                .HasColumnName("gos");
            entity.Property(e => e.Grp1)
                .HasDefaultValue(0)
                .HasColumnName("grp1");
            entity.Property(e => e.Grp2)
                .HasDefaultValue(0)
                .HasColumnName("grp2");
            entity.Property(e => e.Grp3)
                .HasDefaultValue(0)
                .HasColumnName("grp3");
            entity.Property(e => e.Hesapno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hesapno");
            entity.Property(e => e.Isbastar)
                .HasColumnType("datetime")
                .HasColumnName("isbastar");
            entity.Property(e => e.Isbittar)
                .HasColumnType("datetime")
                .HasColumnName("isbittar");
            entity.Property(e => e.Isk)
                .HasDefaultValue(0.0)
                .HasColumnName("isk");
            entity.Property(e => e.KasiyerKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.KulKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KulSifre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LimitTip)
                .HasDefaultValue(0)
                .HasColumnName("limit_tip");
            entity.Property(e => e.Maas)
                .HasDefaultValue(0.0)
                .HasColumnName("maas");
            entity.Property(e => e.Maasgun)
                .HasDefaultValue(1.0)
                .HasColumnName("maasgun");
            entity.Property(e => e.Mail)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Prim)
                .HasDefaultValue(0.0)
                .HasColumnName("prim");
            entity.Property(e => e.Resim)
                .HasColumnType("image")
                .HasColumnName("resim");
            entity.Property(e => e.Sgkno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sgkno");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Soyad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("soyad");
            entity.Property(e => e.Tcno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tcno");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.Toplim)
                .HasDefaultValue(0.0)
                .HasColumnName("toplim");
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("vergidaire");
            entity.Property(e => e.Vergino)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("vergino");
        });

        modelBuilder.Entity<Permaashrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__permaash__3213E83F6855BAB2");

            entity.ToTable("permaashrk", tb =>
                {
                    tb.HasTrigger("permaashrk_log_trd");
                    tb.HasTrigger("permaashrk_log_tri");
                    tb.HasTrigger("permaashrk_log_tru");
                    tb.HasTrigger("permaashrk_triu");
                });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Belno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Gidkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("gidkod");
            entity.Property(e => e.Kur).HasColumnName("kur");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Permaashrkid).HasColumnName("permaashrkid");
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil)
                .HasDefaultValue((byte)0)
                .HasColumnName("sil");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Tutar).HasColumnName("tutar");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<PersonelKartListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Personel_Kart_Listesi");

            entity.Property(e => e.Actutar).HasColumnName("actutar");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.Adres2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("adres2");
            entity.Property(e => e.BankaAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("banka_ad");
            entity.Property(e => e.BankaSube)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("banka_sube");
            entity.Property(e => e.CarBakiye).HasColumnName("car_bakiye");
            entity.Property(e => e.Carbak).HasColumnName("carbak");
            entity.Property(e => e.CekharcBakiye).HasColumnName("cekharc_bakiye");
            entity.Property(e => e.Cep)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cep");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Evil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evil");
            entity.Property(e => e.Evilce)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evilce");
            entity.Property(e => e.Fax)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.Firmaad)
                .HasMaxLength(100)
                .HasColumnName("firmaad");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.FisAdet).HasColumnName("fis_adet");
            entity.Property(e => e.FisBakiye).HasColumnName("fis_bakiye");
            entity.Property(e => e.Fisadet).HasColumnName("fisadet");
            entity.Property(e => e.Fisakadet).HasColumnName("fisakadet");
            entity.Property(e => e.Fisaktut).HasColumnName("fisaktut");
            entity.Property(e => e.Fisbak).HasColumnName("fisbak");
            entity.Property(e => e.Gos).HasColumnName("gos");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.Grup)
                .HasMaxLength(100)
                .HasColumnName("grup");
            entity.Property(e => e.Hesapno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hesapno");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Isbastar)
                .HasColumnType("datetime")
                .HasColumnName("isbastar");
            entity.Property(e => e.Isbittar)
                .HasColumnType("datetime")
                .HasColumnName("isbittar");
            entity.Property(e => e.Isk).HasColumnName("isk");
            entity.Property(e => e.KasiyerKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.LimitTip).HasColumnName("limit_tip");
            entity.Property(e => e.Maas).HasColumnName("maas");
            entity.Property(e => e.Maasgun).HasColumnName("maasgun");
            entity.Property(e => e.Mail)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Prim).HasColumnName("prim");
            entity.Property(e => e.Resim)
                .HasColumnType("image")
                .HasColumnName("resim");
            entity.Property(e => e.Sgkno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sgkno");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.SonFisTarih)
                .HasColumnType("datetime")
                .HasColumnName("son_fis_tarih");
            entity.Property(e => e.SonFisTutar).HasColumnName("son_fis_tutar");
            entity.Property(e => e.SonhrkTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonhrk_tarih");
            entity.Property(e => e.Soyad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("soyad");
            entity.Property(e => e.Tcno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tcno");
            entity.Property(e => e.Tel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.TopBakiye).HasColumnName("top_bakiye");
            entity.Property(e => e.Topbak).HasColumnName("topbak");
            entity.Property(e => e.Toplim).HasColumnName("toplim");
            entity.Property(e => e.Unvan)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("unvan");
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("vergidaire");
            entity.Property(e => e.Vergino)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("vergino");
        });

        modelBuilder.Entity<PersonelMaasListe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Personel_Maas_Liste");

            entity.Property(e => e.Ack)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Belno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.Carhrkid).HasColumnName("carhrkid");
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Devir).HasColumnName("devir");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmhrkad)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("islmhrkad");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Permasmasid).HasColumnName("permasmasid");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Tutar).HasColumnName("tutar");
            entity.Property(e => e.Unvan)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("unvan");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<PlakaLimitCariMiktar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Plaka_Limit_Cari_Miktar");

            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Lttutar).HasColumnName("lttutar");
            entity.Property(e => e.Miktarlt).HasColumnName("miktarlt");
        });

        modelBuilder.Entity<PlakaLimitMiktar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Plaka_Limit_Miktar");

            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Lttutar).HasColumnName("lttutar");
            entity.Property(e => e.Miktarlt).HasColumnName("miktarlt");
            entity.Property(e => e.Plaka)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plaka");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
        });

        modelBuilder.Entity<Pomvardikap>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno }).HasName("PK__pomvardi__76322BA20C31E407");

            entity.ToTable("pomvardikap", tb =>
                {
                    tb.HasTrigger("pomvardikap_log_trd");
                    tb.HasTrigger("pomvardikap_log_tri");
                    tb.HasTrigger("pomvardikap_log_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Ackfaz)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ackfaz");
            entity.Property(e => e.Cartip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Kaptip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kaptip");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("Remote_id");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.Tutar).HasColumnName("tutar");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
        });

        modelBuilder.Entity<Pomvardima>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno }).HasName("PK__pomvardi__76322BA21ACEE08A");

            entity.ToTable("pomvardimas", tb =>
                {
                    tb.HasTrigger("pomvardimas_log_trd");
                    tb.HasTrigger("pomvardimas_log_tri");
                    tb.HasTrigger("pomvardimas_log_tru");
                    tb.HasTrigger("pomvardimas_trd");
                    tb.HasTrigger("pomvardimas_tri");
                    tb.HasTrigger("pomvardimas_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Adabag)
                .HasDefaultValue(0)
                .HasColumnName("adabag");
            entity.Property(e => e.Admin).HasDefaultValue(false);
            entity.Property(e => e.Aksatmik)
                .HasDefaultValue(0.0)
                .HasColumnName("aksatmik");
            entity.Property(e => e.Aksattop)
                .HasDefaultValue(0.0)
                .HasColumnName("aksattop");
            entity.Property(e => e.AracSayi).HasDefaultValue(0);
            entity.Property(e => e.Bankatop)
                .HasDefaultValue(0.0)
                .HasColumnName("bankatop");
            entity.Property(e => e.Cektop)
                .HasDefaultValue(0.0)
                .HasColumnName("cektop");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.EntegreAktar)
                .HasColumnType("datetime")
                .HasColumnName("entegre_aktar");
            entity.Property(e => e.EntegreBelgeNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EntegreTip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("entegre_tip");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Gelirtop)
                .HasDefaultValue(0.0)
                .HasColumnName("gelirtop");
            entity.Property(e => e.Gidertop)
                .HasDefaultValue(0.0)
                .HasColumnName("gidertop");
            entity.Property(e => e.Kapsaat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("kapsaat");
            entity.Property(e => e.Kaptar)
                .HasColumnType("datetime")
                .HasColumnName("kaptar");
            entity.Property(e => e.Malsattop)
                .HasDefaultValue(0.0)
                .HasColumnName("malsattop");
            entity.Property(e => e.Naktestop)
                .HasDefaultValue(0.0)
                .HasColumnName("naktestop");
            entity.Property(e => e.Odetop)
                .HasDefaultValue(0.0)
                .HasColumnName("odetop");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otocheck)
                .HasDefaultValue(0)
                .HasColumnName("otocheck");
            entity.Property(e => e.Otomasmik).HasColumnName("otomasmik");
            entity.Property(e => e.Otomastop)
                .HasDefaultValue(0.0)
                .HasColumnName("otomastop");
            entity.Property(e => e.Poscartop)
                .HasDefaultValue(0.0)
                .HasColumnName("poscartop");
            entity.Property(e => e.Postop)
                .HasDefaultValue(0.0)
                .HasColumnName("postop");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Tahtop)
                .HasDefaultValue(0.0)
                .HasColumnName("tahtop");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.Varackfaztip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("varackfaztip");
            entity.Property(e => e.Varad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("varad");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
            entity.Property(e => e.Veresimik)
                .HasDefaultValue(0.0)
                .HasColumnName("veresimik");
            entity.Property(e => e.Veresitop)
                .HasDefaultValue(0.0)
                .HasColumnName("veresitop");
        });

        modelBuilder.Entity<Pomvardiozet>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno }).HasName("PK__pomvardi__76322BA211933C9A");

            entity.ToTable("pomvardiozet");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Bakiye)
                .HasDefaultValue(0.0)
                .HasColumnName("bakiye");
            entity.Property(e => e.Cikis)
                .HasDefaultValue(0.0)
                .HasColumnName("cikis");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Giris)
                .HasDefaultValue(0.0)
                .HasColumnName("giris");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("Remote_id");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Sr).HasColumnName("sr");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Tipack)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipack");
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.Varok).HasColumnName("varok");
        });

        modelBuilder.Entity<Pomvardiper>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno }).HasName("PK__pomvardi__76322BA2167FF443");

            entity.ToTable("pomvardiper", tb =>
                {
                    tb.HasTrigger("pomvardiper_log_trd");
                    tb.HasTrigger("pomvardiper_log_tri");
                    tb.HasTrigger("pomvardiper_log_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.GecPerKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Gec_PerKod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Per)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("per");
            entity.Property(e => e.Perackfaz)
                .HasDefaultValue(0.0)
                .HasColumnName("perackfaz");
            entity.Property(e => e.Perad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("perad");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("Remote_id");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Sr)
                .HasDefaultValue(0)
                .HasColumnName("sr");
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
        });

        modelBuilder.Entity<Pomvardiperadum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno }).HasName("PK__pomvardi__76322BA255FD4993");

            entity.ToTable("pomvardiperada", tb =>
                {
                    tb.HasTrigger("pomvardiperada_log_trd");
                    tb.HasTrigger("pomvardiperada_log_tri");
                    tb.HasTrigger("pomvardiperada_log_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Adad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("adad");
            entity.Property(e => e.Adaid).HasColumnName("adaid");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Per)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("per");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("Remote_id");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Sr)
                .HasDefaultValue(0)
                .HasColumnName("sr");
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
        });

        modelBuilder.Entity<Pomvardirapgoster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pomvardirapgoster");

            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.FilitreDegerIn)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("Filitre_DegerIn");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RapTip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Rap_Tip");
        });

        modelBuilder.Entity<Pomvardisayac>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno }).HasName("PK__pomvardi__76322BA2F3CC55C8");

            entity.ToTable("pomvardisayac", tb =>
                {
                    tb.HasTrigger("pomvardisayac_log_trd");
                    tb.HasTrigger("pomvardisayac_log_tri");
                    tb.HasTrigger("pomvardisayac_log_tru");
                    tb.HasTrigger("pomvardisayac_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Adad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("adad");
            entity.Property(e => e.Adaid).HasColumnName("adaid");
            entity.Property(e => e.Brimfiy)
                .HasColumnType("decimal(38, 14)")
                .HasColumnName("brimfiy");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Digermik)
                .HasDefaultValue(0.0)
                .HasColumnName("digermik");
            entity.Property(e => e.Enktur)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("enktur");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.GecPerKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Gec_PerKod");
            entity.Property(e => e.Ilkendk).HasColumnName("ilkendk");
            entity.Property(e => e.Kdvyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("kdvyuz");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otomaskod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("otomaskod");
            entity.Property(e => e.Perad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("perad");
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("Remote_id");
            entity.Property(e => e.Satmik).HasColumnName("satmik");
            entity.Property(e => e.Sayacad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sayacad");
            entity.Property(e => e.Sayackod)
                .HasMaxLength(53)
                .IsUnicode(false)
                .HasColumnName("sayackod");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Sonendk).HasColumnName("sonendk");
            entity.Property(e => e.Stkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.Tankod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tankod");
            entity.Property(e => e.Testmik)
                .HasDefaultValue(0.0)
                .HasColumnName("testmik");
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.Transfermik)
                .HasDefaultValue(0.0)
                .HasColumnName("transfermik");
            entity.Property(e => e.Transfertank)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("transfertank");
            entity.Property(e => e.Tutar).HasColumnName("tutar");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
        });

        modelBuilder.Entity<Pomvardistok>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno, e.Kod }).HasName("PK__pomvardi__E8EDF349887FACA6");

            entity.ToTable("pomvardistok");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Acmik).HasColumnName("acmik");
            entity.Property(e => e.Brimfiy)
                .HasColumnType("decimal(38, 14)")
                .HasColumnName("brimfiy");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Kalan).HasColumnName("kalan");
            entity.Property(e => e.Kdvyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("kdvyuz");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("Remote_id");
            entity.Property(e => e.Satmik).HasColumnName("satmik");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.Testmik)
                .HasDefaultValue(0.0)
                .HasColumnName("testmik");
            entity.Property(e => e.TransferCksMik)
                .HasDefaultValue(0.0)
                .HasColumnName("transfer_cks_mik");
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferGrsMik)
                .HasDefaultValue(0.0)
                .HasColumnName("transfer_grs_mik");
            entity.Property(e => e.TransferStartId).HasDefaultValue(0);
            entity.Property(e => e.TransferStopId).HasDefaultValue(1);
            entity.Property(e => e.Tutar).HasColumnName("tutar");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
        });

        modelBuilder.Entity<Pomvarditank>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno, e.Kod }).HasName("PK__pomvardi__E8EDF349CB69A932");

            entity.ToTable("pomvarditank");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Acmik).HasColumnName("acmik");
            entity.Property(e => e.Brimfiy)
                .HasColumnType("decimal(38, 14)")
                .HasColumnName("brimfiy");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Kalan).HasColumnName("kalan");
            entity.Property(e => e.Kdvyuz).HasColumnName("kdvyuz");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("Remote_id");
            entity.Property(e => e.Satmik).HasColumnName("satmik");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.Testmik)
                .HasDefaultValue(0.0)
                .HasColumnName("testmik");
            entity.Property(e => e.TransferCksMik)
                .HasDefaultValue(0.0)
                .HasColumnName("transfer_cks_mik");
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferGrsMik)
                .HasDefaultValue(0.0)
                .HasColumnName("transfer_grs_mik");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.Tutar).HasColumnName("tutar");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
        });

        modelBuilder.Entity<PosKartListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Pos_Kart_Listesi");

            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Bankad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("bankad");
            entity.Property(e => e.Bankod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bankod");
            entity.Property(e => e.Bekbak).HasColumnName("bekbak");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Exkom).HasColumnName("exkom");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Kom).HasColumnName("kom");
            entity.Property(e => e.Kombak).HasColumnName("kombak");
            entity.Property(e => e.MasGidAd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Mas_Gid_Ad");
            entity.Property(e => e.MasGidKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Mas_Gid_Kod");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Nettutar).HasColumnName("nettutar");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.VadGelen).HasColumnName("vad_gelen");
            entity.Property(e => e.Vade).HasColumnName("vade");
            entity.Property(e => e.Vadetip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vadetip");
            entity.Property(e => e.YazarKasaBankaTerminalNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Poshrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Poshrkid, e.Poskod }).HasName("PK__poshrk__585CD14C2EFD708D");

            entity.ToTable("poshrk", tb =>
                {
                    tb.HasTrigger("poshrk_log_trd");
                    tb.HasTrigger("poshrk_log_tri");
                    tb.HasTrigger("poshrk_log_tru");
                    tb.HasTrigger("poshrk_trd");
                    tb.HasTrigger("poshrk_tri");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Poshrkid).HasColumnName("poshrkid");
            entity.Property(e => e.Poskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("poskod");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Adaid).HasColumnName("adaid");
            entity.Property(e => e.Akid)
                .HasDefaultValue(0.0)
                .HasColumnName("akid");
            entity.Property(e => e.Aktar)
                .HasColumnType("datetime")
                .HasColumnName("aktar");
            entity.Property(e => e.Aktip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("BK")
                .HasColumnName("aktip");
            entity.Property(e => e.AnaId)
                .HasDefaultValue(0L)
                .HasColumnName("ana_id");
            entity.Property(e => e.Bagid)
                .HasDefaultValue(0.0)
                .HasColumnName("bagid");
            entity.Property(e => e.BankId).HasColumnName("bank_id");
            entity.Property(e => e.Bankod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("bankod");
            entity.Property(e => e.Bankomyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("bankomyuz");
            entity.Property(e => e.Belno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.BelrapId)
                .HasDefaultValue(0)
                .HasColumnName("belrap_id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.CarVadeTar)
                .HasColumnType("datetime")
                .HasColumnName("Car_VadeTar");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Carslip).HasColumnName("carslip");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Cartur)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cartur");
            entity.Property(e => e.Cikan)
                .HasDefaultValue(0.0)
                .HasColumnName("cikan");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Devir)
                .HasDefaultValue(false)
                .HasColumnName("devir");
            entity.Property(e => e.Ekkomyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("ekkomyuz");
            entity.Property(e => e.Entegre).HasDefaultValue(false);
            entity.Property(e => e.EntegreAktar)
                .HasColumnType("datetime")
                .HasColumnName("Entegre_Aktar");
            entity.Property(e => e.EntegreTip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Entegre_Tip");
            entity.Property(e => e.Extrakomyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("extrakomyuz");
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Fisfatid)
                .HasDefaultValue(0.0)
                .HasColumnName("fisfatid");
            entity.Property(e => e.Fisfattip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("KENDI")
                .HasColumnName("fisfattip");
            entity.Property(e => e.Fisid).HasColumnName("fisid");
            entity.Property(e => e.Gctip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gctip");
            entity.Property(e => e.GecPerKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Gec_PerKod");
            entity.Property(e => e.Gerialtar)
                .HasColumnType("datetime")
                .HasColumnName("gerialtar");
            entity.Property(e => e.Giren)
                .HasDefaultValue(0.0)
                .HasColumnName("giren");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmhrkad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmhrkad");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.KarsiKartKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Karsi_KartKod");
            entity.Property(e => e.KarsiKartTip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Karsi_KartTip");
            entity.Property(e => e.Krekartno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("krekartno");
            entity.Property(e => e.Kur)
                .HasDefaultValue(1.0)
                .HasColumnName("kur");
            entity.Property(e => e.Marsatid)
                .HasDefaultValue(0.0)
                .HasColumnName("marsatid");
            entity.Property(e => e.Masterid)
                .HasDefaultValue(0.0)
                .HasColumnName("masterid");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.PosId).HasColumnName("pos_id");
            entity.Property(e => e.PosIsle).HasDefaultValue(true);
            entity.Property(e => e.Pro)
                .HasDefaultValue(1)
                .HasColumnName("pro");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Tahodeid).HasColumnName("tahodeid");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Transfer).HasDefaultValue(false);
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TransferTarSaat)
                .HasColumnType("datetime")
                .HasColumnName("Transfer_TarSaat");
            entity.Property(e => e.Vadetar)
                .HasColumnType("datetime")
                .HasColumnName("vadetar");
            entity.Property(e => e.Varno)
                .HasDefaultValue(0.0)
                .HasColumnName("varno");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
            entity.Property(e => e.Yerad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Poskart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod, e.Firmano }).HasName("PK__poskart__77FA318536AAFA3A");

            entity.ToTable("poskart", tb =>
                {
                    tb.HasTrigger("poskart_log_trd");
                    tb.HasTrigger("poskart_log_tri");
                    tb.HasTrigger("poskart_log_tru");
                    tb.HasTrigger("poskart_tri");
                    tb.HasTrigger("poskart_tru");
                });

            entity.HasIndex(e => e.Kod, "poskart_uq").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Bankod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bankod");
            entity.Property(e => e.Bekbak)
                .HasDefaultValue(0.0)
                .HasColumnName("bekbak");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Exkom).HasColumnName("exkom");
            entity.Property(e => e.Gidhes)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("gidhes");
            entity.Property(e => e.Kom).HasColumnName("kom");
            entity.Property(e => e.Kombak)
                .HasDefaultValue(0.0)
                .HasColumnName("kombak");
            entity.Property(e => e.MasGidKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Mas_Gid_Kod");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.RemoteId).HasColumnName("Remote_id");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Vade).HasColumnName("vade");
            entity.Property(e => e.Vadetip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vadetip");
            entity.Property(e => e.YazarKasaBankaTerminalNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PromDahilUrunList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Prom_Dahil_Urun_List");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.PuanBrm).HasColumnName("Puan_Brm");
            entity.Property(e => e.PuanFis).HasColumnName("Puan_Fis");
            entity.Property(e => e.PuanKk).HasColumnName("Puan_kk");
            entity.Property(e => e.PuanNakit).HasColumnName("Puan_Nakit");
            entity.Property(e => e.PuanOtomas).HasColumnName("Puan_Otomas");
            entity.Property(e => e.PuanOtomas2).HasColumnName("Puan_Otomas2");
            entity.Property(e => e.PuanTip).HasColumnName("Puan_Tip");
            entity.Property(e => e.PuanTipAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Puan_Tip_Ad");
            entity.Property(e => e.SatFiyKdvli).HasColumnName("Sat_Fiy_kdvli");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.StkId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Stk_id");
            entity.Property(e => e.StokTipAd)
                .HasMaxLength(50)
                .HasColumnName("Stok_Tip_Ad");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.TipId).HasColumnName("tip_id");
        });

        modelBuilder.Entity<PromLimit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Prom_Lim__3213E83FFBBA4574");

            entity.ToTable("Prom_Limit");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.LimitKosul)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Limit_Kosul");
            entity.Property(e => e.LimitTip).HasColumnName("Limit_tip");
        });

        modelBuilder.Entity<PromMusteriListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Prom_Musteri_Listesi");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.Adres2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("adres2");
            entity.Property(e => e.AlsTutar).HasColumnName("Als_Tutar");
            entity.Property(e => e.Cartip)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Cep)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cep");
            entity.Property(e => e.CikanPuan).HasColumnName("Cikan_Puan");
            entity.Property(e => e.DogumTarih).HasColumnType("datetime");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Evil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evil");
            entity.Property(e => e.Evilce)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evilce");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.FisGrs).HasColumnName("Fis_Grs");
            entity.Property(e => e.GirenPuan).HasColumnName("Giren_Puan");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.GrupAd)
                .HasMaxLength(100)
                .HasColumnName("Grup_Ad");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Idx)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("idx");
            entity.Property(e => e.KalTutar).HasColumnName("Kal_Tutar");
            entity.Property(e => e.KartId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Kartno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kartno");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.KulTutar).HasColumnName("Kul_Tutar");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.MevcutPuan).HasColumnName("Mevcut_Puan");
            entity.Property(e => e.OtId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Ot_id");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Plaka)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("plaka");
            entity.Property(e => e.PromGrp1).HasColumnName("Prom_Grp1");
            entity.Property(e => e.PromGrs).HasColumnName("prom_Grs");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.SonTarih).HasColumnType("datetime");
            entity.Property(e => e.Soyad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("soyad");
            entity.Property(e => e.Tel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("unvan");
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vergidaire");
            entity.Property(e => e.Vergino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vergino");
        });

        modelBuilder.Entity<PromPuanHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Prom_Pua__3213E83F24BBF591");

            entity.ToTable("Prom_Puan_Hrk", tb =>
                {
                    tb.HasTrigger("Prom_Puan_Hrk_trd");
                    tb.HasTrigger("Prom_Puan_Hrk_tru");
                });

            entity.HasIndex(e => e.CarId, "Prom_Urun_Hrk_Car_id_index");

            entity.HasIndex(e => e.Sil, "Prom_Urun_Hrk_Sil_index");

            entity.HasIndex(e => e.Tarih, "Prom_Urun_Hrk_Tarih_index");

            entity.HasIndex(e => e.StkId, "Prom_Urun_Hrk_Urn_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BelNo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BrmFiyatKdvli).HasColumnName("Brm_Fiyat_Kdvli");
            entity.Property(e => e.CarId).HasColumnName("Car_id");
            entity.Property(e => e.CarKartId).HasColumnName("Car_KartID");
            entity.Property(e => e.CarKartNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Car_KartNo");
            entity.Property(e => e.CarPlaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Car_Plaka");
            entity.Property(e => e.Carkod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CartipId).HasColumnName("Cartip_id");
            entity.Property(e => e.DegisTarSaat).HasColumnType("datetime");
            entity.Property(e => e.DegisUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepId).HasColumnName("Dep_id");
            entity.Property(e => e.DepKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Dep_Kod");
            entity.Property(e => e.HrkStkPro).HasColumnName("Hrk_Stk_Pro");
            entity.Property(e => e.IslemTipAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("islemTip_Ad");
            entity.Property(e => e.IslemTipId).HasColumnName("islemTip_id");
            entity.Property(e => e.KdvOran).HasColumnName("Kdv_Oran");
            entity.Property(e => e.Kur).HasDefaultValue(1.0);
            entity.Property(e => e.MikCikan)
                .HasDefaultValue(0.0)
                .HasColumnName("Mik_Cikan");
            entity.Property(e => e.MikGiren)
                .HasDefaultValue(0.0)
                .HasColumnName("Mik_Giren");
            entity.Property(e => e.OdeTipAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OdeTip_Ad");
            entity.Property(e => e.OdeTipId).HasColumnName("OdeTip_id");
            entity.Property(e => e.OlusTarSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PuanCikan)
                .HasDefaultValue(0.0)
                .HasColumnName("Puan_Cikan");
            entity.Property(e => e.PuanGiren)
                .HasDefaultValue(0.0)
                .HasColumnName("Puan_Giren");
            entity.Property(e => e.Puanid).HasDefaultValue(0);
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.StkId).HasColumnName("Stk_id");
            entity.Property(e => e.Stkkod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Stktip)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StktipId).HasColumnName("Stktip_id");
            entity.Property(e => e.Tarih).HasColumnType("datetime");
            entity.Property(e => e.TutarKdvli)
                .HasDefaultValue(0.0)
                .HasColumnName("Tutar_Kdvli");
            entity.Property(e => e.Varno).HasDefaultValue(0L);
            entity.Property(e => e.YerAd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PromPuanHrkTip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Prom_Pua__3213E83F5EFF0A87");

            entity.ToTable("Prom_Puan_Hrk_Tip");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AckAl)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ack_al");
            entity.Property(e => e.AckEn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ack_en");
            entity.Property(e => e.AckRu)
                .HasMaxLength(50)
                .HasColumnName("ack_ru");
            entity.Property(e => e.AckTr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ack_tr");
        });

        modelBuilder.Entity<PromSatBaslik>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno, e.Promid }).HasName("PK__Prom_Sat__0D0FC9E97C2B8129");

            entity.ToTable("Prom_Sat_Baslik", tb =>
                {
                    tb.HasTrigger("Prom_Sat_Baslik_trd");
                    tb.HasTrigger("Prom_Sat_Baslik_tru");
                });

            entity.HasIndex(e => e.Yerad, "Prom_Sat_Baslik_idx");

            entity.HasIndex(e => e.Varno, "Prom_Sat_Baslik_idx2");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Promid).HasColumnName("promid");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Adaid).HasColumnName("adaid");
            entity.Property(e => e.Akid)
                .HasDefaultValue(0.0)
                .HasColumnName("akid");
            entity.Property(e => e.Aktar)
                .HasColumnType("datetime")
                .HasColumnName("aktar");
            entity.Property(e => e.Aktip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("BK")
                .HasColumnName("aktip");
            entity.Property(e => e.Bagid)
                .HasDefaultValue(0.0)
                .HasColumnName("bagid");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Fatid)
                .HasDefaultValue(0L)
                .HasColumnName("fatid");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Fisad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("fisad");
            entity.Property(e => e.FisrapId).HasColumnName("fisrap_id");
            entity.Property(e => e.Fistip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fistip");
            entity.Property(e => e.FistipId).HasColumnName("fistip_id");
            entity.Property(e => e.FisturId).HasColumnName("fistur_id");
            entity.Property(e => e.Gctip).HasColumnName("gctip");
            entity.Property(e => e.GenelTopKdv)
                .HasDefaultValue(0.0)
                .HasColumnName("Genel_Top_Kdv");
            entity.Property(e => e.GenelTopKdvli)
                .HasDefaultValue(0.0)
                .HasColumnName("Genel_Top_Kdvli");
            entity.Property(e => e.GenelTopKdvsiz)
                .HasDefaultValue(0.0)
                .HasColumnName("Genel_Top_Kdvsiz");
            entity.Property(e => e.GenelTopNet)
                .HasDefaultValue(0.0)
                .HasColumnName("Genel_Top_Net");
            entity.Property(e => e.GenelTopPuan)
                .HasDefaultValue(0.0)
                .HasColumnName("Genel_Top_Puan");
            entity.Property(e => e.HrkCarPro).HasColumnName("hrk_car_pro");
            entity.Property(e => e.HrkStkPro).HasColumnName("hrk_stk_pro");
            entity.Property(e => e.Isktop)
                .HasDefaultValue(0.0)
                .HasColumnName("isktop");
            entity.Property(e => e.IslemKur).HasColumnName("Islem_Kur");
            entity.Property(e => e.IslemParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Islem_ParaBrm");
            entity.Property(e => e.KartKur).HasColumnName("Kart_Kur");
            entity.Property(e => e.KartParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kart_ParaBrm");
            entity.Property(e => e.Kartno)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Kayok)
                .HasDefaultValue(0)
                .HasColumnName("kayok");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Km)
                .HasDefaultValue(0.0)
                .HasColumnName("km");
            entity.Property(e => e.Kmsec).HasColumnName("kmsec");
            entity.Property(e => e.Kur)
                .HasDefaultValue(1.0)
                .HasColumnName("kur");
            entity.Property(e => e.Marsatid)
                .HasDefaultValue(0.0)
                .HasColumnName("marsatid");
            entity.Property(e => e.No)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("no");
            entity.Property(e => e.OdeTipAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OdeTip_Ad");
            entity.Property(e => e.OdeTipId).HasColumnName("OdeTip_id");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otocarad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("otocarad");
            entity.Property(e => e.Otocarkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("otocarkod");
            entity.Property(e => e.OtomasAck)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("otomas_ack");
            entity.Property(e => e.OtomasId).HasColumnName("otomas_id");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Plaka)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plaka");
            entity.Property(e => e.PromGrp1).HasColumnName("Prom_Grp1");
            entity.Property(e => e.PromKartsiz).HasColumnName("Prom_Kartsiz");
            entity.Property(e => e.PromPro).HasColumnName("Prom_Pro");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Seri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seri");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Surucu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("surucu");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Vadtar)
                .HasColumnType("datetime")
                .HasColumnName("vadtar");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
            entity.Property(e => e.VtsOtoAktar).HasColumnName("vts_oto_aktar");
            entity.Property(e => e.Vtsid)
                .HasDefaultValue(0L)
                .HasColumnName("vtsid");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
            entity.Property(e => e.Ykno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ykno");
        });

        modelBuilder.Entity<PromSatHrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno, e.Promid }).HasName("PK__Prom_Sat__0D0FC9E960653484");

            entity.ToTable("Prom_Sat_Hrk");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Promid).HasColumnName("promid");
            entity.Property(e => e.Barkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("barkod");
            entity.Property(e => e.Brim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Brmfiy)
                .HasColumnType("decimal(38, 14)")
                .HasColumnName("brmfiy");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.DepId).HasColumnName("dep_id");
            entity.Property(e => e.Depkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Iskyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("iskyuz");
            entity.Property(e => e.IslemKur).HasColumnName("Islem_Kur");
            entity.Property(e => e.IslemParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Islem_ParaBrm");
            entity.Property(e => e.KartKur).HasColumnName("Kart_Kur");
            entity.Property(e => e.KartParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kart_ParaBrm");
            entity.Property(e => e.Kayok)
                .HasDefaultValue(0)
                .HasColumnName("kayok");
            entity.Property(e => e.KazBrmPuan)
                .HasDefaultValue(0.0)
                .HasColumnName("Kaz_Brm_Puan");
            entity.Property(e => e.KazTopPuan)
                .HasDefaultValue(0.0)
                .HasColumnName("Kaz_Top_Puan");
            entity.Property(e => e.Kdvyuz).HasColumnName("kdvyuz");
            entity.Property(e => e.Mik).HasColumnName("mik");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otvbrim).HasColumnName("otvbrim");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.SatBrmPuan)
                .HasDefaultValue(0.0)
                .HasColumnName("Sat_Brm_Puan");
            entity.Property(e => e.SatTopPuan)
                .HasDefaultValue(0.0)
                .HasColumnName("Sat_Top_Puan");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.StkId).HasColumnName("stk_id");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.StktipId).HasColumnName("stktip_id");
            entity.Property(e => e.TutIskKdvli)
                .HasDefaultValue(0.0)
                .HasColumnName("Tut_isk_Kdvli");
        });

        modelBuilder.Entity<PromSatisListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Prom_Satis_Listesi");

            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Adaid).HasColumnName("adaid");
            entity.Property(e => e.Akid).HasColumnName("akid");
            entity.Property(e => e.Aktar)
                .HasColumnType("datetime")
                .HasColumnName("aktar");
            entity.Property(e => e.Aktip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("aktip");
            entity.Property(e => e.Bagid).HasColumnName("bagid");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Dataok).HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Fisad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("fisad");
            entity.Property(e => e.FisrapId).HasColumnName("fisrap_id");
            entity.Property(e => e.Fistip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fistip");
            entity.Property(e => e.FistipId).HasColumnName("fistip_id");
            entity.Property(e => e.FisturId).HasColumnName("fistur_id");
            entity.Property(e => e.Gctip).HasColumnName("gctip");
            entity.Property(e => e.GenelTopKdv).HasColumnName("Genel_Top_Kdv");
            entity.Property(e => e.GenelTopKdvli).HasColumnName("Genel_Top_Kdvli");
            entity.Property(e => e.GenelTopKdvsiz).HasColumnName("Genel_Top_Kdvsiz");
            entity.Property(e => e.GenelTopNet).HasColumnName("Genel_Top_Net");
            entity.Property(e => e.GenelTopPuan).HasColumnName("Genel_Top_Puan");
            entity.Property(e => e.HrkCarPro).HasColumnName("hrk_car_pro");
            entity.Property(e => e.HrkStkPro).HasColumnName("hrk_stk_pro");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Isktop).HasColumnName("isktop");
            entity.Property(e => e.IslemKur).HasColumnName("Islem_Kur");
            entity.Property(e => e.IslemParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Islem_ParaBrm");
            entity.Property(e => e.KartKur).HasColumnName("Kart_Kur");
            entity.Property(e => e.KartParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kart_ParaBrm");
            entity.Property(e => e.Kartno)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Kayok).HasColumnName("kayok");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Km).HasColumnName("km");
            entity.Property(e => e.Kmsec).HasColumnName("kmsec");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Kur).HasColumnName("kur");
            entity.Property(e => e.Marsatid).HasColumnName("marsatid");
            entity.Property(e => e.No)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("no");
            entity.Property(e => e.OdeTipAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OdeTip_Ad");
            entity.Property(e => e.OdeTipId).HasColumnName("OdeTip_id");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otocarad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("otocarad");
            entity.Property(e => e.Otocarkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("otocarkod");
            entity.Property(e => e.OtomasAck)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("otomas_ack");
            entity.Property(e => e.OtomasId).HasColumnName("otomas_id");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Plaka)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plaka");
            entity.Property(e => e.PromGrp1).HasColumnName("Prom_Grp1");
            entity.Property(e => e.PromKartsiz).HasColumnName("Prom_Kartsiz");
            entity.Property(e => e.PromPro).HasColumnName("Prom_Pro");
            entity.Property(e => e.Promid).HasColumnName("promid");
            entity.Property(e => e.RemoteId).HasColumnName("remote_id");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Seri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seri");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Surucu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("surucu");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("unvan");
            entity.Property(e => e.Vadtar)
                .HasColumnType("datetime")
                .HasColumnName("vadtar");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Varok).HasColumnName("varok");
            entity.Property(e => e.VtsOtoAktar).HasColumnName("vts_oto_aktar");
            entity.Property(e => e.Vtsid).HasColumnName("vtsid");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
            entity.Property(e => e.Ykno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ykno");
        });

        modelBuilder.Entity<PromUrunKartList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Prom_Urun_Kart_List");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.CikanMiktar).HasColumnName("Cikan_Miktar");
            entity.Property(e => e.GirenMiktar).HasColumnName("Giren_Miktar");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.MevcutMiktar).HasColumnName("Mevcut_Miktar");
            entity.Property(e => e.PromKacSatis).HasColumnName("Prom_Kac_Satis");
            entity.Property(e => e.PromSatPuan).HasColumnName("Prom_Sat_Puan");
            entity.Property(e => e.PromSatTip).HasColumnName("Prom_Sat_Tip");
            entity.Property(e => e.SatTipAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sat_Tip_Ad");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.TipId).HasColumnName("tip_id");
        });

        modelBuilder.Entity<PromUrunPuan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Prom_Uru__3213E83F81020C5A");

            entity.ToTable("Prom_Urun_Puan");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DegisTarSaat).HasColumnType("datetime");
            entity.Property(e => e.DegisUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Firmano).HasDefaultValue(0);
            entity.Property(e => e.OlusTarSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PuanBrm).HasColumnName("Puan_Brm");
            entity.Property(e => e.PuanFis)
                .HasDefaultValue(0.0)
                .HasColumnName("Puan_Fis");
            entity.Property(e => e.PuanKk)
                .HasDefaultValue(0.0)
                .HasColumnName("Puan_KK");
            entity.Property(e => e.PuanNakit)
                .HasDefaultValue(0.0)
                .HasColumnName("Puan_Nakit");
            entity.Property(e => e.PuanOtomas)
                .HasDefaultValue(0.0)
                .HasColumnName("Puan_Otomas");
            entity.Property(e => e.PuanOtomas2)
                .HasDefaultValue(0.0)
                .HasColumnName("Puan_Otomas2");
            entity.Property(e => e.PuanTip).HasColumnName("Puan_Tip");
            entity.Property(e => e.Sil).HasDefaultValue((byte)0);
            entity.Property(e => e.UrunId).HasColumnName("Urun_id");
            entity.Property(e => e.UrunTipId).HasColumnName("Urun_tip_id");
        });

        modelBuilder.Entity<PromUrunPuanTip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Prom_Uru__3213E83F34612C95");

            entity.ToTable("Prom_Urun_Puan_Tip");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AdEn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ad_en");
            entity.Property(e => e.AdTr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ad_tr");
        });

        modelBuilder.Entity<PromUrunSatTip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Prom_Uru__3213E83F9B9594CA");

            entity.ToTable("Prom_Urun_Sat_Tip");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AdEn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ad_en");
            entity.Property(e => e.AdTr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Ad_tr");
        });

        modelBuilder.Entity<PromaksMarketSatisLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PromaksM__3214EC075EF9AD28");

            entity.ToTable("PromaksMarketSatisLog");

            entity.Property(e => e.Aktar).HasDefaultValue(false);
            entity.Property(e => e.Barkod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Birim)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.GuidId)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.IslemTarih).HasColumnType("datetime");
            entity.Property(e => e.KasiyerKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.KayitTarih).HasColumnType("datetime");
            entity.Property(e => e.Kdv).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.Miktar).HasColumnType("decimal(18, 8)");
            entity.Property(e => e.OdemeTip)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.StokAd)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.StokKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Transfer).HasDefaultValue(false);
            entity.Property(e => e.Tutar).HasColumnType("decimal(18, 8)");
        });

        modelBuilder.Entity<RaporDeger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rapor_De__3213E83F1C346519");

            entity.ToTable("Rapor_Deger");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Deger).HasDefaultValue(0.0);
            entity.Property(e => e.GrpNo).HasColumnName("Grp_No");
            entity.Property(e => e.KayId)
                .HasDefaultValue(0)
                .HasColumnName("Kay_Id");
            entity.Property(e => e.MasId)
                .HasDefaultValue(0)
                .HasColumnName("Mas_Id");
            entity.Property(e => e.ParId)
                .HasDefaultValue(0)
                .HasColumnName("Par_Id");
            entity.Property(e => e.RapKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Rap_Kod");
            entity.Property(e => e.TableId).HasColumnName("Table_Id");
            entity.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Table_Name");
        });

        modelBuilder.Entity<RaporGrupKriter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rapor_Gr__3213E83FEA4CE111");

            entity.ToTable("Rapor_Grup_Kriter");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.CarTipId).HasColumnName("CarTip_Id");
            entity.Property(e => e.Carpan).HasDefaultValue(1);
            entity.Property(e => e.DegerKodIn)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Deger_KodIn");
            entity.Property(e => e.DegerTip)
                .HasDefaultValue(0)
                .HasColumnName("Deger_Tip");
            entity.Property(e => e.HrkTip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("BAK")
                .HasColumnName("Hrk_Tip");
            entity.Property(e => e.MasId)
                .HasDefaultValue(0)
                .HasColumnName("Mas_Id");
            entity.Property(e => e.RapKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Rap_Kod");
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.UserId)
                .HasDefaultValue(0)
                .HasColumnName("User_Id");
        });

        modelBuilder.Entity<RaporHrkKriter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rapor_Hr__3213E83F99C9712B");

            entity.ToTable("Rapor_Hrk_Kriter");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GrpId).HasColumnName("Grp_Id");
            entity.Property(e => e.KartId).HasColumnName("Kart_Id");
            entity.Property(e => e.KartKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Kart_Kod");
            entity.Property(e => e.RapKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Rap_Kod");
            entity.Property(e => e.UserId)
                .HasDefaultValue(0)
                .HasColumnName("User_Id");
        });

        modelBuilder.Entity<RaporList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rapor_Li__3213E83FFE8E4649");

            entity.ToTable("Rapor_List");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FirmaNo).HasDefaultValue(0);
            entity.Property(e => e.OlusTarSaat)
                .HasColumnType("datetime")
                .HasColumnName("Olus_TarSaat");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Olus_User");
            entity.Property(e => e.RapKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Rap_Kod");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("Remote_Id");
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
        });

        modelBuilder.Entity<RaporMa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rapor_Ma__3213E83F4C3847B9");

            entity.ToTable("Rapor_Mas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ana).HasDefaultValue(false);
            entity.Property(e => e.AnaId)
                .HasDefaultValue(1)
                .HasColumnName("Ana_Id");
            entity.Property(e => e.RapKod)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("Rap_Kod");
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.UserId)
                .HasDefaultValue(0)
                .HasColumnName("User_Id");
        });

        modelBuilder.Entity<Raporlar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("raporlar", tb =>
                {
                    tb.HasTrigger("raporlar_trd");
                    tb.HasTrigger("raporlar_triu");
                });

            entity.Property(e => e.Ack)
                .HasMaxLength(50)
                .HasColumnName("ack");
            entity.Property(e => e.Aktif)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("Evet")
                .HasColumnName("aktif");
            entity.Property(e => e.AlisSatisFiyatKont).HasColumnName("alis_satis_fiyat_kont");
            entity.Property(e => e.BaskaCarFisAktar).HasColumnName("baska_car_fis_aktar");
            entity.Property(e => e.BelgeTip).HasColumnName("belge_tip");
            entity.Property(e => e.CarKodBosalt)
                .HasDefaultValue(false)
                .HasColumnName("car_kod_bosalt");
            entity.Property(e => e.CarTip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Car_Tip");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.FatGrsAlan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Fat_Grs_alan");
            entity.Property(e => e.FatTahOde).HasColumnName("Fat_Tah_Ode");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.GrsStkTip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Grs_Stk_Tip");
            entity.Property(e => e.HrkCarPro).HasColumnName("hrk_car_pro");
            entity.Property(e => e.HrkStkPro).HasColumnName("hrk_stk_pro");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.IskGiderHrkYansit).HasDefaultValue(false);
            entity.Property(e => e.IskStkTip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("isk_Stk_Tip");
            entity.Property(e => e.Islmkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmkod");
            entity.Property(e => e.Kaptip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Açık")
                .HasColumnName("kaptip");
            entity.Property(e => e.KarsiHesGrs).HasColumnName("Karsi_Hes_Grs");
            entity.Property(e => e.KartOku).HasColumnName("Kart_Oku");
            entity.Property(e => e.KdvOranYansit).HasColumnName("Kdv_Oran_Yansit");
            entity.Property(e => e.KdvTip).HasColumnName("kdv_tip");
            entity.Property(e => e.Master)
                .HasDefaultValue(0)
                .HasColumnName("master");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.PlakaAramaYetki)
                .HasDefaultValue(true)
                .HasColumnName("Plaka_Arama_Yetki");
            entity.Property(e => e.PlakaKontDevam).HasColumnName("Plaka_Kont_Devam");
            entity.Property(e => e.PlakaLimit).HasColumnName("Plaka_Limit");
            entity.Property(e => e.PromKartsiz).HasColumnName("Prom_Kartsiz");
            entity.Property(e => e.PromPro).HasColumnName("prom_pro");
            entity.Property(e => e.Rapgrp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rapgrp");
            entity.Property(e => e.Rapkod)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("rapkod");
            entity.Property(e => e.SatirEsasBrm).HasColumnName("satir_esas_brm");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.StkAdBarkod)
                .HasDefaultValue((byte)0)
                .HasColumnName("Stk_AdBarkod");
            entity.Property(e => e.StkDepDag).HasColumnName("Stk_Dep_Dag");
            entity.Property(e => e.TesisFiyat)
                .HasDefaultValue(false)
                .HasColumnName("Tesis_Fiyat");
            entity.Property(e => e.TipId).HasColumnName("Tip_id");
            entity.Property(e => e.Yazdir).HasColumnName("yazdir");
            entity.Property(e => e.Yazildi).HasColumnName("yazildi");
            entity.Property(e => e.YeniCarKart).HasColumnName("Yeni_Car_Kart");
            entity.Property(e => e.YeniStkKart).HasColumnName("Yeni_Stk_Kart");
            entity.Property(e => e.Yer)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("yer");
        });

        modelBuilder.Entity<Raptip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__raptip__3213E83FB258BD02");

            entity.ToTable("raptip");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kod");
        });

        modelBuilder.Entity<RehberBarkod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RehberBarkod");

            entity.Property(e => e.Barkod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Durum).HasDefaultValue(true);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.OlusturmaKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.RemoteId).HasDefaultValue(0);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
        });

        modelBuilder.Entity<RehberBarkodListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RehberBarkodListesi");

            entity.Property(e => e.Barkod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RehberUnvan)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RehberGrup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RehberGrup");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
        });

        modelBuilder.Entity<RehberGrupDetay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RehberGrupDetay");

            entity.Property(e => e.DegistirmeKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.GrupId).HasDefaultValue(0);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IndirimYuzde).HasDefaultValue(0.0);
            entity.Property(e => e.KomisyonYuzde).HasDefaultValue(0.0);
            entity.Property(e => e.OlusturmaKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.StokGrupId).HasDefaultValue(0);
        });

        modelBuilder.Entity<RehberGrupDetayListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RehberGrupDetayListesi");
        });

        modelBuilder.Entity<RehberKart>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RehberKart");

            entity.Property(e => e.CepNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeKullaniciUnvan)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Durum)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FirmaNo).HasDefaultValue(0);
            entity.Property(e => e.GrupId).HasDefaultValue(0);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaKullaniciUnvan)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.ParaBirim)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RemoteId).HasDefaultValue(0);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciUnvan)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RehberKartListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RehberKartListesi");

            entity.Property(e => e.CarBakiye).HasColumnName("car_bakiye");
            entity.Property(e => e.CepNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeKullaniciUnvan)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Durum)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FisAdet).HasColumnName("fis_adet");
            entity.Property(e => e.FisBakiye).HasColumnName("fis_bakiye");
            entity.Property(e => e.Grupad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaKullaniciUnvan)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.ParaBirim)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SilKullaniciUnvan)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.SonFisTarih)
                .HasColumnType("datetime")
                .HasColumnName("son_fis_tarih");
            entity.Property(e => e.SonFisTutar).HasColumnName("son_fis_tutar");
            entity.Property(e => e.SonhrkTarih)
                .HasColumnType("datetime")
                .HasColumnName("sonhrk_tarih");
            entity.Property(e => e.TopBakiye).HasColumnName("top_bakiye");
            entity.Property(e => e.Topbak).HasColumnName("topbak");
            entity.Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ResSatHrk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ResSatHrk");

            entity.Property(e => e.Barkod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Birim)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BirimCarpan).HasDefaultValue(1.0);
            entity.Property(e => e.DegisTarSaat).HasColumnType("datetime");
            entity.Property(e => e.DegisUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IndYuz).HasDefaultValue(0.0);
            entity.Property(e => e.Kur).HasDefaultValue(1.0);
            entity.Property(e => e.OlusTarSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParaBirim)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Recete).HasDefaultValue(false);
            entity.Property(e => e.SatFiyNo).HasDefaultValue(1);
            entity.Property(e => e.Sil).HasDefaultValue(false);
        });

        modelBuilder.Entity<ResSatKasaHrk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ResSatKasaHrk");

            entity.Property(e => e.CariKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CariTip)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DegTarSaat).HasColumnType("datetime");
            entity.Property(e => e.DegUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GcTip)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.KasaId).HasDefaultValue(0);
            entity.Property(e => e.KasaKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OlusTarSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParaBirim)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RemoteId).HasDefaultValue(0);
            entity.Property(e => e.ResSatId).HasDefaultValue(0.0);
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
            entity.Property(e => e.Tutar).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<ResSatMa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb =>
                {
                    tb.HasTrigger("ResSatMas_trd");
                    tb.HasTrigger("ResSatMas_tru");
                });

            entity.Property(e => e.DegisTarSaat).HasColumnType("datetime");
            entity.Property(e => e.DegisUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DepoKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FirmaNo).HasDefaultValue(0);
            entity.Property(e => e.FisNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IadeTop).HasDefaultValue(0.0);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IndTop).HasDefaultValue(0.0);
            entity.Property(e => e.KayOk).HasDefaultValue(false);
            entity.Property(e => e.Kur).HasDefaultValue(1.0);
            entity.Property(e => e.NakitTop).HasDefaultValue(0.0);
            entity.Property(e => e.OlusTarSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ParaBirim)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.PosTop).HasDefaultValue(0.0);
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SatisTop).HasDefaultValue(0.0);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
        });

        modelBuilder.Entity<ResSatRecHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ResSatRe__3214EC074539DB25");

            entity.ToTable("ResSatRecHrk");

            entity.Property(e => e.BirimFiyat).HasDefaultValue(0.0);
            entity.Property(e => e.BirimMaliyetFiyat).HasDefaultValue(0.0);
            entity.Property(e => e.Brm)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Miktar).HasDefaultValue(0.0);
            entity.Property(e => e.OlusturmaKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.RemoteId).HasDefaultValue(0L);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.StokKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.StokTip)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TransferTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.UretimTipId)
                .HasDefaultValue((byte)1)
                .HasComment("1=Recete\r\n2=Urun");
        });

        modelBuilder.Entity<ResVardiKap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ResVardiKap");

            entity.Property(e => e.Ackfaz)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ackfaz");
            entity.Property(e => e.Cartip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kaptip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kaptip");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Tutar).HasColumnName("tutar");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
        });

        modelBuilder.Entity<ResVardiMa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb =>
                {
                    tb.HasTrigger("ResVardiMas_trd");
                    tb.HasTrigger("ResVardiMas_tru");
                });

            entity.Property(e => e.BozukPara).HasDefaultValue(0.0);
            entity.Property(e => e.DegTarSaat).HasColumnType("datetime");
            entity.Property(e => e.DegUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EntegreAktar).HasColumnType("datetime");
            entity.Property(e => e.EntegreTip)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FirmaNo).HasDefaultValue(0);
            entity.Property(e => e.GelirTop).HasDefaultValue(0.0);
            entity.Property(e => e.GiderTop).HasDefaultValue(0.0);
            entity.Property(e => e.IadeTop).HasDefaultValue(0.0);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IndTop).HasDefaultValue(0.0);
            entity.Property(e => e.KapSaat)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.KapTarih).HasColumnType("datetime");
            entity.Property(e => e.KasaKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NakSatTop).HasDefaultValue(0.0);
            entity.Property(e => e.NakTesTop).HasDefaultValue(0.0);
            entity.Property(e => e.OdeTop).HasDefaultValue(0.0);
            entity.Property(e => e.OlusTarSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParaBirim)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PerKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PosCarTop).HasDefaultValue(0.0);
            entity.Property(e => e.PosTop).HasDefaultValue(0.0);
            entity.Property(e => e.RemoteId).HasDefaultValue(0);
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.SatisTop).HasDefaultValue(0.0);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.TahTop).HasDefaultValue(0.0);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
            entity.Property(e => e.VarAckFazTip)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.VarAd)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.VarOk).HasDefaultValue(0);
            entity.Property(e => e.VeresiTop).HasDefaultValue(0.0);
            entity.Property(e => e.YazarKasaNo).HasDefaultValue(0);
        });

        modelBuilder.Entity<ResVardiOzet>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno }).HasName("PK__ResVardi__76322BA2804EEEE1");

            entity.ToTable("ResVardiOzet");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Bakiye)
                .HasDefaultValue(0.0)
                .HasColumnName("bakiye");
            entity.Property(e => e.Cikis)
                .HasDefaultValue(0.0)
                .HasColumnName("cikis");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Giris)
                .HasDefaultValue(0.0)
                .HasColumnName("giris");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Sr).HasColumnName("sr");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Tipack)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipack");
            entity.Property(e => e.Varok).HasColumnName("varok");
        });

        modelBuilder.Entity<ResVardiRapGoster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ResVardiRapGoster");

            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.FilitreDegerIn)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("Filitre_DegerIn");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RapTip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Rap_Tip");
        });

        modelBuilder.Entity<RezSatHrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno, e.RezSatid }).HasName("PK__RezSatHr__8C7138E0796B881E");

            entity.ToTable("RezSatHrk");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Barkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("barkod");
            entity.Property(e => e.Brim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Depkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Gctip).HasColumnName("gctip");
            entity.Property(e => e.Indyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("indyuz");
            entity.Property(e => e.Kayok)
                .HasDefaultValue(0)
                .HasColumnName("kayok");
            entity.Property(e => e.Kdvyuz).HasColumnName("kdvyuz");
            entity.Property(e => e.Kur)
                .HasDefaultValue(1.0)
                .HasColumnName("kur");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Satfiyno).HasColumnName("satfiyno");
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.StkId).HasColumnName("stk_id");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StktipId).HasColumnName("stktip_id");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
        });

        modelBuilder.Entity<SayacTanklistesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("sayac_tanklistesi");

            entity.Property(e => e.Bagak)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bagak");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.SayacAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sayac_ad");
            entity.Property(e => e.SayacKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sayac_kod");
            entity.Property(e => e.TankAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tank_ad");
            entity.Property(e => e.TankKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tank_kod");
        });

        modelBuilder.Entity<Sayachrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Sayachrkid, e.Sayackod }).HasName("PK__sayachrk__D7980C411B5F2109");

            entity.ToTable("sayachrk", tb =>
                {
                    tb.HasTrigger("sayachrk_log_trd");
                    tb.HasTrigger("sayachrk_log_tri");
                    tb.HasTrigger("sayachrk_log_tru");
                    tb.HasTrigger("sayachrk_trd");
                    tb.HasTrigger("sayachrk_tri");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Sayachrkid).HasColumnName("sayachrkid");
            entity.Property(e => e.Sayackod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sayackod");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Belno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("belno");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Ilkendks)
                .HasDefaultValue(0.0)
                .HasColumnName("ilkendks");
            entity.Property(e => e.Ilkmekendks)
                .HasDefaultValue(0.0)
                .HasColumnName("ilkmekendks");
            entity.Property(e => e.Islmid)
                .HasDefaultValue(0.0)
                .HasColumnName("islmid");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.SayacId).HasColumnName("sayac_id");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Sonendks)
                .HasDefaultValue(0.0)
                .HasColumnName("sonendks");
            entity.Property(e => e.Sonmekendks)
                .HasDefaultValue(0.0)
                .HasColumnName("sonmekendks");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Varno)
                .HasDefaultValue(0.0)
                .HasColumnName("varno");
            entity.Property(e => e.Varok)
                .HasDefaultValue(1)
                .HasColumnName("varok");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Sayackart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod }).HasName("PK__sayackar__DFEE6686F7AA6379");

            entity.ToTable("sayackart", tb =>
                {
                    tb.HasTrigger("sayackart_log_trd");
                    tb.HasTrigger("sayackart_log_tri");
                    tb.HasTrigger("sayackart_log_tru");
                    tb.HasTrigger("sayackart_trd");
                    tb.HasTrigger("sayackart_tri");
                    tb.HasTrigger("sayackart_tru");
                });

            entity.HasIndex(e => e.Kod, "sayackart_uq").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Acendks)
                .HasDefaultValue(0.0)
                .HasColumnName("acendks");
            entity.Property(e => e.Acmekendks)
                .HasDefaultValue(0.0)
                .HasColumnName("acmekendks");
            entity.Property(e => e.Acmekenks)
                .HasDefaultValue(0.0)
                .HasColumnName("acmekenks");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Enktur)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("enktur");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.Muhkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otomaskod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("otomaskod");
            entity.Property(e => e.RemoteId).HasColumnName("Remote_id");
            entity.Property(e => e.Satfiytip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("satfiytip");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Sonendks)
                .HasDefaultValue(0.0)
                .HasColumnName("sonendks");
            entity.Property(e => e.Sonmekendks)
                .HasDefaultValue(0.0)
                .HasColumnName("sonmekendks");
            entity.Property(e => e.Tankod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tankod");
            entity.Property(e => e.Ykkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ykkod");
        });

        modelBuilder.Entity<Sayimhrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Sayid }).HasName("PK__sayimhrk__EC691CAE34419D04");

            entity.ToTable("sayimhrk", tb =>
                {
                    tb.HasTrigger("sayimhrk_log_trd");
                    tb.HasTrigger("sayimhrk_log_tri");
                    tb.HasTrigger("sayimhrk_log_tru");
                    tb.HasTrigger("sayimhrk_triu");
                });

            entity.HasIndex(e => new { e.Sayid, e.Sil }, "sayimhrk_Sayid_index");

            entity.HasIndex(e => new { e.Stkod, e.Stktip }, "sayimhrk_stok_index");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Sayid).HasColumnName("sayid");
            entity.Property(e => e.Brmfiy).HasColumnName("brmfiy");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Depkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("B")
                .HasColumnName("drm");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Kdvyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("kdvyuz");
            entity.Property(e => e.Mevata)
                .HasDefaultValue((byte)0)
                .HasColumnName("mevata");
            entity.Property(e => e.Mevcutmik)
                .HasDefaultValue(0.0)
                .HasColumnName("mevcutmik");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.OnlineSatisMiktar).HasDefaultValue(0.0);
            entity.Property(e => e.OnlineSayim).HasDefaultValue(false);
            entity.Property(e => e.OnlineSayimMiktar).HasDefaultValue(0.0);
            entity.Property(e => e.OnlineSayimTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Saydrm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("B")
                .HasColumnName("saydrm");
            entity.Property(e => e.Sayimmik)
                .HasDefaultValue(0.0)
                .HasColumnName("sayimmik");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Stkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
        });

        modelBuilder.Entity<Sayimkap>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Sayid }).HasName("PK__sayimkap__EC691CAE80B88959");

            entity.ToTable("sayimkap", tb =>
                {
                    tb.HasTrigger("sayimkap_log_trd");
                    tb.HasTrigger("sayimkap_log_tri");
                    tb.HasTrigger("sayimkap_log_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Sayid).HasColumnName("sayid");
            entity.Property(e => e.Ackfaz)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ackfaz");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Kaptip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kaptip");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Saymiktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("saymiktip");
            entity.Property(e => e.Tutar).HasColumnName("tutar");
        });

        modelBuilder.Entity<Sayimma>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Sayid, e.Sil }).HasName("PK__sayimmas__D3B4C3736B016595");

            entity.ToTable("sayimmas", tb =>
                {
                    tb.HasTrigger("sayimmas_log_trd");
                    tb.HasTrigger("sayimmas_log_tri");
                    tb.HasTrigger("sayimmas_log_tru");
                    tb.HasTrigger("sayimmas_trd");
                    tb.HasTrigger("sayimmas_tru");
                });

            entity.HasIndex(e => e.Sayid, "sayimmas_Sayid_index");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Sayid).HasColumnName("sayid");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Brmfiytip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brmfiytip");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Depkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.Drm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("B")
                .HasColumnName("drm");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Mevcutmik)
                .HasDefaultValue(0.0)
                .HasColumnName("mevcutmik");
            entity.Property(e => e.Mevcuttut)
                .HasDefaultValue(0.0)
                .HasColumnName("mevcuttut");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Onayack)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("onayack");
            entity.Property(e => e.Onayper)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("onayper");
            entity.Property(e => e.Onaysaat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("onaysaat");
            entity.Property(e => e.Onaytarih)
                .HasColumnType("datetime")
                .HasColumnName("onaytarih");
            entity.Property(e => e.Perkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sayack)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("sayack");
            entity.Property(e => e.Sayimmik)
                .HasDefaultValue(0.0)
                .HasColumnName("sayimmik");
            entity.Property(e => e.Sayimtut)
                .HasDefaultValue(0.0)
                .HasColumnName("sayimtut");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Sayimstkgrp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sayimstk__3213E83F5F6FEF56");

            entity.ToTable("sayimstkgrp", tb =>
                {
                    tb.HasTrigger("sayimstkgrp_log_trd");
                    tb.HasTrigger("sayimstkgrp_log_tri");
                    tb.HasTrigger("sayimstkgrp_log_tru");
                    tb.HasTrigger("sayimstkgrp_trd");
                    tb.HasTrigger("sayimstkgrp_tri");
                    tb.HasTrigger("sayimstkgrp_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Depkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sayid).HasColumnName("sayid");
            entity.Property(e => e.Stkgrp1).HasColumnName("stkgrp1");
            entity.Property(e => e.Stkgrp2).HasColumnName("stkgrp2");
            entity.Property(e => e.Stkgrp3).HasColumnName("stkgrp3");
            entity.Property(e => e.Stktip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stktip");
        });

        modelBuilder.Entity<Siparishrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Sipid }).HasName("PK__siparish__01F3B79BFF451A8A");

            entity.ToTable("siparishrk", tb =>
                {
                    tb.HasTrigger("siparishrk_log_trd");
                    tb.HasTrigger("siparishrk_log_tri");
                    tb.HasTrigger("siparishrk_log_tru");
                    tb.HasTrigger("siparishrk_trd");
                    tb.HasTrigger("siparishrk_triu");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Sipid).HasColumnName("sipid");
            entity.Property(e => e.Brim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Brmfiy)
                .HasDefaultValue(0.0)
                .HasColumnName("brmfiy");
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Carpan).HasColumnName("carpan");
            entity.Property(e => e.Cartur)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartur");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Depo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("depo");
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Grupid)
                .HasDefaultValue(0.0)
                .HasColumnName("grupid");
            entity.Property(e => e.Irid)
                .HasDefaultValue(0.0)
                .HasColumnName("irid");
            entity.Property(e => e.Kapa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("B")
                .HasColumnName("kapa");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Kdvtut).HasColumnName("kdvtut");
            entity.Property(e => e.Kdvyuz).HasColumnName("kdvyuz");
            entity.Property(e => e.Mik)
                .HasDefaultValue(0.0)
                .HasColumnName("mik");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0.0)
                .HasColumnName("sil");
            entity.Property(e => e.Stkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.Tesmik)
                .HasDefaultValue(0.0)
                .HasColumnName("tesmik");
            entity.Property(e => e.Ustbrim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ustbrim");
        });

        modelBuilder.Entity<Siparisma>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Sipid }).HasName("PK__siparism__01F3B79BCA4E0245");

            entity.ToTable("siparismas", tb =>
                {
                    tb.HasTrigger("siparismas_log_trd");
                    tb.HasTrigger("siparismas_log_tri");
                    tb.HasTrigger("siparismas_log_tru");
                    tb.HasTrigger("siparismas_trd");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Sipid).HasColumnName("sipid");
            entity.Property(e => e.Ack)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Aktip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("BK")
                .HasColumnName("aktip");
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Depo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("depo");
            entity.Property(e => e.Durum).HasDefaultValue(0);
            entity.Property(e => e.DurumAck)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Durum_Ack");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Irtip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("B")
                .HasColumnName("irtip");
            entity.Property(e => e.Kaltop)
                .HasDefaultValue(0.0)
                .HasColumnName("kaltop");
            entity.Property(e => e.Kayok)
                .HasDefaultValue(0)
                .HasColumnName("kayok");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Kdvtop)
                .HasDefaultValue(0.0)
                .HasColumnName("kdvtop");
            entity.Property(e => e.Kdvtut).HasColumnName("kdvtut");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Sipad)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("sipad");
            entity.Property(e => e.Sipno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sipno");
            entity.Property(e => e.Sipseri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sipseri");
            entity.Property(e => e.Siptip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("siptip");
            entity.Property(e => e.Siptop)
                .HasDefaultValue(0.0)
                .HasColumnName("siptop");
            entity.Property(e => e.Siptur)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("siptur");
            entity.Property(e => e.Sipturad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sipturad");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Vadtar)
                .HasColumnType("datetime")
                .HasColumnName("vadtar");
        });

        modelBuilder.Entity<Sistemtanim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sistemta__3213E83FFB743605");

            entity.ToTable("sistemtanim", tb => tb.HasTrigger("sistemtanim_tri"));

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .HasColumnName("ad");
            entity.Property(e => e.Adres1)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("adres1");
            entity.Property(e => e.Adres2)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("adres2");
            entity.Property(e => e.AkaryakitTumFirma)
                .HasDefaultValue(false)
                .HasColumnName("Akaryakit_Tum_Firma");
            entity.Property(e => e.Akyakitstokbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("akyakitstokbrm");
            entity.Property(e => e.Alfatesbrm)
                .HasDefaultValue((byte)0)
                .HasColumnName("alfatesbrm");
            entity.Property(e => e.Alfisesbrm)
                .HasDefaultValue(0)
                .HasColumnName("alfisesbrm");
            entity.Property(e => e.Alsatfiykontrol)
                .HasDefaultValue(0)
                .HasColumnName("alsatfiykontrol");
            entity.Property(e => e.Bacarigiris)
                .HasDefaultValue(1)
                .HasColumnName("bacarigiris");
            entity.Property(e => e.BedelsizBarkodKontrol).HasDefaultValue(false);
            entity.Property(e => e.BekoPosOtomatik)
                .HasDefaultValue(false)
                .HasColumnName("BekoPos_Otomatik");
            entity.Property(e => e.CariAvansTakip).HasDefaultValue(false);
            entity.Property(e => e.Carimailgonder)
                .HasDefaultValue(0)
                .HasColumnName("carimailgonder");
            entity.Property(e => e.Carvadfarkgelgid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carvadfarkgelgid");
            entity.Property(e => e.Cekmaskod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cekmaskod");
            entity.Property(e => e.Dbversion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dbversion");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Devirtarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("devirtarihsaat");
            entity.Property(e => e.Deviruserad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deviruserad");
            entity.Property(e => e.DonemTarih)
                .HasDefaultValue(0)
                .HasColumnName("donem_tarih");
            entity.Property(e => e.EfaturaSeriNoOto).HasDefaultValue(true);
            entity.Property(e => e.EntegreSubeNo)
                .HasDefaultValue(0)
                .HasColumnName("Entegre_SubeNo");
            entity.Property(e => e.FatIskontoKart)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("fat_iskonto_kart");
            entity.Property(e => e.FatVerSatirDeg)
                .HasDefaultValue((byte)0)
                .HasColumnName("fat_ver_satir_deg");
            entity.Property(e => e.Fatesasbrm)
                .HasDefaultValue(1)
                .HasColumnName("fatesasbrm");
            entity.Property(e => e.FaturaFisIskonto).HasDefaultValue(false);
            entity.Property(e => e.FaxNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fax_no");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.FisIskontoKart)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("fis_iskonto_kart");
            entity.Property(e => e.Fisesasbrm)
                .HasDefaultValue(0)
                .HasColumnName("fisesasbrm");
            entity.Property(e => e.FisvadEksiIzni).HasColumnName("fisvad_eksi_izni");
            entity.Property(e => e.Fisyenfiygelgid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fisyenfiygelgid");
            entity.Property(e => e.GridSecrenk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("grid_secrenk");
            entity.Property(e => e.GrpGelirid).HasColumnName("grp_gelirid");
            entity.Property(e => e.GrpGiderid).HasColumnName("grp_giderid");
            entity.Property(e => e.GrpHizmet)
                .HasDefaultValue(0)
                .HasColumnName("grp_hizmet");
            entity.Property(e => e.GrpMadeniyagid).HasColumnName("grp_madeniyagid");
            entity.Property(e => e.GrpMadyagid).HasColumnName("grp_madyagid");
            entity.Property(e => e.GrpMusid).HasColumnName("grp_musid");
            entity.Property(e => e.GrpPermarid).HasColumnName("grp_permarid");
            entity.Property(e => e.GrpPerpomid).HasColumnName("grp_perpomid");
            entity.Property(e => e.GrpSatid).HasColumnName("grp_satid");
            entity.Property(e => e.Haricistokgiris)
                .HasDefaultValue(1)
                .HasColumnName("haricistokgiris");
            entity.Property(e => e.HvzFisKartOto).HasColumnName("hvz_fis_kart_oto");
            entity.Property(e => e.HvzFisOto)
                .HasDefaultValue((byte)0)
                .HasColumnName("hvz_fis_oto");
            entity.Property(e => e.IskontoGid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("iskonto_gid");
            entity.Property(e => e.Kap)
                .HasDefaultValue(0)
                .HasColumnName("kap");
            entity.Property(e => e.KartUnvanKod)
                .HasDefaultValue((byte)0)
                .HasColumnName("Kart_Unvan_Kod");
            entity.Property(e => e.KasFinVar).HasColumnName("kas_fin_var");
            entity.Property(e => e.KasaTarih)
                .HasDefaultValue(false)
                .HasColumnName("Kasa_Tarih");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.KurSor)
                .HasDefaultValue((byte)0)
                .HasColumnName("Kur_Sor");
            entity.Property(e => e.LimAsimSor).HasColumnName("lim_asim_sor");
            entity.Property(e => e.MarKapsec)
                .HasDefaultValue(0)
                .HasColumnName("mar_kapsec");
            entity.Property(e => e.MarVarPosIsle)
                .HasDefaultValue(true)
                .HasColumnName("Mar_Var_Pos_Isle");
            entity.Property(e => e.Mardepo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("mardepo");
            entity.Property(e => e.Market1FiyatGit)
                .HasDefaultValue(true)
                .HasColumnName("market1FiyatGit");
            entity.Property(e => e.MarketCikisSifre).HasDefaultValue(false);
            entity.Property(e => e.MarketCikisSifreKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MarketStokAltGrup)
                .HasDefaultValue(0)
                .HasColumnName("Market_Stok_AltGrup");
            entity.Property(e => e.MarketSube)
                .HasDefaultValue(false)
                .HasColumnName("Market_Sube");
            entity.Property(e => e.Marketsatpbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("marketsatpbrm");
            entity.Property(e => e.Marketstokbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("marketstokbrm");
            entity.Property(e => e.Marmailgonder)
                .HasDefaultValue(0)
                .HasColumnName("marmailgonder");
            entity.Property(e => e.Marpossatkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("marpossatkod");
            entity.Property(e => e.Marsateksistok).HasColumnName("marsateksistok");
            entity.Property(e => e.Marsatf2ekran)
                .HasDefaultValue(1)
                .HasColumnName("marsatf2ekran");
            entity.Property(e => e.Marsatgiderkart)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("marsatgiderkart");
            entity.Property(e => e.Marsatstkuyrses)
                .HasDefaultValue(0)
                .HasColumnName("marsatstkuyrses");
            entity.Property(e => e.Marvardiackfaz)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("marvardiackfaz");
            entity.Property(e => e.Marvarditeskasa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("marvarditeskasa");
            entity.Property(e => e.MuhEntegre)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("Yok")
                .HasColumnName("muh_entegre");
            entity.Property(e => e.MuhPosCarKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Muh_PosCarKod");
            entity.Property(e => e.MuhPosGidKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Muh_PosGidKod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.OtoBelgeno)
                .HasDefaultValue((byte)0)
                .HasColumnName("oto_belgeno");
            entity.Property(e => e.OtoFisVade)
                .HasDefaultValue(false)
                .HasColumnName("Oto_FisVade");
            entity.Property(e => e.OtoFisVadeZaman)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("04:30")
                .HasColumnName("Oto_FisVadeZaman");
            entity.Property(e => e.Otomas1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("otomas1");
            entity.Property(e => e.Otomas2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("otomas2");
            entity.Property(e => e.ParaOndalik).HasColumnName("Para_Ondalik");
            entity.Property(e => e.PerMaasgidkart)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("per_maasgidkart");
            entity.Property(e => e.PlakaKontDev).HasColumnName("plaka_kont_dev");
            entity.Property(e => e.PlakaYeniSor).HasColumnName("plaka_yeni_sor");
            entity.Property(e => e.PomKapsec)
                .HasDefaultValue(0)
                .HasColumnName("pom_kapsec");
            entity.Property(e => e.PomVarEksiStok)
                .HasDefaultValue(false)
                .HasColumnName("Pom_Var_Eksi_Stok");
            entity.Property(e => e.PomVarOtomasPlaka).HasColumnName("Pom_Var_Otomas_Plaka");
            entity.Property(e => e.Pommailgonder)
                .HasDefaultValue(0)
                .HasColumnName("pommailgonder");
            entity.Property(e => e.Pomvardiackfaz)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pomvardiackfaz");
            entity.Property(e => e.Pomvarditeskasa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pomvarditeskasa");
            entity.Property(e => e.Pomvarozet)
                .HasDefaultValue(0)
                .HasColumnName("pomvarozet");
            entity.Property(e => e.Posmaskod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("posmaskod");
            entity.Property(e => e.Printrenksiz)
                .HasDefaultValue(0)
                .HasColumnName("printrenksiz");
            entity.Property(e => e.PromDepo).HasColumnName("Prom_Depo");
            entity.Property(e => e.PromFisRap).HasColumnName("Prom_Fis_Rap");
            entity.Property(e => e.PuanPlakaKont)
                .HasDefaultValue((byte)0)
                .HasColumnName("Puan_Plaka_Kont");
            entity.Property(e => e.PuanYuvTip)
                .HasDefaultValue((byte)0)
                .HasColumnName("Puan_Yuv_Tip");
            entity.Property(e => e.RapHrkBasTar)
                .HasColumnType("datetime")
                .HasColumnName("rap_hrk_bas_tar");
            entity.Property(e => e.SayimKont).HasDefaultValue((byte)1);
            entity.Property(e => e.Sayimtip).HasColumnName("sayimtip");
            entity.Property(e => e.SistemKasakur)
                .HasDefaultValue(1.0)
                .HasColumnName("sistem_kasakur");
            entity.Property(e => e.SistemParabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sistem_parabrm");
            entity.Property(e => e.SistemYtlstr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("YTL")
                .HasColumnName("sistem_ytlstr");
            entity.Property(e => e.Sistemkasa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sistemkasa");
            entity.Property(e => e.TelNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tel_no");
            entity.Property(e => e.Terazikarksay)
                .HasDefaultValue(7)
                .HasColumnName("terazikarksay");
            entity.Property(e => e.TtsBankaKod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTS_BankaKod");
            entity.Property(e => e.TtsBankaKod2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TTS_BankaKod2");
            entity.Property(e => e.Vadfarkgelgid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("vadfarkgelgid");
            entity.Property(e => e.VarAlacakFis).HasColumnName("Var_Alacak_Fis");
            entity.Property(e => e.VarFisEmtiaIsle).HasColumnName("var_fis_emtia_isle");
            entity.Property(e => e.VarHrkTarIsle)
                .HasDefaultValue((byte)0)
                .HasColumnName("Var_Hrk_Tar_isle");
            entity.Property(e => e.VarPosIsle)
                .HasDefaultValue(true)
                .HasColumnName("Var_Pos_Isle");
            entity.Property(e => e.VarTesTek)
                .HasDefaultValue(0)
                .HasColumnName("var_tes_tek");
            entity.Property(e => e.VarTopEposta)
                .HasDefaultValue((byte)0)
                .HasColumnName("Var_Top_Eposta");
            entity.Property(e => e.VarVeresiFis).HasColumnName("Var_Veresi_Fis");
            entity.Property(e => e.Varkapislemtariheata)
                .HasDefaultValue(0)
                .HasColumnName("varkapislemtariheata");
            entity.Property(e => e.Varteslimatkasateksatir)
                .HasDefaultValue(1)
                .HasColumnName("varteslimatkasateksatir");
            entity.Property(e => e.VerFisKisa)
                .HasDefaultValue((byte)0)
                .HasColumnName("ver_fis_kisa");
            entity.Property(e => e.VtsFisCariSec)
                .HasDefaultValue((byte)0)
                .HasColumnName("vts_fis_cari_sec");
            entity.Property(e => e.VtsFisYazdir)
                .HasDefaultValue(0)
                .HasColumnName("vts_fis_yazdir");
            entity.Property(e => e.VtsOtoVarAktar).HasColumnName("vts_oto_var_aktar");
            entity.Property(e => e.Yazbarkont)
                .HasDefaultValue(1)
                .HasColumnName("yazbarkont");
            entity.Property(e => e.YedekDizin)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("yedek_dizin");
            entity.Property(e => e.Yenicarigrp).HasColumnName("yenicarigrp");
            entity.Property(e => e.ZrapCarkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("zrap_carkod");
            entity.Property(e => e.ZraporEsasBrm)
                .HasDefaultValue(0)
                .HasColumnName("Zrapor_Esas_Brm");
        });

        modelBuilder.Entity<SmsGonderimLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tasiyici__3213E83F5920D841_SmsGonderimLog");

            entity.ToTable("SmsGonderimLog");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CariKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CariTip)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Cevap)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.EntegreTip).HasDefaultValue(1);
            entity.Property(e => e.Firmano).HasDefaultValue(0);
            entity.Property(e => e.OlusturmaKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.RemoteId).HasDefaultValue(0);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
        });

        modelBuilder.Entity<SmsSablon>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SmsSablon");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Firmano).HasDefaultValue(0);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.OlusturmaKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.RemoteId).HasDefaultValue(0);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
        });

        modelBuilder.Entity<SoforKart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SoforKar__3213E83FA4D121FE");

            entity.ToTable("SoforKart");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Firmano).HasDefaultValue(0);
            entity.Property(e => e.OlusturmaKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.RemoteId).HasDefaultValue(0);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.SoyAd)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TcNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SonCarAlcHrk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("___Son_Car_Alc_Hrk");

            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.SonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("son_id");
        });

        modelBuilder.Entity<SonCarBrcHrk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("___Son_Car_Brc_Hrk");

            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.SonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("son_id");
        });

        modelBuilder.Entity<SonCekHrk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("__Son_Cek_Hrk");

            entity.Property(e => e.Cekid).HasColumnName("cekid");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.SonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("son_id");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
        });

        modelBuilder.Entity<SonFisHrk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("___Son_Fis_Hrk");

            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.SonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("son_id");
        });

        modelBuilder.Entity<StkTip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Stk_Tip__3213E83FE66C22A5");

            entity.ToTable("Stk_Tip");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AckAl)
                .HasMaxLength(50)
                .HasColumnName("ack_al");
            entity.Property(e => e.AckEn)
                .HasMaxLength(50)
                .HasColumnName("ack_en");
            entity.Property(e => e.AckRu)
                .HasMaxLength(50)
                .HasColumnName("ack_ru");
            entity.Property(e => e.AckTr)
                .HasMaxLength(50)
                .HasColumnName("Ack_tr");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.OndalikHane).HasColumnName("Ondalik_Hane");
        });

        modelBuilder.Entity<Stkbrm>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod }).HasName("PK__stkbrm__DFEE66867B89FB26");

            entity.ToTable("stkbrm", tb =>
                {
                    tb.HasTrigger("stkbrm_log_trd");
                    tb.HasTrigger("stkbrm_log_tri");
                    tb.HasTrigger("stkbrm_log_tru");
                });

            entity.HasIndex(e => e.Kod, "stkbrm_uq").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Ad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
        });

        modelBuilder.Entity<Stkdeptr>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Stktrsid, e.Stkod, e.Stktip }).HasName("PK__stkdeptr__DA4FEDD3F93ACD11");

            entity.ToTable("stkdeptrs", tb =>
                {
                    tb.HasTrigger("stkdeptrs_log_trd");
                    tb.HasTrigger("stkdeptrs_log_tri");
                    tb.HasTrigger("stkdeptrs_log_tru");
                    tb.HasTrigger("stkdeptrs_trd");
                    tb.HasTrigger("stkdeptrs_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Stktrsid).HasColumnName("stktrsid");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Barkod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Belno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.Brim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Brmfiykdvli)
                .HasDefaultValue(0.0)
                .HasColumnName("brmfiykdvli");
            entity.Property(e => e.Carpan)
                .HasDefaultValue(1.0)
                .HasColumnName("carpan");
            entity.Property(e => e.Cfirmano).HasColumnName("cfirmano");
            entity.Property(e => e.Cikdepkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cikdepkod");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Gfirmano).HasColumnName("gfirmano");
            entity.Property(e => e.Girbrim)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("girbrim");
            entity.Property(e => e.Gircarpan)
                .HasDefaultValue(1.0)
                .HasColumnName("gircarpan");
            entity.Property(e => e.Girdepkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("girdepkod");
            entity.Property(e => e.Girstkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("girstkod");
            entity.Property(e => e.Girstktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("girstktip");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.Kdvyuz).HasColumnName("kdvyuz");
            entity.Property(e => e.Kesafet).HasColumnName("kesafet");
            entity.Property(e => e.Miktar)
                .HasDefaultValue(0.0)
                .HasColumnName("miktar");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otv).HasColumnName("otv");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("00:00:00")
                .HasColumnName("saat");
            entity.Property(e => e.Sayackod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("sayackod");
            entity.Property(e => e.Sil).HasDefaultValue((byte)0);
            entity.Property(e => e.Stktipad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stktipad");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.TrsId).HasColumnName("trs_id");
            entity.Property(e => e.TutarKdvli).HasColumnName("Tutar_Kdvli");
            entity.Property(e => e.Varno)
                .HasDefaultValue(0.0)
                .HasColumnName("varno");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Stkdeptrsma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Stkdeptr__3213E83FA6120DEA");

            entity.ToTable(tb =>
                {
                    tb.HasTrigger("Stkdeptrsmas_trd");
                    tb.HasTrigger("Stkdeptrsmas_tru");
                });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BelNo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Bel_No");
            entity.Property(e => e.BelSeri)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Bel_Seri");
            entity.Property(e => e.Cfirmano).HasColumnName("cfirmano");
            entity.Property(e => e.CikDepTip).HasColumnName("CikDep_Tip");
            entity.Property(e => e.CikdepId).HasColumnName("Cikdep_id");
            entity.Property(e => e.Cikdepkod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.GenTop).HasColumnName("Gen_Top");
            entity.Property(e => e.Gfirmano).HasColumnName("gfirmano");
            entity.Property(e => e.GirDepTip).HasColumnName("GirDep_Tip");
            entity.Property(e => e.GirdepId).HasColumnName("Girdep_id");
            entity.Property(e => e.Girdepkod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Kayok)
                .HasDefaultValue((byte)0)
                .HasColumnName("kayok");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.TrsId).HasColumnName("trs_id");
            entity.Property(e => e.Yerad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Yertip)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Stkdrm>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Stkod, e.Depkod, e.Stktip }).HasName("PK__stkdrm__FBBAEBEF8A431A92");

            entity.ToTable("stkdrm");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Stkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Depkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.Cikanbrmkdvli)
                .HasDefaultValue(0.0)
                .HasColumnName("cikanbrmkdvli");
            entity.Property(e => e.Cikanmik)
                .HasDefaultValue(0.0)
                .HasColumnName("cikanmik");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Girenbrmkdvli)
                .HasDefaultValue(0.0)
                .HasColumnName("girenbrmkdvli");
            entity.Property(e => e.Girenmik)
                .HasDefaultValue(0.0)
                .HasColumnName("girenmik");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
        });

        modelBuilder.Entity<Stkhrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Stkhrkid, e.Stkod, e.Stktip }).HasName("PK__stkhrk__7D2B516CD3A82BDE");

            entity.ToTable("stkhrk", tb =>
                {
                    tb.HasTrigger("stkhrk_log_trd");
                    tb.HasTrigger("stkhrk_log_tri");
                    tb.HasTrigger("stkhrk_log_tru");
                    tb.HasTrigger("stkhrk_trd");
                    tb.HasTrigger("stkhrk_tru");
                });

            entity.HasIndex(e => new { e.Tabload, e.Fisid }, "IX_stkhrk_tabloadfisid");

            entity.HasIndex(e => new { e.Stktip, e.Depkod, e.Sil }, "stkhrk_Dev1x");

            entity.HasIndex(e => new { e.Stktip, e.Stkod, e.Depkod, e.Tarih, e.Sil }, "stkhrk_Dev2x");

            entity.HasIndex(e => new { e.Stktip, e.Stkod, e.Depkod, e.Tarih, e.Sil, e.Giren }, "stkhrk_Dev3x");

            entity.HasIndex(e => e.Depkod, "stkhrk_depo_index");

            entity.HasIndex(e => new { e.Stktip, e.Stkod, e.Firmano, e.Depkod, e.Sil }, "stkhrk_idx3");

            entity.HasIndex(e => new { e.Stktip, e.Stkod, e.Depkod, e.Sil }, "stkhrk_idx4");

            entity.HasIndex(e => new { e.Stktip, e.Stkod, e.Firmano, e.Sil }, "stkhrk_idx5");

            entity.HasIndex(e => new { e.Stktip, e.Stkod, e.Sil }, "stkhrk_idx6");

            entity.HasIndex(e => e.Sil, "stkhrk_sil_index");

            entity.HasIndex(e => new { e.Stktip, e.Depkod, e.Sil }, "stkhrk_stktipdepkodsilGrupIndex1");

            entity.HasIndex(e => new { e.Stktip, e.Sil }, "stkhrk_stktipsilGrupIndex1");

            entity.HasIndex(e => new { e.Stktip, e.Sil }, "stkhrk_stktipsilGrupIndex2");

            entity.HasIndex(e => new { e.Stktip, e.Sil }, "stkhrk_stktipsilGrupIndex3");

            entity.HasIndex(e => new { e.Stktip, e.Stkod, e.Sil }, "stkhrk_stktipstkodsil");

            entity.HasIndex(e => new { e.Stktip, e.Stkod, e.Sil }, "stkhrk_stktipstkodsilGrupIndex1");

            entity.HasIndex(e => new { e.Tarih, e.Saat }, "stkhrk_tarih_index");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Stkhrkid).HasColumnName("stkhrkid");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.Ack)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Aiademik)
                .HasDefaultValue(0.0)
                .HasColumnName("aiademik");
            entity.Property(e => e.Barkod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Belno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.Brmfiykdvli)
                .HasDefaultValue(0.0)
                .HasColumnName("brmfiykdvli");
            entity.Property(e => e.Brmgenelisktut)
                .HasDefaultValue(0.0)
                .HasColumnName("brmgenelisktut");
            entity.Property(e => e.Brmgidertut)
                .HasDefaultValue(0.0)
                .HasColumnName("brmgidertut");
            entity.Property(e => e.Brmsatirisktut)
                .HasDefaultValue(0.0)
                .HasColumnName("brmsatirisktut");
            entity.Property(e => e.Cikan)
                .HasDefaultValue(0.0)
                .HasColumnName("cikan");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.DepId).HasColumnName("Dep_id");
            entity.Property(e => e.Depkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.FatDepId).HasColumnName("FatDep_id");
            entity.Property(e => e.Fatid)
                .HasDefaultValue(0)
                .HasColumnName("fatid");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Fisid)
                .HasDefaultValue(0)
                .HasColumnName("fisid");
            entity.Property(e => e.FiyTip).HasDefaultValue(0);
            entity.Property(e => e.Gctip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gctip");
            entity.Property(e => e.Giren)
                .HasDefaultValue(0.0)
                .HasColumnName("giren");
            entity.Property(e => e.Irid)
                .HasDefaultValue(0)
                .HasColumnName("irid");
            entity.Property(e => e.Islmid)
                .HasDefaultValue(0.0)
                .HasColumnName("islmid");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.Kalan)
                .HasDefaultValue(0.0)
                .HasColumnName("kalan");
            entity.Property(e => e.KarsiKartKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Karsi_KartKod");
            entity.Property(e => e.KarsiKartTip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Karsi_KartTip");
            entity.Property(e => e.Kdvyuz).HasColumnName("kdvyuz");
            entity.Property(e => e.Kesafet).HasColumnName("kesafet");
            entity.Property(e => e.MarSatRecHrkId).HasDefaultValue(0L);
            entity.Property(e => e.Marsatid)
                .HasDefaultValue(0)
                .HasColumnName("marsatid");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otv)
                .HasDefaultValue(0.0)
                .HasColumnName("otv");
            entity.Property(e => e.Pomsatid).HasColumnName("pomsatid");
            entity.Property(e => e.Pro)
                .HasDefaultValue(1)
                .HasColumnName("pro");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.ResSatRecHrkId).HasDefaultValue(0L);
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue("00:00:00")
                .HasColumnName("saat");
            entity.Property(e => e.Sayid)
                .HasDefaultValue(0)
                .HasColumnName("sayid");
            entity.Property(e => e.Siademik)
                .HasDefaultValue(0.0)
                .HasColumnName("siademik");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.StkId).HasColumnName("Stk_id");
            entity.Property(e => e.StktipId).HasColumnName("stktip_id");
            entity.Property(e => e.Stktipad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("stktipad");
            entity.Property(e => e.Tabload)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tabload");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.TipId).HasColumnName("tip_id");
            entity.Property(e => e.UrunId).HasDefaultValue(0);
            entity.Property(e => e.Varno)
                .HasDefaultValue(0.0)
                .HasColumnName("varno");
            entity.Property(e => e.Varok)
                .HasDefaultValue(1)
                .HasColumnName("varok");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<Stkhrktip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__stkhrkti__3213E83FDB84F3AC");

            entity.ToTable("stkhrktip");

            entity.HasIndex(e => e.Kod, "stkhrktip_uq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Gc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("gc");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
        });

        modelBuilder.Entity<StokDepoDurum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StokDepoDurum");

            entity.Property(e => e.AlsiadeMik).HasColumnName("alsiade_mik");
            entity.Property(e => e.AlsiadeTopkdvli).HasColumnName("alsiade_topkdvli");
            entity.Property(e => e.CikMiktar).HasColumnName("cik_miktar");
            entity.Property(e => e.CikTopkdvli).HasColumnName("cik_topkdvli");
            entity.Property(e => e.CikTopkdvsiz).HasColumnName("cik_topkdvsiz");
            entity.Property(e => e.Depkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.GirMiktar).HasColumnName("gir_miktar");
            entity.Property(e => e.GirTopkdvli).HasColumnName("gir_topkdvli");
            entity.Property(e => e.GirTopkdvsiz).HasColumnName("gir_topkdvsiz");
            entity.Property(e => e.HarMiktar).HasColumnName("har_miktar");
            entity.Property(e => e.MevMiktar).HasColumnName("mev_miktar");
            entity.Property(e => e.OrtalsFiykdvli).HasColumnName("ortals_fiykdvli");
            entity.Property(e => e.OrtalsFiykdvsiz).HasColumnName("ortals_fiykdvsiz");
            entity.Property(e => e.SatiadeMik).HasColumnName("satiade_mik");
            entity.Property(e => e.SatiadeTopkdvli).HasColumnName("satiade_topkdvli");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
        });

        modelBuilder.Entity<StokFirmaAlisFiyat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Stok_FirmaAlisFiyat");

            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.SonId)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("Son_Id");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
        });

        modelBuilder.Entity<StokFirmaDepoDurum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StokFirmaDepoDurum");

            entity.Property(e => e.AlsiadeMik).HasColumnName("alsiade_mik");
            entity.Property(e => e.AlsiadeTopkdvli).HasColumnName("alsiade_topkdvli");
            entity.Property(e => e.CikMiktar).HasColumnName("cik_miktar");
            entity.Property(e => e.CikTopkdvli).HasColumnName("cik_topkdvli");
            entity.Property(e => e.CikTopkdvsiz).HasColumnName("cik_topkdvsiz");
            entity.Property(e => e.Depkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.GirMiktar).HasColumnName("gir_miktar");
            entity.Property(e => e.GirTopkdvli).HasColumnName("gir_topkdvli");
            entity.Property(e => e.GirTopkdvsiz).HasColumnName("gir_topkdvsiz");
            entity.Property(e => e.HarMiktar).HasColumnName("har_miktar");
            entity.Property(e => e.MevMiktar).HasColumnName("mev_miktar");
            entity.Property(e => e.OrtalsFiykdvli).HasColumnName("ortals_fiykdvli");
            entity.Property(e => e.OrtalsFiykdvsiz).HasColumnName("ortals_fiykdvsiz");
            entity.Property(e => e.SatiadeMik).HasColumnName("satiade_mik");
            entity.Property(e => e.SatiadeTopkdvli).HasColumnName("satiade_topkdvli");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
        });

        modelBuilder.Entity<StokFirmaDurum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("StokFirmaDurum");

            entity.Property(e => e.AlsiadeMik).HasColumnName("alsiade_mik");
            entity.Property(e => e.AlsiadeTopkdvli).HasColumnName("alsiade_topkdvli");
            entity.Property(e => e.CikMiktar).HasColumnName("cik_miktar");
            entity.Property(e => e.CikTopkdvli).HasColumnName("cik_topkdvli");
            entity.Property(e => e.CikTopkdvsiz).HasColumnName("cik_topkdvsiz");
            entity.Property(e => e.GirMiktar).HasColumnName("gir_miktar");
            entity.Property(e => e.GirTopkdvli).HasColumnName("gir_topkdvli");
            entity.Property(e => e.GirTopkdvsiz).HasColumnName("gir_topkdvsiz");
            entity.Property(e => e.HarMiktar).HasColumnName("har_miktar");
            entity.Property(e => e.MevMiktar).HasColumnName("mev_miktar");
            entity.Property(e => e.OrtalsFiykdvli).HasColumnName("ortals_fiykdvli");
            entity.Property(e => e.OrtalsFiykdvsiz).HasColumnName("ortals_fiykdvsiz");
            entity.Property(e => e.SatiadeMik).HasColumnName("satiade_mik");
            entity.Property(e => e.SatiadeTopkdvli).HasColumnName("satiade_topkdvli");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
        });

        modelBuilder.Entity<StokFirmaFiyatDurum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Stok_FirmaFiyatDurum");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StokFirmaFiyatList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Stok_FirmaFiyatList");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FirmaUnvan).HasMaxLength(100);
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StokFirmaMiktar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("_Stok_FirmaMiktar");

            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
        });

        modelBuilder.Entity<StokFiyat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Stok_Fiy__3213E83F9648F878");

            entity.ToTable("Stok_Fiyat");

            entity.HasIndex(e => new { e.StktipId, e.StkId }, "Stok_Fiyat_idx");

            entity.HasIndex(e => new { e.FirmaNo, e.StkId, e.FiyTip, e.FiyNo }, "Stok_Fiyat_uq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.FiyatDegisimTarih).HasColumnType("datetime");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.ParaBrm)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RemoteId).HasColumnName("Remote_id");
            entity.Property(e => e.StkId).HasColumnName("Stk_id");
            entity.Property(e => e.StktipId).HasColumnName("Stktip_id");
        });

        modelBuilder.Entity<StokFiyatLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StokFiya__3213E83F18BC3A69");

            entity.ToTable("StokFiyatLog");

            entity.Property(e => e.AlisFiyat).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.AlisKdv).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.DegTarSaat).HasColumnType("datetime");
            entity.Property(e => e.DegUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MarjYuzde).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.OlusTarSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ParaBrm)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RemoteId).HasColumnName("Remote_id");
            entity.Property(e => e.SatisFiyat).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.SatisKdv).HasColumnType("decimal(10, 5)");
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
            entity.Property(e => e.TedarikFiyat).HasColumnType("decimal(10, 5)");
        });

        modelBuilder.Entity<StokGenelListe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Stok_Genel_Liste");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Alsfiykdvli).HasColumnName("alsfiykdvli");
            entity.Property(e => e.Alsfiykdvsiz).HasColumnName("alsfiykdvsiz");
            entity.Property(e => e.Alskdv).HasColumnName("alskdv");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.PuanBrm).HasColumnName("Puan_Brm");
            entity.Property(e => e.PuanFis).HasColumnName("Puan_Fis");
            entity.Property(e => e.PuanKk).HasColumnName("Puan_KK");
            entity.Property(e => e.PuanNakit).HasColumnName("Puan_Nakit");
            entity.Property(e => e.PuanTip).HasColumnName("Puan_Tip");
            entity.Property(e => e.Sat1fiykdvli).HasColumnName("sat1fiykdvli");
            entity.Property(e => e.Sat1fiykdvsiz).HasColumnName("sat1fiykdvsiz");
            entity.Property(e => e.Sat1kdv).HasColumnName("sat1kdv");
            entity.Property(e => e.Sat2fiykdvli).HasColumnName("sat2fiykdvli");
            entity.Property(e => e.Sat2fiykdvsiz).HasColumnName("sat2fiykdvsiz");
            entity.Property(e => e.Sat2kdv).HasColumnName("sat2kdv");
            entity.Property(e => e.Sat3kdv).HasColumnName("sat3kdv");
            entity.Property(e => e.Sat4kdv).HasColumnName("sat4kdv");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.TipId).HasColumnName("tip_id");
            entity.Property(e => e.Tipi)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StokGenelListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Stok_Genel_Listesi");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Alsfiykdvli).HasColumnName("alsfiykdvli");
            entity.Property(e => e.Alsfiykdvsiz).HasColumnName("alsfiykdvsiz");
            entity.Property(e => e.GrupAd)
                .HasMaxLength(100)
                .HasColumnName("grup_ad");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Sat1fiykdvli).HasColumnName("sat1fiykdvli");
            entity.Property(e => e.Sat1fiykdvsiz).HasColumnName("sat1fiykdvsiz");
            entity.Property(e => e.Sat2fiykdvli).HasColumnName("sat2fiykdvli");
            entity.Property(e => e.Sat2fiykdvsiz).HasColumnName("sat2fiykdvsiz");
        });

        modelBuilder.Entity<StokIadeMiktarListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Stok_iade_Miktar_Listesi");

            entity.Property(e => e.AlsiadeMik).HasColumnName("alsiade_mik");
            entity.Property(e => e.AlsiadeTopkdvli).HasColumnName("alsiade_topkdvli");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.SatiadeMik).HasColumnName("satiade_mik");
            entity.Property(e => e.SatiadeTopkdvli).HasColumnName("satiade_topkdvli");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
        });

        modelBuilder.Entity<StokKartAkaryakitListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Stok_Kart_Akaryakit_Listesi");

            entity.Property(e => e.Acmik).HasColumnName("acmik");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Alsfiy).HasColumnName("alsfiy");
            entity.Property(e => e.Alsfiykdvli).HasColumnName("alsfiykdvli");
            entity.Property(e => e.Alsfiykdvsiz).HasColumnName("alsfiykdvsiz");
            entity.Property(e => e.AlsiadeMik).HasColumnName("alsiade_mik");
            entity.Property(e => e.AlsiadeTopkdvli).HasColumnName("alsiade_topkdvli");
            entity.Property(e => e.Alsiademik).HasColumnName("alsiademik");
            entity.Property(e => e.Alskdv).HasColumnName("alskdv");
            entity.Property(e => e.Alskdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("alskdvtip");
            entity.Property(e => e.Alsmik).HasColumnName("alsmik");
            entity.Property(e => e.Alspbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("alspbrm");
            entity.Property(e => e.Brim)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Brmcarp).HasColumnName("brmcarp");
            entity.Property(e => e.Brmcarp2).HasColumnName("brmcarp2");
            entity.Property(e => e.Brmust)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brmust");
            entity.Property(e => e.Brmust2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brmust2");
            entity.Property(e => e.CikMiktar).HasColumnName("cik_miktar");
            entity.Property(e => e.CikTopkdvli).HasColumnName("cik_topkdvli");
            entity.Property(e => e.CikTopkdvsiz).HasColumnName("cik_topkdvsiz");
            entity.Property(e => e.Dataok).HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Eksat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("eksat");
            entity.Property(e => e.EpdkTur).HasColumnName("Epdk_Tur");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.GirMiktar).HasColumnName("gir_miktar");
            entity.Property(e => e.GirTopkdvli).HasColumnName("gir_topkdvli");
            entity.Property(e => e.GirTopkdvsiz).HasColumnName("gir_topkdvsiz");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.Grpkdvoran).HasColumnName("grpkdvoran");
            entity.Property(e => e.HarMiktar).HasColumnName("har_miktar");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kalalstopkdvli).HasColumnName("kalalstopkdvli");
            entity.Property(e => e.Kalalstopkdvsiz).HasColumnName("kalalstopkdvsiz");
            entity.Property(e => e.Kalsattopkdvli).HasColumnName("kalsattopkdvli");
            entity.Property(e => e.Kalsattopkdvsiz).HasColumnName("kalsattopkdvsiz");
            entity.Property(e => e.Karoran1).HasColumnName("karoran1");
            entity.Property(e => e.Karoran2).HasColumnName("karoran2");
            entity.Property(e => e.Kesft).HasColumnName("kesft");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.MevMiktar).HasColumnName("mev_miktar");
            entity.Property(e => e.Minmik).HasColumnName("minmik");
            entity.Property(e => e.MuhAlsIadKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_iad_kod");
            entity.Property(e => e.MuhAlsIskKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_isk_kod");
            entity.Property(e => e.MuhAlsOtvKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_otv_kod");
            entity.Property(e => e.MuhSatIadKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_iad_kod");
            entity.Property(e => e.MuhSatIskKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_isk_kod");
            entity.Property(e => e.MuhSatMalKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_mal_kod");
            entity.Property(e => e.MuhSatOtvKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_otv_kod");
            entity.Property(e => e.Muhckskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhckskod");
            entity.Property(e => e.Muhgrskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhgrskod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.OrtalsFiykdvli).HasColumnName("ortals_fiykdvli");
            entity.Property(e => e.OrtalsFiykdvsiz).HasColumnName("ortals_fiykdvsiz");
            entity.Property(e => e.Otv).HasColumnName("otv");
            entity.Property(e => e.RemoteId).HasColumnName("remote_id");
            entity.Property(e => e.Sat1fiy).HasColumnName("sat1fiy");
            entity.Property(e => e.Sat1kdv).HasColumnName("sat1kdv");
            entity.Property(e => e.Sat1kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat1kdvtip");
            entity.Property(e => e.Sat1pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat1pbrm");
            entity.Property(e => e.Sat2fiy).HasColumnName("sat2fiy");
            entity.Property(e => e.Sat2kdv).HasColumnName("sat2kdv");
            entity.Property(e => e.Sat2kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat2kdvtip");
            entity.Property(e => e.Sat2pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat2pbrm");
            entity.Property(e => e.Sat3fiy).HasColumnName("sat3fiy");
            entity.Property(e => e.Sat3kdv).HasColumnName("sat3kdv");
            entity.Property(e => e.Sat3kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat3kdvtip");
            entity.Property(e => e.Sat3pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat3pbrm");
            entity.Property(e => e.Sat4fiy).HasColumnName("sat4fiy");
            entity.Property(e => e.Sat4kdv).HasColumnName("sat4kdv");
            entity.Property(e => e.Sat4kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat4kdvtip");
            entity.Property(e => e.Sat4pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat4pbrm");
            entity.Property(e => e.Satfiykdvli).HasColumnName("satfiykdvli");
            entity.Property(e => e.Satfiykdvsiz).HasColumnName("satfiykdvsiz");
            entity.Property(e => e.SatiadeMik).HasColumnName("satiade_mik");
            entity.Property(e => e.SatiadeTopkdvli).HasColumnName("satiade_topkdvli");
            entity.Property(e => e.Satiademik).HasColumnName("satiademik");
            entity.Property(e => e.Satmik).HasColumnName("satmik");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Ykno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ykno");
            entity.Property(e => e.Zrapor).HasColumnName("zrapor");
        });

        modelBuilder.Entity<StokKartBirim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Stok_Kart_Birim");

            entity.Property(e => e.BrmCarpan).HasColumnName("brm_carpan");
            entity.Property(e => e.BrmKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brm_kod");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
        });

        modelBuilder.Entity<StokKartListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Stok_Kart_Listesi");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Alsfiykdvli).HasColumnName("alsfiykdvli");
            entity.Property(e => e.Alsfiykdvsiz).HasColumnName("alsfiykdvsiz");
            entity.Property(e => e.Alskdv).HasColumnName("alskdv");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.MevMiktar).HasColumnName("mev_miktar");
            entity.Property(e => e.RemoteId).HasColumnName("remote_id");
            entity.Property(e => e.Sat1fiykdvli).HasColumnName("sat1fiykdvli");
            entity.Property(e => e.Sat1fiykdvsiz).HasColumnName("sat1fiykdvsiz");
            entity.Property(e => e.Sat1kdv).HasColumnName("sat1kdv");
            entity.Property(e => e.Sat2fiykdvli).HasColumnName("sat2fiykdvli");
            entity.Property(e => e.Sat2fiykdvsiz).HasColumnName("sat2fiykdvsiz");
            entity.Property(e => e.Sat2kdv).HasColumnName("sat2kdv");
            entity.Property(e => e.Sat3kdv).HasColumnName("sat3kdv");
            entity.Property(e => e.Sat4kdv).HasColumnName("sat4kdv");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.TipId).HasColumnName("tip_id");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(31)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StokKartMarket>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Stok_Kart_Market");

            entity.Property(e => e.Acmik).HasColumnName("acmik");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Alsfiy).HasColumnName("alsfiy");
            entity.Property(e => e.Alsfiykdvli).HasColumnName("alsfiykdvli");
            entity.Property(e => e.Alsfiykdvsiz).HasColumnName("alsfiykdvsiz");
            entity.Property(e => e.Alsiademik).HasColumnName("alsiademik");
            entity.Property(e => e.Alskdv).HasColumnName("alskdv");
            entity.Property(e => e.Alskdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("alskdvtip");
            entity.Property(e => e.Alsmik).HasColumnName("alsmik");
            entity.Property(e => e.Alspbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("alspbrm");
            entity.Property(e => e.Brim)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Brmcarp).HasColumnName("brmcarp");
            entity.Property(e => e.Brmcarp2).HasColumnName("brmcarp2");
            entity.Property(e => e.Brmust)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brmust");
            entity.Property(e => e.Brmust2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brmust2");
            entity.Property(e => e.Dataok).HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Eksat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("eksat");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.Grpkdvoran).HasColumnName("grpkdvoran");
            entity.Property(e => e.Grup)
                .HasMaxLength(100)
                .HasColumnName("grup");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Karoran1).HasColumnName("karoran1");
            entity.Property(e => e.Karoran2).HasColumnName("karoran2");
            entity.Property(e => e.Kesft).HasColumnName("kesft");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Minmik).HasColumnName("minmik");
            entity.Property(e => e.Muhckskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhckskod");
            entity.Property(e => e.Muhgrskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhgrskod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Otv).HasColumnName("otv");
            entity.Property(e => e.RemoteId).HasColumnName("remote_id");
            entity.Property(e => e.Sat1fiy).HasColumnName("sat1fiy");
            entity.Property(e => e.Sat1kdv).HasColumnName("sat1kdv");
            entity.Property(e => e.Sat1kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat1kdvtip");
            entity.Property(e => e.Sat1pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat1pbrm");
            entity.Property(e => e.Sat2fiy).HasColumnName("sat2fiy");
            entity.Property(e => e.Sat2kdv).HasColumnName("sat2kdv");
            entity.Property(e => e.Sat2kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat2kdvtip");
            entity.Property(e => e.Sat2pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat2pbrm");
            entity.Property(e => e.Sat3fiy).HasColumnName("sat3fiy");
            entity.Property(e => e.Sat3kdv).HasColumnName("sat3kdv");
            entity.Property(e => e.Sat3kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat3kdvtip");
            entity.Property(e => e.Sat3pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat3pbrm");
            entity.Property(e => e.Sat4fiy).HasColumnName("sat4fiy");
            entity.Property(e => e.Sat4kdv).HasColumnName("sat4kdv");
            entity.Property(e => e.Sat4kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat4kdvtip");
            entity.Property(e => e.Sat4pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat4pbrm");
            entity.Property(e => e.Satfiykdvli).HasColumnName("satfiykdvli");
            entity.Property(e => e.Satfiykdvsiz).HasColumnName("satfiykdvsiz");
            entity.Property(e => e.Satiademik).HasColumnName("satiademik");
            entity.Property(e => e.Satiadesiztoptut).HasColumnName("satiadesiztoptut");
            entity.Property(e => e.Satmik).HasColumnName("satmik");
            entity.Property(e => e.Sattutkdvsiz).HasColumnName("sattutkdvsiz");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Ykno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ykno");
        });

        modelBuilder.Entity<StokKartMarketListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Stok_Kart_Market_Listesi");

            entity.Property(e => e.Acmik).HasColumnName("acmik");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Agirorttoptut).HasColumnName("agirorttoptut");
            entity.Property(e => e.Alsfiy).HasColumnName("alsfiy");
            entity.Property(e => e.Alsfiykdvli).HasColumnName("alsfiykdvli");
            entity.Property(e => e.Alsfiykdvsiz).HasColumnName("alsfiykdvsiz");
            entity.Property(e => e.AlsiadeMik).HasColumnName("alsiade_mik");
            entity.Property(e => e.AlsiadeTopkdvli).HasColumnName("alsiade_topkdvli");
            entity.Property(e => e.Alsiademik).HasColumnName("alsiademik");
            entity.Property(e => e.Alsiadesiztopmik).HasColumnName("alsiadesiztopmik");
            entity.Property(e => e.Alsiadesiztoptut).HasColumnName("alsiadesiztoptut");
            entity.Property(e => e.Alskdv).HasColumnName("alskdv");
            entity.Property(e => e.Alskdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("alskdvtip");
            entity.Property(e => e.Alsmik).HasColumnName("alsmik");
            entity.Property(e => e.Alspbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("alspbrm");
            entity.Property(e => e.Alstopmik).HasColumnName("alstopmik");
            entity.Property(e => e.BagliCariKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BagliCariUnvan)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Barkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("barkod");
            entity.Property(e => e.Brim)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Brmcarp).HasColumnName("brmcarp");
            entity.Property(e => e.Brmcarp2).HasColumnName("brmcarp2");
            entity.Property(e => e.Brmust)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brmust");
            entity.Property(e => e.Brmust2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brmust2");
            entity.Property(e => e.CikMiktar).HasColumnName("cik_miktar");
            entity.Property(e => e.CikTopkdvli).HasColumnName("cik_topkdvli");
            entity.Property(e => e.CikTopkdvsiz).HasColumnName("cik_topkdvsiz");
            entity.Property(e => e.Dataok).HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Eksat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("eksat");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.GirMiktar).HasColumnName("gir_miktar");
            entity.Property(e => e.GirTopkdvli).HasColumnName("gir_topkdvli");
            entity.Property(e => e.GirTopkdvsiz).HasColumnName("gir_topkdvsiz");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.Grpkdvoran).HasColumnName("grpkdvoran");
            entity.Property(e => e.Grup)
                .HasMaxLength(100)
                .HasColumnName("grup");
            entity.Property(e => e.Gtip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("gtip");
            entity.Property(e => e.HarMiktar).HasColumnName("har_miktar");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kalalstopkdvli).HasColumnName("kalalstopkdvli");
            entity.Property(e => e.Kalalstopkdvsiz).HasColumnName("kalalstopkdvsiz");
            entity.Property(e => e.Kalsattopkdvli).HasColumnName("kalsattopkdvli");
            entity.Property(e => e.Kalsattopkdvsiz).HasColumnName("kalsattopkdvsiz");
            entity.Property(e => e.Kaltopmik).HasColumnName("kaltopmik");
            entity.Property(e => e.Karoran1).HasColumnName("karoran1");
            entity.Property(e => e.Karoran2).HasColumnName("karoran2");
            entity.Property(e => e.Kesft).HasColumnName("kesft");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.MevMiktar).HasColumnName("mev_miktar");
            entity.Property(e => e.Minmik).HasColumnName("minmik");
            entity.Property(e => e.MuhAlsIadKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_iad_kod");
            entity.Property(e => e.MuhAlsIskKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_isk_kod");
            entity.Property(e => e.MuhAlsOtvKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_otv_kod");
            entity.Property(e => e.MuhSatIadKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_iad_kod");
            entity.Property(e => e.MuhSatIskKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_isk_kod");
            entity.Property(e => e.MuhSatMalKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_mal_kod");
            entity.Property(e => e.MuhSatOtvKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_otv_kod");
            entity.Property(e => e.Muhckskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhckskod");
            entity.Property(e => e.Muhgrskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhgrskod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Notack)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("notack");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.OrtalsFiykdvli).HasColumnName("ortals_fiykdvli");
            entity.Property(e => e.OrtalsFiykdvsiz).HasColumnName("ortals_fiykdvsiz");
            entity.Property(e => e.Otv).HasColumnName("otv");
            entity.Property(e => e.OzelKod1).HasColumnName("ozel_kod1");
            entity.Property(e => e.OzelKod1Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ozel_kod1_ad");
            entity.Property(e => e.OzelKod2).HasColumnName("ozel_kod2");
            entity.Property(e => e.OzelKod2Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ozel_kod2_ad");
            entity.Property(e => e.PromKacSatis).HasColumnName("Prom_Kac_Satis");
            entity.Property(e => e.PromSatPuan).HasColumnName("Prom_Sat_Puan");
            entity.Property(e => e.PromSatTip).HasColumnName("Prom_Sat_Tip");
            entity.Property(e => e.PromUrun).HasColumnName("Prom_Urun");
            entity.Property(e => e.PuanBrm).HasColumnName("Puan_Brm");
            entity.Property(e => e.RemoteId).HasColumnName("remote_id");
            entity.Property(e => e.Sat1fiy).HasColumnName("sat1fiy");
            entity.Property(e => e.Sat1kdv).HasColumnName("sat1kdv");
            entity.Property(e => e.Sat1kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat1kdvtip");
            entity.Property(e => e.Sat1pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat1pbrm");
            entity.Property(e => e.Sat2fiy).HasColumnName("sat2fiy");
            entity.Property(e => e.Sat2fiykdvli).HasColumnName("sat2fiykdvli");
            entity.Property(e => e.Sat2fiykdvsiz).HasColumnName("sat2fiykdvsiz");
            entity.Property(e => e.Sat2kdv).HasColumnName("sat2kdv");
            entity.Property(e => e.Sat2kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat2kdvtip");
            entity.Property(e => e.Sat2pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat2pbrm");
            entity.Property(e => e.Sat3fiy).HasColumnName("sat3fiy");
            entity.Property(e => e.Sat3fiykdvli).HasColumnName("sat3fiykdvli");
            entity.Property(e => e.Sat3fiykdvsiz).HasColumnName("sat3fiykdvsiz");
            entity.Property(e => e.Sat3kdv).HasColumnName("sat3kdv");
            entity.Property(e => e.Sat3kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat3kdvtip");
            entity.Property(e => e.Sat3pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat3pbrm");
            entity.Property(e => e.Sat4fiy).HasColumnName("sat4fiy");
            entity.Property(e => e.Sat4fiykdvli).HasColumnName("sat4fiykdvli");
            entity.Property(e => e.Sat4fiykdvsiz).HasColumnName("sat4fiykdvsiz");
            entity.Property(e => e.Sat4kdv).HasColumnName("sat4kdv");
            entity.Property(e => e.Sat4kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat4kdvtip");
            entity.Property(e => e.Sat4pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat4pbrm");
            entity.Property(e => e.Satfiykdvli).HasColumnName("satfiykdvli");
            entity.Property(e => e.Satfiykdvsiz).HasColumnName("satfiykdvsiz");
            entity.Property(e => e.SatiadeMik).HasColumnName("satiade_mik");
            entity.Property(e => e.SatiadeTopkdvli).HasColumnName("satiade_topkdvli");
            entity.Property(e => e.Satiademik).HasColumnName("satiademik");
            entity.Property(e => e.Satiadesiztopmik).HasColumnName("satiadesiztopmik");
            entity.Property(e => e.Satiadesiztoptut).HasColumnName("satiadesiztoptut");
            entity.Property(e => e.SatisFiyat1DegisimTarih).HasColumnType("datetime");
            entity.Property(e => e.SatisFiyat2DegisimTarih).HasColumnType("datetime");
            entity.Property(e => e.SatisFiyat3DegisimTarih).HasColumnType("datetime");
            entity.Property(e => e.SatisFiyat4DegisimTarih).HasColumnType("datetime");
            entity.Property(e => e.Satmik).HasColumnName("satmik");
            entity.Property(e => e.Sattutkdvsiz).HasColumnName("sattutkdvsiz");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.TipId).HasColumnName("tip_id");
            entity.Property(e => e.UretimYerAd)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.YkFiyat).HasColumnName("Yk_Fiyat");
            entity.Property(e => e.Ykno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ykno");
            entity.Property(e => e.Zrapor).HasColumnName("zrapor");
        });

        modelBuilder.Entity<StokMuhTanim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StokMuhT__3213E83F1E9D8CB7");

            entity.ToTable("StokMuhTanim");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.MuhAlsIadeKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MuhCksKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MuhGrsKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MuhOnKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MuhSatIadeKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("Remote_id");
            entity.Property(e => e.StkId).HasColumnName("Stk_id");
        });

        modelBuilder.Entity<StokRecete>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Stok_Rec__3213E83FD138FCCB");

            entity.ToTable("Stok_Recete");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Brm)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Firmano).HasDefaultValue(0);
            entity.Property(e => e.RemoteId).HasDefaultValue(0L);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.StkId).HasColumnName("Stk_id");
            entity.Property(e => e.StkTipId)
                .HasDefaultValue(2)
                .HasColumnName("StkTip_id");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TransferTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.UrunId).HasColumnName("Urun_id");
        });

        modelBuilder.Entity<StokSonKullanim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StokSonK__3214EC0777118251");

            entity.ToTable("StokSonKullanim");

            entity.Property(e => e.DegistirmeKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.FirmaNo).HasDefaultValue(0);
            entity.Property(e => e.Miktar).HasDefaultValue(0.0);
            entity.Property(e => e.OlusturmaKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Tarih).HasColumnType("datetime");
        });

        modelBuilder.Entity<Stokfiyathistory>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod }).HasName("PK__stokfiya__DFEE66865D549C1D");

            entity.ToTable("stokfiyathistory");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Alsfiy)
                .HasDefaultValue(0.0)
                .HasColumnName("alsfiy");
            entity.Property(e => e.Alskdv)
                .HasDefaultValue(0.0)
                .HasColumnName("alskdv");
            entity.Property(e => e.Alskdvtip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("alskdvtip");
            entity.Property(e => e.Alspbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("alspbrm");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Kaytip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("kaytip");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sat1fiy)
                .HasDefaultValue(0.0)
                .HasColumnName("sat1fiy");
            entity.Property(e => e.Sat1kdv)
                .HasDefaultValue(0.0)
                .HasColumnName("sat1kdv");
            entity.Property(e => e.Sat1kdvtip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("sat1kdvtip");
            entity.Property(e => e.Sat1pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat1pbrm");
            entity.Property(e => e.Sat2fiy)
                .HasDefaultValue(0.0)
                .HasColumnName("sat2fiy");
            entity.Property(e => e.Sat2kdv)
                .HasDefaultValue(0.0)
                .HasColumnName("sat2kdv");
            entity.Property(e => e.Sat2kdvtip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("sat2kdvtip");
            entity.Property(e => e.Sat2pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat2pbrm");
            entity.Property(e => e.Sat3fiy)
                .HasDefaultValue(0.0)
                .HasColumnName("sat3fiy");
            entity.Property(e => e.Sat3kdv)
                .HasDefaultValue(0.0)
                .HasColumnName("sat3kdv");
            entity.Property(e => e.Sat3kdvtip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("sat3kdvtip");
            entity.Property(e => e.Sat3pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat3pbrm");
            entity.Property(e => e.Sat4fiy)
                .HasDefaultValue(0.0)
                .HasColumnName("sat4fiy");
            entity.Property(e => e.Sat4kdv)
                .HasDefaultValue(0.0)
                .HasColumnName("sat4kdv");
            entity.Property(e => e.Sat4kdvtip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("sat4kdvtip");
            entity.Property(e => e.Sat4pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat4pbrm");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
        });

        modelBuilder.Entity<Stokkart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Tip, e.Kod, e.Drm, e.Sil }).HasName("PK__stokkart__C1BF6FD6B2EE7A89");

            entity.ToTable("stokkart", tb =>
                {
                    tb.HasTrigger("StokKart_AU");
                    tb.HasTrigger("stokkart_log_trd");
                    tb.HasTrigger("stokkart_log_tri");
                    tb.HasTrigger("stokkart_log_tru");
                    tb.HasTrigger("stokkart_trd");
                    tb.HasTrigger("stokkart_tri");
                    tb.HasTrigger("stokkart_tru");
                });

            entity.HasIndex(e => new { e.Grp1, e.Grp2, e.Grp3 }, "stokkart_grup_index");

            entity.HasIndex(e => new { e.Tip, e.Kod }, "stokkart_tipkod").IsUnique();

            entity.HasIndex(e => new { e.Tip, e.Sil }, "stokkart_tipsil");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Acmik)
                .HasDefaultValue(0.0)
                .HasColumnName("acmik");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.AlisFiyatDegisimTarih).HasColumnType("datetime");
            entity.Property(e => e.Alsfiy).HasColumnName("alsfiy");
            entity.Property(e => e.Alsiadekdvlitoptut)
                .HasDefaultValue(0.0)
                .HasColumnName("alsiadekdvlitoptut");
            entity.Property(e => e.Alsiademik)
                .HasDefaultValue(0.0)
                .HasColumnName("alsiademik");
            entity.Property(e => e.Alskdv).HasColumnName("alskdv");
            entity.Property(e => e.Alskdvlitoptut)
                .HasDefaultValue(0.0)
                .HasColumnName("alskdvlitoptut");
            entity.Property(e => e.Alskdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("alskdvtip");
            entity.Property(e => e.Alsmik)
                .HasDefaultValue(0.0)
                .HasColumnName("alsmik");
            entity.Property(e => e.Alspbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("alspbrm");
            entity.Property(e => e.BagliCariKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Barkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("barkod");
            entity.Property(e => e.Bildirim).HasDefaultValue(0);
            entity.Property(e => e.Brim)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Brmcarp)
                .HasDefaultValue(1.0)
                .HasColumnName("brmcarp");
            entity.Property(e => e.Brmcarp2)
                .HasDefaultValue(1.0)
                .HasColumnName("brmcarp2");
            entity.Property(e => e.Brmust)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("brmust");
            entity.Property(e => e.Brmust2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brmust2");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Eksat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("eksat");
            entity.Property(e => e.EpdkTur).HasColumnName("Epdk_Tur");
            entity.Property(e => e.EtiketId).HasDefaultValue(0);
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Grp1)
                .HasDefaultValue(0)
                .HasColumnName("grp1");
            entity.Property(e => e.Grp2)
                .HasDefaultValue(0)
                .HasColumnName("grp2");
            entity.Property(e => e.Grp3)
                .HasDefaultValue(0)
                .HasColumnName("grp3");
            entity.Property(e => e.Grpkdvoran)
                .HasDefaultValue(0.0)
                .HasColumnName("grpkdvoran");
            entity.Property(e => e.Gtip)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KarYuzde).HasDefaultValue(0.0);
            entity.Property(e => e.Karoran1)
                .HasDefaultValue(0.0)
                .HasColumnName("karoran1");
            entity.Property(e => e.Karoran2)
                .HasDefaultValue(0.0)
                .HasColumnName("karoran2");
            entity.Property(e => e.Kesft)
                .HasDefaultValue(1.0)
                .HasColumnName("kesft");
            entity.Property(e => e.Minmik).HasColumnName("minmik");
            entity.Property(e => e.MuhAlsIadKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_iad_kod");
            entity.Property(e => e.MuhAlsIskKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_isk_kod");
            entity.Property(e => e.MuhAlsOtvKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_otv_kod");
            entity.Property(e => e.MuhSatIadKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_iad_kod");
            entity.Property(e => e.MuhSatIskKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_isk_kod");
            entity.Property(e => e.MuhSatMalKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_mal_kod");
            entity.Property(e => e.MuhSatOtvKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_otv_kod");
            entity.Property(e => e.Muhckskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhckskod");
            entity.Property(e => e.Muhgrskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhgrskod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Notack)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("notack");
            entity.Property(e => e.OlcumBirimCarpan).HasDefaultValue(0.0);
            entity.Property(e => e.OlcumBirimId).HasDefaultValue(0);
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Ortalsfiykdvli)
                .HasDefaultValue(0.0)
                .HasColumnName("ortalsfiykdvli");
            entity.Property(e => e.Otv)
                .HasDefaultValue(0.0)
                .HasColumnName("otv");
            entity.Property(e => e.OzelKod1).HasColumnName("ozel_kod1");
            entity.Property(e => e.OzelKod2).HasColumnName("ozel_kod2");
            entity.Property(e => e.PromKacSatis).HasColumnName("Prom_Kac_Satis");
            entity.Property(e => e.PromSatPuan).HasColumnName("Prom_Sat_Puan");
            entity.Property(e => e.PromSatTip).HasColumnName("Prom_Sat_Tip");
            entity.Property(e => e.PromUrun).HasColumnName("Prom_Urun");
            entity.Property(e => e.PuanBrm).HasColumnName("Puan_Brm");
            entity.Property(e => e.PuanFis)
                .HasDefaultValue(0.0)
                .HasColumnName("Puan_Fis");
            entity.Property(e => e.PuanKk)
                .HasDefaultValue(0.0)
                .HasColumnName("Puan_KK");
            entity.Property(e => e.PuanNakit)
                .HasDefaultValue(0.0)
                .HasColumnName("Puan_Nakit");
            entity.Property(e => e.PuanOtomas)
                .HasDefaultValue(0.0)
                .HasColumnName("Puan_Otomas");
            entity.Property(e => e.PuanTip).HasColumnName("Puan_Tip");
            entity.Property(e => e.Recete).HasDefaultValue(false);
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("Remote_id");
            entity.Property(e => e.Restaurant).HasDefaultValue(false);
            entity.Property(e => e.Sat1fiy).HasColumnName("sat1fiy");
            entity.Property(e => e.Sat1kdv).HasColumnName("sat1kdv");
            entity.Property(e => e.Sat1kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat1kdvtip");
            entity.Property(e => e.Sat1pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat1pbrm");
            entity.Property(e => e.Sat2fiy).HasColumnName("sat2fiy");
            entity.Property(e => e.Sat2kdv).HasColumnName("sat2kdv");
            entity.Property(e => e.Sat2kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat2kdvtip");
            entity.Property(e => e.Sat2pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat2pbrm");
            entity.Property(e => e.Sat3fiy).HasColumnName("sat3fiy");
            entity.Property(e => e.Sat3kdv).HasColumnName("sat3kdv");
            entity.Property(e => e.Sat3kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat3kdvtip");
            entity.Property(e => e.Sat3pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat3pbrm");
            entity.Property(e => e.Sat4fiy).HasColumnName("sat4fiy");
            entity.Property(e => e.Sat4kdv).HasColumnName("sat4kdv");
            entity.Property(e => e.Sat4kdvtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat4kdvtip");
            entity.Property(e => e.Sat4pbrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("sat4pbrm");
            entity.Property(e => e.Satiadekdvlitoptut)
                .HasDefaultValue(0.0)
                .HasColumnName("satiadekdvlitoptut");
            entity.Property(e => e.Satiademik)
                .HasDefaultValue(0.0)
                .HasColumnName("satiademik");
            entity.Property(e => e.SatisFiyat1DegisimTarih).HasColumnType("datetime");
            entity.Property(e => e.SatisFiyat2DegisimTarih).HasColumnType("datetime");
            entity.Property(e => e.SatisFiyat3DegisimTarih).HasColumnType("datetime");
            entity.Property(e => e.SatisFiyat4DegisimTarih).HasColumnType("datetime");
            entity.Property(e => e.SatisFiyatDegistir).HasDefaultValue(true);
            entity.Property(e => e.Satkdvlitoptut)
                .HasDefaultValue(0.0)
                .HasColumnName("satkdvlitoptut");
            entity.Property(e => e.Satmik)
                .HasDefaultValue(0.0)
                .HasColumnName("satmik");
            entity.Property(e => e.TipId).HasColumnName("tip_id");
            entity.Property(e => e.Yerli).HasDefaultValue(false);
            entity.Property(e => e.YkFiyat)
                .HasDefaultValue(0)
                .HasColumnName("YK_Fiyat");
            entity.Property(e => e.Ykno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ykno");
            entity.Property(e => e.Zrapor).HasColumnName("zrapor");
        });

        modelBuilder.Entity<Tablelog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tablelog__3213E83FBB6B3F6A");

            entity.ToTable("tablelog");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Hrkid).HasColumnName("hrkid");
            entity.Property(e => e.Islemtip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("islemtip");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Tablead)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tablead");
        });

        modelBuilder.Entity<Tablo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tablo");

            entity.Property(e => e.Alias)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("alias");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Tabload)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tabload");
        });

        modelBuilder.Entity<TabloAlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tablo_alan");

            entity.Property(e => e.Alan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("alan");
            entity.Property(e => e.Alias)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("alias");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Tabloid).HasColumnName("tabloid");
            entity.Property(e => e.Tip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tip");
        });

        modelBuilder.Entity<TahsilatOdeme>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tahsilat__3213E83FE98F27A1");

            entity.ToTable("TahsilatOdeme", tb =>
                {
                    tb.HasTrigger("TahsilatOdeme_trd");
                    tb.HasTrigger("TahsilatOdeme_tru");
                });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Adaid).HasColumnName("adaid");
            entity.Property(e => e.Bankad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("bankad");
            entity.Property(e => e.Bankkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bankkod");
            entity.Property(e => e.Bankomyuz).HasColumnName("bankomyuz");
            entity.Property(e => e.Banksub)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("banksub");
            entity.Property(e => e.Belno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Carkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.CekSeriNoId).HasColumnName("CekSeriNo_id");
            entity.Property(e => e.Cekid).HasColumnName("cekid");
            entity.Property(e => e.Ceksenno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ceksenno");
            entity.Property(e => e.Cikan).HasColumnName("cikan");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Drmad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("drmad");
            entity.Property(e => e.Ekkomyuz).HasColumnName("ekkomyuz");
            entity.Property(e => e.Extrakomyuz).HasColumnName("extrakomyuz");
            entity.Property(e => e.Fatid).HasColumnName("fatid");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Fisid).HasColumnName("fisid");
            entity.Property(e => e.GenelAck)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Genel_Ack");
            entity.Property(e => e.GidId).HasColumnName("gid_id");
            entity.Property(e => e.Gidkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("gidkod");
            entity.Property(e => e.Gidtutar).HasColumnName("gidtutar");
            entity.Property(e => e.Giren).HasColumnName("giren");
            entity.Property(e => e.Grp)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.GrpTip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Grp_Tip");
            entity.Property(e => e.Hesapno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hesapno");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmhrkad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("islmhrkad");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("islmtipad");
            entity.Property(e => e.KarsiCarId).HasColumnName("karsi_car_id");
            entity.Property(e => e.KarsiCarkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("karsi_carkod");
            entity.Property(e => e.KarsiCartip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("karsi_cartip");
            entity.Property(e => e.KarsiCartipId).HasColumnName("karsi_cartip_id");
            entity.Property(e => e.KartKur).HasColumnName("Kart_Kur");
            entity.Property(e => e.KartParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kart_ParaBrm");
            entity.Property(e => e.Kesideci)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("kesideci");
            entity.Property(e => e.Krekartno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("krekartno");
            entity.Property(e => e.Kur).HasColumnName("kur");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Perkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Refno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("refno");
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil)
                .HasDefaultValue((byte)0)
                .HasColumnName("sil");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Vadeli).HasDefaultValue(false);
            entity.Property(e => e.Vadetar)
                .HasColumnType("datetime")
                .HasColumnName("vadetar");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Varok).HasColumnName("varok");
            entity.Property(e => e.Yerad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<TaksitHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Taksit_h__3213E83FBD3A73BA");

            entity.ToTable("Taksit_hrk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Kayok)
                .HasDefaultValue(false)
                .HasColumnName("kayok");
            entity.Property(e => e.Kur).HasDefaultValue(1.0);
            entity.Property(e => e.MasId).HasColumnName("Mas_id");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Sil)
                .HasDefaultValue(false)
                .HasColumnName("sil");
            entity.Property(e => e.Tarih).HasColumnType("datetime");
            entity.Property(e => e.Tip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Tutar).HasDefaultValue(0.0);
            entity.Property(e => e.Yerad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Yertip)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TankKartListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Tank_Kart_Listesi");

            entity.Property(e => e.Acmik).HasColumnName("acmik");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Alsfiykdvli).HasColumnName("alsfiykdvli");
            entity.Property(e => e.Alsfiykdvsiz).HasColumnName("alsfiykdvsiz");
            entity.Property(e => e.Alskdvlitoptut).HasColumnName("alskdvlitoptut");
            entity.Property(e => e.Alsmik).HasColumnName("alsmik");
            entity.Property(e => e.Bagak)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bagak");
            entity.Property(e => e.CikMiktar).HasColumnName("cik_miktar");
            entity.Property(e => e.CikTopkdvli).HasColumnName("cik_topkdvli");
            entity.Property(e => e.CikTopkdvsiz).HasColumnName("cik_topkdvsiz");
            entity.Property(e => e.Dataok).HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.GirMiktar).HasColumnName("gir_miktar");
            entity.Property(e => e.GirTopkdvli).HasColumnName("gir_topkdvli");
            entity.Property(e => e.GirTopkdvsiz).HasColumnName("gir_topkdvsiz");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kalalstopkdvli).HasColumnName("kalalstopkdvli");
            entity.Property(e => e.Kalalstopkdvsiz).HasColumnName("kalalstopkdvsiz");
            entity.Property(e => e.Kalsattopkdvli).HasColumnName("kalsattopkdvli");
            entity.Property(e => e.Kalsattopkdvsiz).HasColumnName("kalsattopkdvsiz");
            entity.Property(e => e.Kapsit).HasColumnName("kapsit");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.MevMiktar).HasColumnName("mev_miktar");
            entity.Property(e => e.Minmik).HasColumnName("minmik");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RemoteId).HasColumnName("Remote_id");
            entity.Property(e => e.Satfiykdvli).HasColumnName("satfiykdvli");
            entity.Property(e => e.Satfiykdvsiz).HasColumnName("satfiykdvsiz");
            entity.Property(e => e.Satkdvlitoptut).HasColumnName("satkdvlitoptut");
            entity.Property(e => e.Satmik).HasColumnName("satmik");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
        });

        modelBuilder.Entity<Tankkart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod, e.Bagak, e.Firmano }).HasName("PK__tankkart__8EEB9CC18401DDC8");

            entity.ToTable("tankkart", tb =>
                {
                    tb.HasTrigger("tankkart_log_trd");
                    tb.HasTrigger("tankkart_log_tri");
                    tb.HasTrigger("tankkart_log_tru");
                    tb.HasTrigger("tankkart_tri");
                    tb.HasTrigger("tankkart_tru");
                });

            entity.HasIndex(e => e.Kod, "tankkart_uq").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Bagak)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bagak");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Acmik)
                .HasDefaultValue(0.0)
                .HasColumnName("acmik");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Alskdvlitoptut)
                .HasDefaultValue(0.0)
                .HasColumnName("alskdvlitoptut");
            entity.Property(e => e.Alsmik)
                .HasDefaultValue(0.0)
                .HasColumnName("alsmik");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("drm");
            entity.Property(e => e.Kapsit).HasColumnName("kapsit");
            entity.Property(e => e.Minmik).HasColumnName("minmik");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RemoteId).HasColumnName("Remote_id");
            entity.Property(e => e.Satkdvlitoptut)
                .HasDefaultValue(0.0)
                .HasColumnName("satkdvlitoptut");
            entity.Property(e => e.Satmik)
                .HasDefaultValue(0.0)
                .HasColumnName("satmik");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
        });

        modelBuilder.Entity<TarihKapat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tarih_Ka__3213E83F4E701B88");

            entity.ToTable("Tarih_Kapat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Drm)
                .HasDefaultValue((byte)0)
                .HasColumnName("drm");
            entity.Property(e => e.FirmaNo).HasDefaultValue(0);
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sil)
                .HasDefaultValue((byte)0)
                .HasColumnName("sil");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
        });

        modelBuilder.Entity<TasiyiciFirmaKart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tasiyici__3213E83F750D7374");

            entity.ToTable("TasiyiciFirmaKart");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AdresIl)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AdresIlce)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AdresPostaKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Firmano).HasDefaultValue(0);
            entity.Property(e => e.KurumTip).HasDefaultValue(1);
            entity.Property(e => e.OlusturmaKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.RemoteId).HasDefaultValue(0);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.SoyAd)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Tatiller>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tatiller__3213E83FAB116D1A");

            entity.ToTable("tatiller");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0.0)
                .HasColumnName("firmano");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Tar)
                .HasColumnType("datetime")
                .HasColumnName("tar");
        });

        modelBuilder.Entity<Tesi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tesis__3213E83F5571ABB3");

            entity.ToTable("Tesis");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Sil).HasDefaultValue(0);
            entity.Property(e => e.Unvan)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TeslimYerKart>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TeslimYerKart");

            entity.Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AdresIl)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AdresIlce)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AdresPostaKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Firmano).HasDefaultValue(0);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.OlusturmaKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.RemoteId).HasDefaultValue(0);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.SilKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TopluKayit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TopluKay__3214EC0764535F22");

            entity.ToTable("TopluKayit", tb => tb.HasTrigger("TopluKayit_tru"));

            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BelgeNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DegisTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.DegisUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Firmano).HasDefaultValue(0);
            entity.Property(e => e.IslemTipId).HasDefaultValue(0);
            entity.Property(e => e.KartKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.KayOk).HasDefaultValue(false);
            entity.Property(e => e.OlusTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
        });

        modelBuilder.Entity<TopluKayitHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TopluKay__3214EC076918143F");

            entity.ToTable("TopluKayitHrk");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegisTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.DegisUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.KartKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.KartUniqId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OlusTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.Tutar).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<TopluVirmanKayit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TopluKay__3214EC0764535F22_TopluVirmanKayit");

            entity.ToTable("TopluVirmanKayit", tb => tb.HasTrigger("TopluVirmanKayit_tru"));

            entity.Property(e => e.BelgeNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DegisTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.DegisUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Firmano).HasDefaultValue(0);
            entity.Property(e => e.KartBa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("B")
                .HasColumnName("KartBA");
            entity.Property(e => e.KartKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.KayOk).HasDefaultValue(false);
            entity.Property(e => e.OlusTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
        });

        modelBuilder.Entity<TopluVirmanKayitHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TopluKay__3214EC076918143F_TopluVirmanKayitHrk");

            entity.ToTable("TopluVirmanKayitHrk");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Alacak).HasDefaultValue(0.0);
            entity.Property(e => e.Borc).HasDefaultValue(0.0);
            entity.Property(e => e.DegisTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.DegisUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.KartKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.KartUniqId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OlusTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(false);
        });

        modelBuilder.Entity<TtsBankaTahsilat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TTS_Bank__3213E83F4C3813BF");

            entity.ToTable("TTS_BankaTahsilat");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CariKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Dosya)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FisSeriNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.OdeTarih).HasColumnType("datetime");
            entity.Property(e => e.Plaka)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
        });

        modelBuilder.Entity<TtsOdeTip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TTS_OdeT__3213E83FCB8A9E21");

            entity.ToTable("TTS_OdeTip");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sil).HasDefaultValue(0);
            entity.Property(e => e.Tip).HasDefaultValue(0);
        });

        modelBuilder.Entity<UlkeList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UlkeList__3214EC072F40CEB0");

            entity.ToTable("UlkeList");

            entity.Property(e => e.Ad)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod }).HasName("PK__users__DFEE6686681932CA");

            entity.ToTable("users", tb => tb.HasTrigger("users_trd"));

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Ad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Aktif)
                .HasDefaultValue(false)
                .HasColumnName("aktif");
            entity.Property(e => e.BilgiEkranGosterimTarih).HasColumnType("datetime");
            entity.Property(e => e.ChFirmaSec)
                .HasDefaultValue((byte)0)
                .HasColumnName("ch_firma_Sec");
            entity.Property(e => e.ChTumKartlar)
                .HasDefaultValue(0)
                .HasColumnName("ch_Tum_Kartlar");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.FirmaSec).HasColumnName("firma_sec");
            entity.Property(e => e.Firmaid).HasColumnName("firmaid");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Gectar)
                .HasColumnType("datetime")
                .HasColumnName("gectar");
            entity.Property(e => e.Gorev)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("gorev");
            entity.Property(e => e.Indsec).HasColumnName("indsec");
            entity.Property(e => e.Indyuzde).HasColumnName("indyuzde");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.IslemGunSure)
                .HasDefaultValue(0)
                .HasColumnName("islem_Gun_sure");
            entity.Property(e => e.KartListGrupYetki).HasDefaultValue(false);
            entity.Property(e => e.Lang)
                .HasDefaultValue(0.0)
                .HasColumnName("lang");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("mail");
            entity.Property(e => e.MarDepKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("mar_dep_kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Pc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pc");
            entity.Property(e => e.PerId).HasColumnName("Per_id");
            entity.Property(e => e.PomGecSayacGrs).HasColumnName("Pom_Gec_Sayac_Grs");
            entity.Property(e => e.Printduz)
                .HasDefaultValue(0)
                .HasColumnName("printduz");
            entity.Property(e => e.Sifre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("sifre");
            entity.Property(e => e.Sisckstarsaat)
                .HasColumnType("datetime")
                .HasColumnName("sisckstarsaat");
            entity.Property(e => e.Sisgrstarsaat)
                .HasColumnType("datetime")
                .HasColumnName("sisgrstarsaat");
            entity.Property(e => e.VadGelen)
                .HasDefaultValue(false)
                .HasColumnName("vad_gelen");
            entity.Property(e => e.Version)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("version");
            entity.Property(e => e.Yetki).HasColumnName("yetki");
        });

        modelBuilder.Entity<Userformgrup>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod }).HasName("PK__userform__DFEE6686DC218E91");

            entity.ToTable("userformgrup");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0.0)
                .HasColumnName("firmano");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
        });

        modelBuilder.Entity<Userformhak>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Userkod, e.Formkod }).HasName("PK__userform__2E86D38671DA9E7B");

            entity.ToTable("userformhak");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Userkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("userkod");
            entity.Property(e => e.Formkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("formkod");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0.0)
                .HasColumnName("firmano");
            entity.Property(e => e.H1)
                .HasDefaultValue(false)
                .HasColumnName("h1");
            entity.Property(e => e.H10)
                .HasDefaultValue(false)
                .HasColumnName("h10");
            entity.Property(e => e.H11).HasColumnName("h11");
            entity.Property(e => e.H12).HasColumnName("h12");
            entity.Property(e => e.H13).HasColumnName("h13");
            entity.Property(e => e.H14).HasColumnName("h14");
            entity.Property(e => e.H15).HasColumnName("h15");
            entity.Property(e => e.H16).HasColumnName("h16");
            entity.Property(e => e.H17).HasColumnName("h17");
            entity.Property(e => e.H18).HasColumnName("h18");
            entity.Property(e => e.H19).HasColumnName("h19");
            entity.Property(e => e.H2)
                .HasDefaultValue(false)
                .HasColumnName("h2");
            entity.Property(e => e.H20).HasColumnName("h20");
            entity.Property(e => e.H3)
                .HasDefaultValue(false)
                .HasColumnName("h3");
            entity.Property(e => e.H4)
                .HasDefaultValue(false)
                .HasColumnName("h4");
            entity.Property(e => e.H5)
                .HasDefaultValue(false)
                .HasColumnName("h5");
            entity.Property(e => e.H6)
                .HasDefaultValue(false)
                .HasColumnName("h6");
            entity.Property(e => e.H7)
                .HasDefaultValue(false)
                .HasColumnName("h7");
            entity.Property(e => e.H8)
                .HasDefaultValue(false)
                .HasColumnName("h8");
            entity.Property(e => e.H9)
                .HasDefaultValue(false)
                .HasColumnName("h9");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
        });

        modelBuilder.Entity<Userformhrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__userform__3213E83FD71CBAE3");

            entity.ToTable("userformhrk");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0.0)
                .HasColumnName("firmano");
            entity.Property(e => e.Formid).HasColumnName("formid");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Tan1).HasColumnName("tan1");
            entity.Property(e => e.Tan2).HasColumnName("tan2");
            entity.Property(e => e.Tan3).HasColumnName("tan3");
            entity.Property(e => e.Tan4).HasColumnName("tan4");
            entity.Property(e => e.Tan5).HasColumnName("tan5");
            entity.Property(e => e.Tan6).HasColumnName("tan6");
        });

        modelBuilder.Entity<Userformlar>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Grupkod }).HasName("PK__userform__B7DD4CEF0442E7E3");

            entity.ToTable("userformlar", tb =>
                {
                    tb.HasTrigger("userformlar_trd");
                    tb.HasTrigger("userformlar_tri");
                });

            entity.HasIndex(e => e.Formkod, "userformlar_uq").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Grupkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("grupkod");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0.0)
                .HasColumnName("firmano");
            entity.Property(e => e.Formkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("formkod");
            entity.Property(e => e.Fromack)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fromack");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sira)
                .HasDefaultValue(0.0)
                .HasColumnName("sira");
        });

        modelBuilder.Entity<Userlog>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Tarih }).HasName("PK__userlog__B05752918862AB59");

            entity.ToTable("userlog");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Ack)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0.0)
                .HasColumnName("firmano");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.Islem)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islem");
            entity.Property(e => e.Kayitid).HasColumnName("kayitid");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Pcadi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pcadi");
            entity.Property(e => e.Tablo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tablo");
            entity.Property(e => e.Usr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usr");
        });

        modelBuilder.Entity<Usrgrid>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Users }).HasName("PK__usrgrid__E0AB2F4862BF6694");

            entity.ToTable("usrgrid");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Users)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("users");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Dosya)
                .HasColumnType("image")
                .HasColumnName("dosya");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Form)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("form");
            entity.Property(e => e.Grid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grid");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
        });

        modelBuilder.Entity<Usrsplit>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Users }).HasName("PK__usrsplit__E0AB2F484ED18BE5");

            entity.ToTable("usrsplit");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Users)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("users");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Form)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("form");
            entity.Property(e => e.Genis).HasColumnName("genis");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Panel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("panel");
        });

        modelBuilder.Entity<VMarketSatisUrunIdReceteMaliyet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_MarketSatisUrunIdReceteMaliyet");
        });

        modelBuilder.Entity<VResGrup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ResGrup");

            entity.Property(e => e.Ad).HasMaxLength(100);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TabloAd)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.YkkIsNo)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VResSatHrk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ResSatHrk");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Barkod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Birim)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DegisTarSaat).HasColumnType("datetime");
            entity.Property(e => e.DegisUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OlusTarSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ParaBirim)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VResSatMa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ResSatMas");

            entity.Property(e => e.DegisTarSaat).HasColumnType("datetime");
            entity.Property(e => e.DegisUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DepoKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.OlusTarSaat).HasColumnType("datetime");
            entity.Property(e => e.OlusUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ParaBirim)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
        });

        modelBuilder.Entity<VResSatisUrunIdReceteMaliyet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ResSatisUrunIdReceteMaliyet");
        });

        modelBuilder.Entity<VResStok01>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ResStok_01");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Birim)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ParaBrm)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SatKdvTipAd)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VStokFirmaSubeFiyat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_StokFirmaSubeFiyat");

            entity.Property(e => e.StkId).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StkKod)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VStokSonKullanimList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_StokSonKullanimList");

            entity.Property(e => e.Barkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("barkod");
            entity.Property(e => e.DegistirmeKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegistirmeTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.OlusturmaKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OlusturmaTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.SilKullaniciUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SilTarihSaat).HasColumnType("datetime");
            entity.Property(e => e.StokAd)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StokKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
        });

        modelBuilder.Entity<Vardikasa>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Kod }).HasName("PK__vardikas__DFEE6686B44F8340");

            entity.ToTable("vardikasa");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
        });

        modelBuilder.Entity<VardiyaCekKartlar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vardiya_Cek_Kartlar");

            entity.Property(e => e.Ad)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Adres)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.Adres2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("adres2");
            entity.Property(e => e.Cartp)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("cartp");
            entity.Property(e => e.Crno).HasColumnName("crno");
            entity.Property(e => e.Evil)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("evil");
            entity.Property(e => e.Evilce)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("evilce");
            entity.Property(e => e.FatIskonto).HasColumnName("fat_iskonto");
            entity.Property(e => e.FisIskonto).HasColumnName("fis_iskonto");
            entity.Property(e => e.Grupad1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("grupad1");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tcno)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tcno");
            entity.Property(e => e.Tip)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("vergidaire");
            entity.Property(e => e.Vergino)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("vergino");
        });

        modelBuilder.Entity<VardiyaKasaKartlar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Vardiya_Kasa_Kartlar");

            entity.Property(e => e.Ad)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Adres)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.Adres2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("adres2");
            entity.Property(e => e.Cartp)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("cartp");
            entity.Property(e => e.Crno).HasColumnName("crno");
            entity.Property(e => e.Evil)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("evil");
            entity.Property(e => e.Evilce)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("evilce");
            entity.Property(e => e.FatIskonto).HasColumnName("fat_iskonto");
            entity.Property(e => e.FisIskonto).HasColumnName("fis_iskonto");
            entity.Property(e => e.Grupad1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("grupad1");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tcno)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tcno");
            entity.Property(e => e.Tip)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("vergidaire");
            entity.Property(e => e.Vergino)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("vergino");
        });

        modelBuilder.Entity<VeresiVadeFarkHrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VeresiVa__3213E83F1BE2DC33");

            entity.ToTable("VeresiVadeFarkHrk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alacak).HasDefaultValue(0.0);
            entity.Property(e => e.Borc).HasDefaultValue(0.0);
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Tarih).HasColumnType("datetime");
            entity.Property(e => e.VadeFark).HasDefaultValue(0.0);
        });

        modelBuilder.Entity<Veresifarkhrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__veresifa__3213E83F362F8C92");

            entity.ToTable("veresifarkhrk", tb =>
                {
                    tb.HasTrigger("veresifarkhrk_trd");
                    tb.HasTrigger("veresifarkhrk_tri");
                });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EskiFiyat).HasColumnName("eski_fiyat");
            entity.Property(e => e.EskiVadetar)
                .HasColumnType("datetime")
                .HasColumnName("eski_vadetar");
            entity.Property(e => e.Masterid).HasColumnName("masterid");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Tip)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Verhrkid).HasColumnName("verhrkid");
            entity.Property(e => e.Verid).HasColumnName("verid");
            entity.Property(e => e.YeniFiyat).HasColumnName("yeni_fiyat");
            entity.Property(e => e.YeniVadetar)
                .HasColumnType("datetime")
                .HasColumnName("yeni_vadetar");
        });

        modelBuilder.Entity<Veresihrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno, e.Verid }).HasName("PK__veresihr__0E10EA9A3B357DEA");

            entity.ToTable("veresihrk", tb =>
                {
                    tb.HasTrigger("veresihrk_log_trd");
                    tb.HasTrigger("veresihrk_log_tri");
                    tb.HasTrigger("veresihrk_log_tru");
                    tb.HasTrigger("veresihrk_trd");
                    tb.HasTrigger("veresihrk_tru");
                });

            entity.HasIndex(e => new { e.Stktip, e.Sil }, "veresihrk_stktip_sil");

            entity.HasIndex(e => new { e.Verid, e.Stktip, e.Sil }, "veresihrk_stktip_sil_2");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Verid).HasColumnName("verid");
            entity.Property(e => e.Akfiytip)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("akfiytip");
            entity.Property(e => e.Barkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("barkod");
            entity.Property(e => e.Brim)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Brmfiy)
                .HasColumnType("decimal(38, 14)")
                .HasColumnName("brmfiy");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.DepId).HasColumnName("dep_id");
            entity.Property(e => e.Depkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("depkod");
            entity.Property(e => e.FatIskYuz)
                .HasDefaultValue(0.0)
                .HasColumnName("Fat_IskYuz");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Fiyfarktop)
                .HasDefaultValue(0.0)
                .HasColumnName("fiyfarktop");
            entity.Property(e => e.Iskyuz)
                .HasDefaultValue(0.0)
                .HasColumnName("iskyuz");
            entity.Property(e => e.IslemKur).HasColumnName("Islem_Kur");
            entity.Property(e => e.IslemParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Islem_ParaBrm");
            entity.Property(e => e.KartKur).HasColumnName("Kart_Kur");
            entity.Property(e => e.KartParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kart_ParaBrm");
            entity.Property(e => e.Kayok)
                .HasDefaultValue(0)
                .HasColumnName("kayok");
            entity.Property(e => e.Kdvyuz).HasColumnName("kdvyuz");
            entity.Property(e => e.Mik)
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("mik");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.OtomasId).HasColumnName("Otomas_Id");
            entity.Property(e => e.Otvbrim).HasColumnName("otvbrim");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.StkId).HasColumnName("stk_id");
            entity.Property(e => e.Stkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("stkod");
            entity.Property(e => e.Stktip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("stktip");
            entity.Property(e => e.StktipId).HasColumnName("stktip_id");
            entity.Property(e => e.Vadetar)
                .HasColumnType("datetime")
                .HasColumnName("vadetar");
            entity.Property(e => e.Vadfarkcarhrkid).HasColumnName("vadfarkcarhrkid");
            entity.Property(e => e.Vadfarktop)
                .HasDefaultValue(0.0)
                .HasColumnName("vadfarktop");
            entity.Property(e => e.Yenbrmfiyfark)
                .HasDefaultValue(0.0)
                .HasColumnName("yenbrmfiyfark");
        });

        modelBuilder.Entity<Veresima>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Varno, e.Verid }).HasName("PK__veresima__0E10EA9A0B125ED9");

            entity.ToTable("veresimas", tb =>
                {
                    tb.HasTrigger("veresimas_log_trd");
                    tb.HasTrigger("veresimas_log_tri");
                    tb.HasTrigger("veresimas_log_tru");
                    tb.HasTrigger("veresimas_trd");
                    tb.HasTrigger("veresimas_tri");
                    tb.HasTrigger("veresimas_triu");
                });

            entity.HasIndex(e => e.Yerad, "veresimas_idx");

            entity.HasIndex(e => e.Varno, "veresimas_idx2");

            entity.HasIndex(e => e.Fistip, "veresimas_idx3");

            entity.HasIndex(e => new { e.Sil, e.Aktip }, "veresimas_sil_aktip");

            entity.HasIndex(e => e.Verid, "veresimas_verid");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Verid).HasColumnName("verid");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Adaid).HasColumnName("adaid");
            entity.Property(e => e.Akid)
                .HasDefaultValue(0.0)
                .HasColumnName("akid");
            entity.Property(e => e.Aktar)
                .HasColumnType("datetime")
                .HasColumnName("aktar");
            entity.Property(e => e.Aktip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("BK")
                .HasColumnName("aktip");
            entity.Property(e => e.AlcCarSec).HasColumnName("Alc_CarSec");
            entity.Property(e => e.Bagid)
                .HasDefaultValue(0.0)
                .HasColumnName("bagid");
            entity.Property(e => e.BrcCarkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brc_carkod");
            entity.Property(e => e.BrcCarsec).HasColumnName("brc_carsec");
            entity.Property(e => e.BrcCartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("brc_cartip");
            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.Cardno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cardno");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Dataok)
                .HasDefaultValue(0)
                .HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Devir)
                .HasDefaultValue(false)
                .HasColumnName("devir");
            entity.Property(e => e.DevirliVadeTarih).HasColumnType("datetime");
            entity.Property(e => e.EmtiaIsle).HasColumnName("emtia_isle");
            entity.Property(e => e.Entegre).HasDefaultValue(false);
            entity.Property(e => e.EntegreAktar)
                .HasColumnType("datetime")
                .HasColumnName("Entegre_Aktar");
            entity.Property(e => e.EntegreTip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Entegre_Tip");
            entity.Property(e => e.Fatbelno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("fatbelno");
            entity.Property(e => e.Fatid)
                .HasDefaultValue(0L)
                .HasColumnName("fatid");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.FisAlcBagverid).HasColumnName("fis_alc_bagverid");
            entity.Property(e => e.FisAlcKocan).HasColumnName("fis_alc_kocan");
            entity.Property(e => e.FisCariverId).HasColumnName("fis_cariver_id");
            entity.Property(e => e.Fisad)
                .HasMaxLength(50)
                .HasColumnName("fisad");
            entity.Property(e => e.FisrapId).HasColumnName("fisrap_id");
            entity.Property(e => e.Fistip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fistip");
            entity.Property(e => e.FistipId).HasColumnName("fistip_id");
            entity.Property(e => e.FisturId).HasColumnName("fistur_id");
            entity.Property(e => e.Fiyfarktop)
                .HasDefaultValue(0.0)
                .HasColumnName("fiyfarktop");
            entity.Property(e => e.Gctip).HasColumnName("gctip");
            entity.Property(e => e.GecPerKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Gec_PerKod");
            entity.Property(e => e.GenelKdvToplam)
                .HasDefaultValue(0.0)
                .HasColumnName("Genel_KdvToplam");
            entity.Property(e => e.GenelKdvliToplam)
                .HasDefaultValue(0.0)
                .HasColumnName("Genel_KdvliToplam");
            entity.Property(e => e.Havuzfis)
                .HasDefaultValue(false)
                .HasColumnName("havuzfis");
            entity.Property(e => e.Havvarno)
                .HasDefaultValue(0.0)
                .HasColumnName("havvarno");
            entity.Property(e => e.HrkCarPro).HasColumnName("hrk_car_pro");
            entity.Property(e => e.HrkStkPro).HasColumnName("hrk_stk_pro");
            entity.Property(e => e.Isktop)
                .HasDefaultValue(0.0)
                .HasColumnName("isktop");
            entity.Property(e => e.IslemKur).HasColumnName("Islem_Kur");
            entity.Property(e => e.IslemParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Islem_ParaBrm");
            entity.Property(e => e.IstasAd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("istas_ad");
            entity.Property(e => e.IstasIl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("istas_il");
            entity.Property(e => e.KartKur).HasColumnName("Kart_Kur");
            entity.Property(e => e.KartParaBrm)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Kart_ParaBrm");
            entity.Property(e => e.Kayok)
                .HasDefaultValue(0)
                .HasColumnName("kayok");
            entity.Property(e => e.Kdvtip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kdvtip");
            entity.Property(e => e.Km)
                .HasDefaultValue(0.0)
                .HasColumnName("km");
            entity.Property(e => e.Kmsec).HasColumnName("kmsec");
            entity.Property(e => e.Kur)
                .HasDefaultValue(1.0)
                .HasColumnName("kur");
            entity.Property(e => e.Marsatid)
                .HasDefaultValue(0.0)
                .HasColumnName("marsatid");
            entity.Property(e => e.No)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("no");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.OncekiKm).HasDefaultValue(0.0);
            entity.Property(e => e.Otocarad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("otocarad");
            entity.Property(e => e.Otocarkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("otocarkod");
            entity.Property(e => e.OtomasAck)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("otomas_ack");
            entity.Property(e => e.OtomasId).HasColumnName("otomas_id");
            entity.Property(e => e.Ototag)
                .HasDefaultValue(0)
                .HasColumnName("ototag");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Plaka)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("plaka");
            entity.Property(e => e.PromPro).HasColumnName("prom_pro");
            entity.Property(e => e.RemoteId)
                .HasDefaultValue(0)
                .HasColumnName("remote_id");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Seri)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("seri");
            entity.Property(e => e.ServisFis).HasDefaultValue(false);
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
            entity.Property(e => e.Surucu)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("surucu");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.TopMik)
                .HasDefaultValue(0.0)
                .HasColumnName("Top_Mik");
            entity.Property(e => e.Toptut)
                .HasDefaultValue(0.0)
                .HasColumnName("toptut");
            entity.Property(e => e.TransferDateTime).HasColumnType("datetime");
            entity.Property(e => e.TransferStartId).HasDefaultValue(1);
            entity.Property(e => e.TransferStopId).HasDefaultValue(0);
            entity.Property(e => e.TtsOdemeTakip)
                .HasDefaultValue(false)
                .HasColumnName("TTS_OdemeTakip");
            entity.Property(e => e.TtsOdemeTarih)
                .HasColumnType("datetime")
                .HasColumnName("TTS_OdemeTarih");
            entity.Property(e => e.TtsTip)
                .HasDefaultValue(0)
                .HasColumnName("TTS_Tip");
            entity.Property(e => e.Utts)
                .HasDefaultValue(false)
                .HasColumnName("UTTS");
            entity.Property(e => e.Vadfarktop)
                .HasDefaultValue(0.0)
                .HasColumnName("vadfarktop");
            entity.Property(e => e.Vadtar)
                .HasColumnType("datetime")
                .HasColumnName("vadtar");
            entity.Property(e => e.Varok)
                .HasDefaultValue(0)
                .HasColumnName("varok");
            entity.Property(e => e.VtsOtoAktar).HasColumnName("vts_oto_aktar");
            entity.Property(e => e.Vtsid)
                .HasDefaultValue(0L)
                .HasColumnName("vtsid");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
            entity.Property(e => e.YkFisNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ykno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ykno");
        });

        modelBuilder.Entity<Veresiyenfiyhrk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__veresiye__3213E83FA26317D9");

            entity.ToTable("veresiyenfiyhrk", tb =>
                {
                    tb.HasTrigger("veresiyenfiyhrk_trd");
                    tb.HasTrigger("veresiyenfiyhrk_tri");
                });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ack)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.EskiFiyat).HasColumnName("eski_fiyat");
            entity.Property(e => e.EskiVadetar)
                .HasColumnType("datetime")
                .HasColumnName("eski_vadetar");
            entity.Property(e => e.Masterid).HasColumnName("masterid");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Verhrkid).HasColumnName("verhrkid");
            entity.Property(e => e.Verid).HasColumnName("verid");
            entity.Property(e => e.YeniFiyat).HasColumnName("yeni_fiyat");
            entity.Property(e => e.YeniVadetar)
                .HasColumnType("datetime")
                .HasColumnName("yeni_vadetar");
            entity.Property(e => e.Yerad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<ViewCariHrkFisIskListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_cari_hrk_fis_Isk_listesi");

            entity.Property(e => e.Aktip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("aktip");
            entity.Property(e => e.Alacak).HasColumnName("alacak");
            entity.Property(e => e.Ay).HasColumnName("ay");
            entity.Property(e => e.Borc).HasColumnName("borc");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Fisbakiye).HasColumnName("fisbakiye");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmhrkad)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("islmhrkad");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(50)
                .HasColumnName("islmtipad");
            entity.Property(e => e.Kur).HasColumnName("kur");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Unvan)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("unvan");
            entity.Property(e => e.Yil).HasColumnName("yil");
        });

        modelBuilder.Entity<ViewCariHrkFisListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_cari_hrk_fis_listesi");

            entity.Property(e => e.Aktip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("aktip");
            entity.Property(e => e.Alacak).HasColumnName("alacak");
            entity.Property(e => e.Ay).HasColumnName("ay");
            entity.Property(e => e.Borc).HasColumnName("borc");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Fisbakiye).HasColumnName("fisbakiye");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmhrkad)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("islmhrkad");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Islmtipad)
                .HasMaxLength(50)
                .HasColumnName("islmtipad");
            entity.Property(e => e.Kur).HasColumnName("kur");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Unvan)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("unvan");
            entity.Property(e => e.Yil).HasColumnName("yil");
        });

        modelBuilder.Entity<ViewCarilerKartBakiye>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Cariler_Kart_Bakiye");

            entity.Property(e => e.Ad)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("adres");
            entity.Property(e => e.Adres2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("adres2");
            entity.Property(e => e.AracAd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Arac_Ad");
            entity.Property(e => e.Carbak).HasColumnName("carbak");
            entity.Property(e => e.Cartp)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("cartp");
            entity.Property(e => e.CekBakiye).HasColumnName("cek_bakiye");
            entity.Property(e => e.CekharcBakiye).HasColumnName("cekharc_bakiye");
            entity.Property(e => e.Cep)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("cep");
            entity.Property(e => e.Crno).HasColumnName("crno");
            entity.Property(e => e.Evil)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evil");
            entity.Property(e => e.Evilce)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("evilce");
            entity.Property(e => e.Fatunvan)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("fatunvan");
            entity.Property(e => e.Fatvadfark).HasColumnName("fatvadfark");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("fax");
            entity.Property(e => e.Fisbak).HasColumnName("fisbak");
            entity.Property(e => e.Fisvadfark).HasColumnName("fisvadfark");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Grp3).HasColumnName("grp3");
            entity.Property(e => e.GrupAd)
                .HasMaxLength(100)
                .HasColumnName("Grup_Ad");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Mail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mail");
            entity.Property(e => e.Sl).HasColumnName("sl");
            entity.Property(e => e.Tcno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tcno");
            entity.Property(e => e.Tel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tel");
            entity.Property(e => e.Tip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.Topbak).HasColumnName("topbak");
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("vergidaire");
            entity.Property(e => e.Vergino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("vergino");
            entity.Property(e => e.YktAlmDefNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ykt_alm_def_no");
        });

        modelBuilder.Entity<ViewGrp1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_grp1");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .HasColumnName("ad");
            entity.Property(e => e.CalismaSartId).HasColumnName("Calisma_SartId");
            entity.Property(e => e.Dataok).HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kar1).HasColumnName("kar1");
            entity.Property(e => e.Kar2).HasColumnName("kar2");
            entity.Property(e => e.Kar3).HasColumnName("kar3");
            entity.Property(e => e.Kar4).HasColumnName("kar4");
            entity.Property(e => e.Kdv).HasColumnName("kdv");
            entity.Property(e => e.MuhAlsIadKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_iad_kod");
            entity.Property(e => e.MuhAlsIskKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_isk_kod");
            entity.Property(e => e.MuhAlsOtvKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_otv_kod");
            entity.Property(e => e.MuhSatIadKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_iad_kod");
            entity.Property(e => e.MuhSatIskKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_isk_kod");
            entity.Property(e => e.MuhSatMalKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_mal_kod");
            entity.Property(e => e.MuhSatOtvKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_otv_kod");
            entity.Property(e => e.MuhasebeGrupKodu)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Muhckskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhckskod");
            entity.Property(e => e.Muhgrskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhgrskod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.PerIdin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PerIDIN");
            entity.Property(e => e.RemoteId).HasColumnName("Remote_id");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Sr).HasColumnName("sr");
            entity.Property(e => e.Tabload)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tabload");
            entity.Property(e => e.YkKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ykkisno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ykkisno");
        });

        modelBuilder.Entity<ViewGrp2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_grp2");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .HasColumnName("ad");
            entity.Property(e => e.CalismaSartId).HasColumnName("Calisma_SartId");
            entity.Property(e => e.Dataok).HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kar1).HasColumnName("kar1");
            entity.Property(e => e.Kar2).HasColumnName("kar2");
            entity.Property(e => e.Kar3).HasColumnName("kar3");
            entity.Property(e => e.Kar4).HasColumnName("kar4");
            entity.Property(e => e.Kdv).HasColumnName("kdv");
            entity.Property(e => e.MuhAlsIadKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_iad_kod");
            entity.Property(e => e.MuhAlsIskKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_isk_kod");
            entity.Property(e => e.MuhAlsOtvKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_otv_kod");
            entity.Property(e => e.MuhSatIadKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_iad_kod");
            entity.Property(e => e.MuhSatIskKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_isk_kod");
            entity.Property(e => e.MuhSatMalKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_mal_kod");
            entity.Property(e => e.MuhSatOtvKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_otv_kod");
            entity.Property(e => e.MuhasebeGrupKodu)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Muhckskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhckskod");
            entity.Property(e => e.Muhgrskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhgrskod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.PerIdin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PerIDIN");
            entity.Property(e => e.RemoteId).HasColumnName("Remote_id");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Sr).HasColumnName("sr");
            entity.Property(e => e.Tabload)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tabload");
            entity.Property(e => e.YkKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ykkisno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ykkisno");
        });

        modelBuilder.Entity<ViewGrp3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_grp3");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .HasColumnName("ad");
            entity.Property(e => e.CalismaSartId).HasColumnName("Calisma_SartId");
            entity.Property(e => e.Dataok).HasColumnName("dataok");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Grp1).HasColumnName("grp1");
            entity.Property(e => e.Grp2).HasColumnName("grp2");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Kar1).HasColumnName("kar1");
            entity.Property(e => e.Kar2).HasColumnName("kar2");
            entity.Property(e => e.Kar3).HasColumnName("kar3");
            entity.Property(e => e.Kar4).HasColumnName("kar4");
            entity.Property(e => e.Kdv).HasColumnName("kdv");
            entity.Property(e => e.MuhAlsIadKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_iad_kod");
            entity.Property(e => e.MuhAlsIskKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_isk_kod");
            entity.Property(e => e.MuhAlsOtvKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_als_otv_kod");
            entity.Property(e => e.MuhSatIadKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_iad_kod");
            entity.Property(e => e.MuhSatIskKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_isk_kod");
            entity.Property(e => e.MuhSatMalKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_mal_kod");
            entity.Property(e => e.MuhSatOtvKod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muh_sat_otv_kod");
            entity.Property(e => e.MuhasebeGrupKodu)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Muhckskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhckskod");
            entity.Property(e => e.Muhgrskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhgrskod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.PerIdin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PerIDIN");
            entity.Property(e => e.RemoteId).HasColumnName("Remote_id");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Sr).HasColumnName("sr");
            entity.Property(e => e.Tabload)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tabload");
            entity.Property(e => e.YkKod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ykkisno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ykkisno");
        });

        modelBuilder.Entity<ViewHrklistesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_hrklistesi");

            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Ada)
                .HasMaxLength(100)
                .HasColumnName("ada");
            entity.Property(e => e.Adaid).HasColumnName("adaid");
            entity.Property(e => e.Bankad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("bankad");
            entity.Property(e => e.Bankod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("bankod");
            entity.Property(e => e.Belno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("belno");
            entity.Property(e => e.Carkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.Cartur)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cartur");
            entity.Property(e => e.Cikan).HasColumnName("cikan");
            entity.Property(e => e.Gctip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("gctip");
            entity.Property(e => e.Giren).HasColumnName("giren");
            entity.Property(e => e.Grp)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("grp");
            entity.Property(e => e.Grptip)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("grptip");
            entity.Property(e => e.Hrkad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("hrkad");
            entity.Property(e => e.Hrkid).HasColumnName("hrkid");
            entity.Property(e => e.Hrkidad)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("hrkidad");
            entity.Property(e => e.Id)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Islmhrk)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("islmhrk");
            entity.Property(e => e.Islmtip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("islmtip");
            entity.Property(e => e.Kasad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("kasad");
            entity.Property(e => e.Kaskod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kaskod");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Kur).HasColumnName("kur");
            entity.Property(e => e.Masterid).HasColumnName("masterid");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Perad)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("perad");
            entity.Property(e => e.Perkod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("perkod");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Tipad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipad");
            entity.Property(e => e.Unvan)
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("unvan");
            entity.Property(e => e.Vadetar)
                .HasColumnType("datetime")
                .HasColumnName("vadetar");
            entity.Property(e => e.Varno).HasColumnName("varno");
            entity.Property(e => e.Varok).HasColumnName("varok");
            entity.Property(e => e.Yerad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
        });

        modelBuilder.Entity<YazarKasaSati>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__YazarKas__3213E83F39A24343");

            entity.ToTable("YazarKasa_Satis");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BankaTerminalNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Barkod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Brim)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BrimFiyat).HasDefaultValue(0.0);
            entity.Property(e => e.Carpan).HasDefaultValue(1);
            entity.Property(e => e.FirmaNo).HasDefaultValue(0);
            entity.Property(e => e.FisNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.KasaTip)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.KasiyerKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.KasiyerUnvan)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Kdv).HasDefaultValue(0);
            entity.Property(e => e.Miktar).HasDefaultValue(0.0);
            entity.Property(e => e.NakitOdeme).HasDefaultValue(0.0);
            entity.Property(e => e.PosOdeme).HasDefaultValue(0.0);
            entity.Property(e => e.RemoteId).HasColumnName("Remote_Id");
            entity.Property(e => e.StokKod)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Tarih).HasColumnType("datetime");
            entity.Property(e => e.Trans).HasDefaultValue(false);
            entity.Property(e => e.Tutar).HasDefaultValue(0.0);
            entity.Property(e => e.VardiyaNo).HasDefaultValue(0);
            entity.Property(e => e.YazarKasaIslemId).HasDefaultValue(0);
            entity.Property(e => e.Zno)
                .HasDefaultValue(0)
                .HasColumnName("ZNo");
        });

        modelBuilder.Entity<Yazarkasa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__yazarkas__3213E83F586C4F66");

            entity.ToTable("yazarkasa");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("id");
            entity.Property(e => e.Aktar)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("-")
                .HasColumnName("aktar");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Dosyayer)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("dosyayer");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.Islemtipi)
                .HasMaxLength(50)
                .HasColumnName("islemtipi");
            entity.Property(e => e.Islmid).HasColumnName("islmid");
            entity.Property(e => e.KasaNo).HasDefaultValue(0);
            entity.Property(e => e.KasiyerNo).HasDefaultValue(0);
            entity.Property(e => e.Marsatid).HasColumnName("marsatid");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Saat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Users)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("users");
            entity.Property(e => e.Varno)
                .HasDefaultValue(0.0)
                .HasColumnName("varno");
            entity.Property(e => e.Yazkasatipi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("yazkasatipi");
        });

        modelBuilder.Entity<Yazarkasakart>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Firmano, e.Kod }).HasName("PK__yazarkas__2D8940EEF83452E0");

            entity.ToTable("yazarkasakart");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.DepoKod)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sil)
                .HasDefaultValue(0)
                .HasColumnName("sil");
        });

        modelBuilder.Entity<Yazkasagrpkart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__yazkasag__3213E83F700D2644");

            entity.ToTable("yazkasagrpkart");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Grp).HasColumnName("grp");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Sil).HasColumnName("sil");
        });

        modelBuilder.Entity<Yedek>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__yedek__3213E83F10CE6896");

            entity.ToTable("yedek");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dosyaad)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("dosyaad");
            entity.Property(e => e.Ok).HasColumnName("ok");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
        });

        modelBuilder.Entity<Yertipad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__yertipad__3213E83F1263C7F0");

            entity.ToTable("yertipad");

            entity.HasIndex(e => e.Kod, "UQ__yertipad__640EA3F6").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
        });

        modelBuilder.Entity<Yetki>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("yetki");

            entity.Property(e => e.Ad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Havuz).HasColumnName("havuz");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Modul)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sil).HasColumnName("sil");
            entity.Property(e => e.Sysyetki).HasColumnName("sysyetki");
        });

        modelBuilder.Entity<Yetkibolum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("yetkibolum");

            entity.Property(e => e.Bolumid).HasColumnName("bolumid");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Havuz).HasColumnName("havuz");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Modul)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Yetkiid).HasColumnName("yetkiid");
        });

        modelBuilder.Entity<Yetkifrm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("yetkifrm");

            entity.Property(e => e.Bolumid).HasColumnName("bolumid");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Frmid).HasColumnName("frmid");
            entity.Property(e => e.Havuz).HasColumnName("havuz");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Modul)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Yetkiid).HasColumnName("yetkiid");
        });

        modelBuilder.Entity<Yetkikont>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("yetkikont");

            entity.Property(e => e.Bolumid).HasColumnName("bolumid");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Frmid).HasColumnName("frmid");
            entity.Property(e => e.Havuz).HasColumnName("havuz");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Kontid).HasColumnName("kontid");
            entity.Property(e => e.Modul)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.RapId).HasColumnName("Rap_id");
            entity.Property(e => e.Yetkiid).HasColumnName("yetkiid");
        });

        modelBuilder.Entity<ZraporUrunKartListesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Zrapor_UrunKart_Listesi");

            entity.Property(e => e.Ad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ad");
            entity.Property(e => e.Brim)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("brim");
            entity.Property(e => e.Brimfiy).HasColumnName("brimfiy");
            entity.Property(e => e.Firmano).HasColumnName("firmano");
            entity.Property(e => e.Kdv).HasColumnName("kdv");
            entity.Property(e => e.Kod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Muhckskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhckskod");
            entity.Property(e => e.Muhgrskod)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("muhgrskod");
            entity.Property(e => e.Muhonkod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("muhonkod");
            entity.Property(e => e.Tip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("tip");
            entity.Property(e => e.TipId).HasColumnName("tip_id");
        });

        modelBuilder.Entity<ZraporVardiya>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ZraporVa__3213E83FDF02CE5B");

            entity.ToTable("ZraporVardiya");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DegisTarsaat).HasColumnType("datetime");
            entity.Property(e => e.DegisUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OlusUser)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Olustarsaat).HasColumnType("datetime");
            entity.Property(e => e.Sil).HasDefaultValue(false);
            entity.Property(e => e.VarAd)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Zraporhrk>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Zrapid }).HasName("PK__zraporhr__3EF8B5C3E872145B");

            entity.ToTable("zraporhrk", tb =>
                {
                    tb.HasTrigger("zraporhrk_trd");
                    tb.HasTrigger("zraporhrk_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Zrapid).HasColumnName("zrapid");
            entity.Property(e => e.Brmfiy)
                .HasDefaultValue(0.0)
                .HasColumnName("brmfiy");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Kayok)
                .HasDefaultValue((byte)0)
                .HasColumnName("kayok");
            entity.Property(e => e.Kdvyuz).HasColumnName("kdvyuz");
            entity.Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("kod");
            entity.Property(e => e.Miktar)
                .HasDefaultValue(0.0)
                .HasColumnName("miktar");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Sil)
                .HasDefaultValue(false)
                .HasColumnName("sil");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("tip");
        });

        modelBuilder.Entity<Zraporma>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Zrapid }).HasName("PK__zraporma__3EF8B5C35E4895FD");

            entity.ToTable("zrapormas", tb =>
                {
                    tb.HasTrigger("zrapormas_trd");
                    tb.HasTrigger("zrapormas_tru");
                });

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Zrapid).HasColumnName("zrapid");
            entity.Property(e => e.Ack)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ack");
            entity.Property(e => e.Carkod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("carkod");
            entity.Property(e => e.Cartip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cartip");
            entity.Property(e => e.CartipId).HasColumnName("cartip_id");
            entity.Property(e => e.Degtarsaat)
                .HasColumnType("datetime")
                .HasColumnName("degtarsaat");
            entity.Property(e => e.Deguser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("deguser");
            entity.Property(e => e.Entegre).HasDefaultValue(false);
            entity.Property(e => e.EntegreAktar)
                .HasColumnType("datetime")
                .HasColumnName("Entegre_Aktar");
            entity.Property(e => e.EntegreTip)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Entegre_Tip");
            entity.Property(e => e.Firmano)
                .HasDefaultValue(0)
                .HasColumnName("firmano");
            entity.Property(e => e.GenelAraTop)
                .HasDefaultValue(0.0)
                .HasColumnName("Genel_Ara_Top");
            entity.Property(e => e.GenelKdvTop)
                .HasDefaultValue(0.0)
                .HasColumnName("Genel_Kdv_Top");
            entity.Property(e => e.GenelTop)
                .HasDefaultValue(0.0)
                .HasColumnName("Genel_Top");
            entity.Property(e => e.Kayok)
                .HasDefaultValue((byte)0)
                .HasColumnName("kayok");
            entity.Property(e => e.Kur)
                .HasDefaultValue(1.0)
                .HasColumnName("kur");
            entity.Property(e => e.MasId).HasDefaultValue(0);
            entity.Property(e => e.NakTop)
                .HasDefaultValue(0.0)
                .HasColumnName("Nak_Top");
            entity.Property(e => e.Olustarsaat)
                .HasColumnType("datetime")
                .HasColumnName("olustarsaat");
            entity.Property(e => e.Olususer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("olususer");
            entity.Property(e => e.Parabrm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("parabrm");
            entity.Property(e => e.Pbrim)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("pbrim");
            entity.Property(e => e.PosTop)
                .HasDefaultValue(0.0)
                .HasColumnName("Pos_Top");
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("saat");
            entity.Property(e => e.Sil)
                .HasDefaultValue(false)
                .HasColumnName("sil");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("tarih");
            entity.Property(e => e.Toptut).HasColumnName("toptut");
            entity.Property(e => e.Varno)
                .HasDefaultValue(0)
                .HasColumnName("varno");
            entity.Property(e => e.VerTop)
                .HasDefaultValue(0.0)
                .HasColumnName("Ver_Top");
            entity.Property(e => e.Yerad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("yerad");
            entity.Property(e => e.Yertip)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("yertip");
            entity.Property(e => e.Ykkod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ykkod");
            entity.Property(e => e.Zraptip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("zraptip");
            entity.Property(e => e.Zseri)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("zseri");
            entity.Property(e => e.Zserino)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("zserino");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
