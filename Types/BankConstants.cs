// Hand-crafted constants for Tingee SDK — do NOT auto-generate

namespace Tingee.Sdk.Types;

public enum BankName
{
    OCB,
    BIDV,
    MBB,
    ACB,
    VPB,
    PGB,
    VIB,
    STB,
    CTG,
    VCB,
    AGRIBANK,
    SHINHAN,
    COB,
    MSB,
}

/// <summary>Bank BIN (Bank Identification Number) constants — string equivalent of BankBinEnum in other SDKs.</summary>
public static class BankBin
{
    public const string OCB      = "970448";
    public const string BIDV     = "970418";
    public const string MBB      = "970422";
    public const string ACB      = "970416";
    public const string VPB      = "970432";
    public const string PGB      = "970430";
    public const string VIB      = "970441";
    public const string STB      = "970403";
    public const string CTG      = "970415";
    public const string VCB      = "970436";
    public const string AGRIBANK = "970405";
    public const string SHINHAN  = "970424";
    public const string COB      = "970446";
}

public enum BankAccountType
{
    PersonalAccount,
    BusinessAccount,
    BusinessHouseHoldAccount,
}

public static class BankAccountTypeExtensions
{
    public static string ToApiString(this BankAccountType value) => value switch
    {
        BankAccountType.PersonalAccount          => "personal-account",
        BankAccountType.BusinessAccount          => "business-account",
        BankAccountType.BusinessHouseHoldAccount => "business-household-account",
        _ => throw new ArgumentOutOfRangeException(nameof(value), value, null),
    };
}

public sealed class BankInfo
{
    public BankName Code      { get; init; }
    public string   Name      { get; init; } = string.Empty;
    public string   ShortName { get; init; } = string.Empty;
    public string   Bin       { get; init; } = string.Empty;
}

public static class BankConstants
{
    private static readonly Lazy<IReadOnlyList<BankInfo>> _banks = new(BuildBanks);

    public static IReadOnlyList<BankInfo> Banks => _banks.Value;

    /// <summary>Find bank code (BankName enum) by BIN.</summary>
    public static BankName? GetBankCode(string bankBin) =>
        Banks.FirstOrDefault(b => b.Bin == bankBin)?.Code;

    /// <summary>Find short name by BIN.</summary>
    public static string? GetBankShortName(string bankBin) =>
        Banks.FirstOrDefault(b => b.Bin == bankBin)?.ShortName;

    /// <summary>Find BIN by bank name enum.</summary>
    public static string? GetBankBin(BankName bankName) =>
        Banks.FirstOrDefault(b => b.Code == bankName)?.Bin;

    private static IReadOnlyList<BankInfo> BuildBanks() =>
    [
        new() { Code = BankName.VCB,      Name = "Ngân hàng TMCP Ngoại Thương Việt Nam",                   ShortName = "Vietcombank",  Bin = "970436" },
        new() { Code = BankName.CTG,      Name = "Ngân hàng TMCP Công thương Việt Nam",                     ShortName = "VietinBank",   Bin = "970415" },
        new() { Code = BankName.BIDV,     Name = "Ngân hàng TMCP Đầu tư và Phát triển Việt Nam",            ShortName = "BIDV",         Bin = "970418" },
        new() { Code = BankName.AGRIBANK, Name = "Ngân hàng Nông nghiệp và Phát triển Nông thôn Việt Nam",  ShortName = "Agribank",     Bin = "970405" },
        new() { Code = BankName.MBB,      Name = "Ngân hàng TMCP Quân đội",                                 ShortName = "MB Bank",      Bin = "970422" },
        new() { Code = BankName.ACB,      Name = "Ngân hàng TMCP Á Châu",                                   ShortName = "ACB",          Bin = "970416" },
        new() { Code = BankName.OCB,      Name = "Ngân hàng TMCP Phương Đông",                              ShortName = "OCB Bank",     Bin = "970448" },
        new() { Code = BankName.VPB,      Name = "Ngân hàng TMCP Việt Nam Thịnh Vượng",                    ShortName = "VPBank",       Bin = "970432" },
        new() { Code = BankName.STB,      Name = "Ngân hàng TMCP Sài Gòn Thương Tín",                      ShortName = "Sacombank",    Bin = "970403" },
        new() { Code = BankName.VIB,      Name = "Ngân hàng TMCP Quốc tế Việt Nam",                        ShortName = "VIB",          Bin = "970441" },
        new() { Code = BankName.PGB,      Name = "Ngân Hàng TMCP Thịnh vượng và Phát triển",               ShortName = "PGBank",       Bin = "970430" },
        new() { Code = BankName.SHINHAN,  Name = "Ngân hàng TNHH MTV Shinhan Việt Nam",                     ShortName = "Shinhan Bank", Bin = "970424" },
        new() { Code = BankName.COB,      Name = "Ngân hàng Hợp tác Xã Việt Nam",                          ShortName = "Co-opBank",    Bin = "970446" },
    ];
}
