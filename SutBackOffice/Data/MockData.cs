namespace SutBackOffice.Data;

// ---------------------------------------------------------------------------
// ข้อมูลจำลองภาษาไทย (Mock Data) ตามดีไซน์ Figma ของ SUT Student Freelance Back Office
// ---------------------------------------------------------------------------

public class StudentUser
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string Faculty { get; set; } = "";
    public string Dorm { get; set; } = "";
    public string Registered { get; set; } = "";
    public string Status { get; set; } = "ปกติ"; // ปกติ | ระงับชั่วคราว | ถูกแบน
    public string Email => $"{Id.ToLower()}@g.sut.ac.th";
    public string Initials => string.Concat(Name.Split(' ', StringSplitOptions.RemoveEmptyEntries).Take(2).Select(s => s[0]));
    public bool EmailVerified => Status != "ถูกแบน";
}

public class ProviderStore
{
    public string Shop { get; set; } = "";
    public string Est { get; set; } = "";
    public string Icon { get; set; } = "code";
    public string Owner { get; set; } = "";
    public string StudentId { get; set; } = "";
    public string Major { get; set; } = "";
    public string Category { get; set; } = "";
    public int Gigs { get; set; }
    public int Orders { get; set; }
    public double Rating { get; set; }
    public int Reviews { get; set; }
    public string Status { get; set; } = "อนุมัติแล้ว"; // อนุมัติแล้ว | รอการตรวจสอบ | ระงับชั่วคราว
}

public record VerificationItem(string StudentId, string Name, string Faculty, string Service, string Submitted, string Status);

public record CategoryItem(string Name, string Description, string Icon, string Slug, int Gigs, double Fee, bool Visible, string Status);
public record SubCategory(string Name, string Slug, int Gigs, double Split);

public class GigItem
{
    public string Id { get; set; } = "";
    public string Title { get; set; } = "";
    public string Age { get; set; } = "";
    public string Provider { get; set; } = "";
    public string ProviderId { get; set; } = "";
    public string Dorm { get; set; } = "";
    public string Category { get; set; } = "";
    public string Price { get; set; } = "";
    public int Orders { get; set; }
    public double Rating { get; set; }
    public string Compliance { get; set; } = "ปกติ"; // ปกติ | แจ้งเตือนคีย์เวิร์ด | ปิดชั่วคราว
    public string ComplianceNote { get; set; } = "";
    public string Status { get; set; } = "เปิดให้บริการปกติ"; // เปิดให้บริการปกติ | รอการตรวจสอบ | ถูกระงับ
    public string Tint { get; set; } = "#e2e8f0";
}

public record FlaggedReview(string Id, string Rating, int Stars, string Customer, string CustomerId, string Provider, string ProviderId, string Quote, string Confidence, string Severity, string Date);

public class ModReview
{
    public string Id { get; set; } = "";
    public string Date { get; set; } = "";
    public string Waiting { get; set; } = "";
    public string Gig { get; set; } = "";
    public string Provider { get; set; } = "";
    public string Reviewer { get; set; } = "";
    public string ReviewerMeta { get; set; } = "";
    public string Dorm { get; set; } = "";
    public int Stars { get; set; }
    public string Pre { get; set; } = "";
    public string Highlight { get; set; } = "";
    public string Post { get; set; } = "";
    public string AiFlag { get; set; } = "";
    public string Tag1 { get; set; } = "";
    public string Tag2 { get; set; } = "";
    public string Resolution { get; set; } = "รอตรวจสอบ";
}

public class MediaItem
{
    public string Id { get; set; } = "";
    public string Kind { get; set; } = "";
    public string Tag { get; set; } = "";
    public string TagKind { get; set; } = "safe"; // risk | warn | safe
    public string Banner { get; set; } = "";
    public string Ago { get; set; } = "";
    public string Title { get; set; } = "";
    public string Provider { get; set; } = "";
    public string Meta { get; set; } = "";
    public string Gradient { get; set; } = "";
    public string Decision { get; set; } = "";
    public bool Selected { get; set; }
}

public class DisputeCase
{
    public string Id { get; set; } = "";
    public string Title { get; set; } = "";
    public string Summary { get; set; } = "";
    public string Reporter { get; set; } = "";
    public string Accused { get; set; } = "";
    public string Type { get; set; } = "";
    public string Urgency { get; set; } = "";   // เร่งด่วนสูง | ปานกลาง | ทั่วไป
    public string Age { get; set; } = "";
    public string Column { get; set; } = "triage"; // triage | investigation | resolved
}

public record AuditEvent(string Time, string Actor, string Role, string Action, string ActionKind, string Target, string TargetNote, string Ip);

public record SentimentTrendPoint(int Week, double Positive, double Negative);

public static class MockData
{
    public static readonly string[] Faculties =
    {
        "สำนักวิชาวิศวกรรมศาสตร์ (วิศวกรรมคอมพิวเตอร์)",
        "สำนักวิชาเทคโนโลยีสารสนเทศ",
        "สำนักวิชาวิศวกรรมศาสตร์ (วิศวกรรมเครื่องกล)",
        "สำนักวิชาเทคโนโลยีดิจิทัล",
        "สำนักวิชาวิศวกรรมศาสตร์ (วิศวกรรมไฟฟ้า)",
        "สำนักวิชาเทคโนโลยีการเกษตร",
        "สำนักวิชาวิศวกรรมศาสตร์ (วิศวกรรมอุตสาหการ)",
        "สำนักวิชาวิศวกรรมศาสตร์ (วิศวกรรมโทรคมนาคม)"
    };

    public static List<StudentUser> Students() => new()
    {
        new() { Id="B6802189", Name="ธนภัทร สุขสันต์ (Tanapat Sooksan)", Faculty="สำนักวิชาวิศวกรรมศาสตร์ (วิศวกรรมคอมพิวเตอร์)", Dorm="หอ 4 (ชาย โซน A)", Registered="14 ส.ค. 2024" },
        new() { Id="B6710443", Name="พิชญา กิตติศักดิ์ (Pitchapa Kittisak)", Faculty="สำนักวิชาเทคโนโลยีสารสนเทศ", Dorm="หอ 11 (หญิง โซน B)", Registered="2 ก.ย. 2024" },
        new() { Id="B6639102", Name="ณัฐวุฒิ ประเสริฐ (Nattawut Prasert)", Faculty="สำนักวิชาวิศวกรรมศาสตร์ (วิศวกรรมเครื่องกล)", Dorm="สุรนิเวศ 15", Registered="10 ต.ค. 2023", Status="ระงับชั่วคราว" },
        new() { Id="B6858210", Name="ชญานิศ วงศ์สุวรรณ (Chayanit Wongsuwan)", Faculty="สำนักวิชาเทคโนโลยีดิจิทัล", Dorm="หอ 12 (หญิง โซน B)", Registered="22 ก.ค. 2024" },
        new() { Id="B6790012", Name="ศรัณย์ สมชัย (Sarun Somchai)", Faculty="สำนักวิชาวิศวกรรมศาสตร์ (วิศวกรรมไฟฟ้า)", Dorm="หอ 2 (ชาย โซน A)", Registered="15 ม.ค. 2024", Status="ถูกแบน" },
        new() { Id="B6814290", Name="วราภรณ์ บุญมี (Waraporn Boonmee)", Faculty="สำนักวิชาเทคโนโลยีการเกษตร", Dorm="สุรนิเวศ 16", Registered="18 มิ.ย. 2024" },
        new() { Id="B6829104", Name="กรวิชญ์ สุวรรณ (Korawit Suwan)", Faculty="สำนักวิชาวิศวกรรมศาสตร์ (วิศวกรรมอุตสาหการ)", Dorm="หอ 6 (ชาย โซน A)", Registered="29 ส.ค. 2024" },
        new() { Id="B6705411", Name="มนัสวี เทพนรินทร์ (Manussawee Thepnarin)", Faculty="สำนักวิชาวิศวกรรมศาสตร์ (วิศวกรรมโทรคมนาคม)", Dorm="หอ 9 (หญิง โซน B)", Registered="12 พ.ย. 2023" },
    };

    public static List<VerificationItem> VerificationQueue() => new()
    {
        new("B6814290", "ธนกร ประเสริฐ", "สำนักวิชาวิศวกรรมศาสตร์ (วิศวกรรมคอมพิวเตอร์)", "ไอทีและโค้ดดิ้ง", "วันนี้ 09:15", "รอการตรวจสอบ"),
        new("B6829104", "ณัฐพร สมชัย", "สำนักวิชาวิทยาศาสตร์ (ฟิสิกส์ประยุกต์)", "ติววิชาการ", "วันนี้ 08:40", "รอการตรวจสอบ"),
        new("B6705411", "จิรภัทร วงศ์สุวรรณ", "สำนักวิชาเทคโนโลยีดิจิทัล", "ออกแบบ UI/UX", "เมื่อวาน 16:30", "รอการตรวจสอบ"),
        new("B6831092", "กัญญา รัตนกุล", "สำนักวิชาเทคโนโลยีการเกษตร", "แปลเอกสาร", "เมื่อวาน 14:15", "แนบเอกสารแล้ว"),
        new("B6691455", "ศรัณย์ กิตติศักดิ์", "สำนักวิชาเทคโนโลยีสังคม", "จัดทำสไลด์นำเสนอ", "23 ต.ค. 11:20", "ยืนยันตัวตนแล้ว"),
    };

    public static List<ProviderStore> Providers() => new()
    {
        new() { Shop="CodeSUT Studio", Est="เริ่มให้บริการ ภาค 1/2566", Icon="code", Owner="ธนกร ประเสริฐ", StudentId="B6802189", Major="วิศวกรรมคอมพิวเตอร์", Category="ไอทีและโค้ดดิ้ง", Gigs=3, Orders=38, Rating=4.9, Reviews=38 },
        new() { Shop="KhunPloy Translations", Est="เริ่มให้บริการ ภาค 2/2566", Icon="languages", Owner="ณัฐพร สมชัย", StudentId="B6829104", Major="สาขาภาษาอังกฤษ", Category="แปลและจัดทำเอกสาร", Gigs=2, Orders=54, Rating=4.8, Reviews=52 },
        new() { Shop="GraphicSUT Minimal", Est="เริ่มให้บริการ ภาค 1/2565", Icon="palette", Owner="จิรภัทร วงศ์สุวรรณ", StudentId="B6705411", Major="เทคโนโลยีดิจิทัล", Category="UI/UX และกราฟิก", Gigs=5, Orders=112, Rating=4.95, Reviews=108 },
        new() { Shop="Tutor Nat Physics", Est="เริ่มให้บริการ ภาค 1/2567", Icon="book", Owner="กัญญา รัตนกุล", StudentId="B6831092", Major="ฟิสิกส์ประยุกต์", Category="ติววิชาการ", Gigs=1, Orders=29, Rating=4.7, Reviews=28, Status="รอการตรวจสอบ" },
        new() { Shop="ProTyping SUT", Est="เริ่มให้บริการ ภาค 2/2564", Icon="keyboard", Owner="ศรัณย์ กิตติศักดิ์", StudentId="B6691455", Major="เทคโนโลยีสารสนเทศ", Category="พิมพ์งานและเอกสาร", Gigs=4, Orders=87, Rating=4.6, Reviews=81, Status="ระงับชั่วคราว" },
    };

    public static List<(CategoryItem Cat, List<SubCategory> Subs)> Categories() => new()
    {
        (new("ติววิชาการและสอบ (Tutoring & Academic)", "ฟิสิกส์, แคลคูลัส, เคมี, ภาษาอังกฤษเพื่อการสื่อสาร", "graduation", "/tutoring-academic", 360, 5.0, true, "เปิดใช้งาน"),
            new() { new("แคลคูลัสและคณิตศาสตร์ขั้นสูง (Calculus & Advanced Math)", "/calculus", 114, 5.0), new("ฟิสิกส์และกลศาสตร์ประยุกต์ (Physics & Applied Mechanics)", "/physics", 92, 5.0), new("โปรแกรมมิ่ง Python และโครงสร้างข้อมูล", "/python-dev", 105, 5.0), new("ตรวจไวยากรณ์ภาษาอังกฤษและงานเขียนวิชาการ", "/english-proofreading", 49, 5.0) }),
        (new("พิมพ์งานและแปลเอกสาร (Writing & Translation)", "จัดรูปเล่มวิทยานิพนธ์, แปลบทความ, สรุปชีทเรียน, LaTeX", "printer", "/writing-translation", 222, 3.5, true, "เปิดใช้งาน"), new()),
        (new("ออกแบบกราฟิกและสื่อ (Graphic & Media)", "UI/UX, โลโก้, สื่อโฆษณา, วิดีโอสั้น, สติกเกอร์", "palette", "/graphic-media", 185, 7.0, true, "เปิดใช้งาน"), new()),
        (new("ไอทีและโค้ดดิ้ง (IT & Coding)", "เขียนโปรแกรม, พัฒนาเว็บ, AI & IoT, แก้ไขสคริปต์", "code", "/it-coding", 142, 5.0, true, "เปิดใช้งาน"), new()),
        (new("ขนย้ายหอพักและโลจิสติกส์ (Dorm Moving & Logistics)", "ช่วยย้ายหอพัก, ขนกล่องสัมภาระ, ประกอบเฟอร์นิเจอร์", "truck", "/dorm-moving", 88, 4.0, true, "เปิดใช้งาน"), new()),
        (new("ถ่ายภาพและตัดต่อ (Photography & Production)", "ถ่ายภาพรับปริญญา มทส., ถ่ายโปรไฟล์, สตูดิโอ", "camera", "/photography-production", 19, 5.0, false, "ซ่อนชั่วคราว"), new()),
    };

    public static List<GigItem> Gigs() => new()
    {
        new() { Id="#SRV-1049", Title="เขียนสคริปต์ Python และระบบประมวลผลข้อมูลอัตโนมัติ", Age="อัปเดตเมื่อ 2 วันที่ผ่านมา", Provider="ธนกร ประเสริฐ", ProviderId="B6802189", Dorm="วิศวกรรมคอมพิวเตอร์", Category="ไอทีและโค้ดดิ้ง", Price="350 บาท", Orders=38, Rating=4.9, Tint="#c7d2fe" },
        new() { Id="#SRV-9902", Title="รับทำโปรเจกต์จบ / เขียนรายงานสอบแทน", Age="ตรวจพบคีย์เวิร์ดฝ่าฝืน: ทำโปรเจกต์จบแทน", Provider="ศรัณย์ สมชัย", ProviderId="B6790012", Dorm="วิศวกรรมไฟฟ้า", Category="ผิดหมวดหมู่", Price="2,500 บาท", Orders=0, Rating=0.0, Compliance="แจ้งเตือนคีย์เวิร์ด", ComplianceNote="ตรวจพบคีย์เวิร์ดฝ่าฝืนวินัยวิชาการ", Status="รอการตรวจสอบ", Tint="#fecaca" },
        new() { Id="#SRV-1082", Title="จัดรูปแบบเอกสารและวิทยานิพนธ์ LaTeX ตามฟอร์แมต มทส.", Age="อัปเดตเมื่อ 4 ชั่วโมงที่แล้ว", Provider="ธนกร ประเสริฐ", ProviderId="B6802189", Dorm="หอพัก 4 (โซนวิศวกรรม)", Category="แปลและเอกสาร", Price="200 บาท", Orders=19, Rating=4.8, Tint="#e5e7eb" },
        new() { Id="#SRV-2015", Title="ติวเตรียมสอบฟิสิกส์ 1 และแคลคูลัสตัวต่อตัว", Age="อัปเดตเมื่อ 1 สัปดาห์ก่อน", Provider="กัญญา รัตนกุล", ProviderId="B6831092", Dorm="ฟิสิกส์ประยุกต์", Category="ติววิชาการ", Price="150 บาท/ชม.", Orders=64, Rating=5.0, Tint="#cbd5e1" },
        new() { Id="#SRV-2041", Title="ออกแบบสไลด์นำเสนอโปรเจกต์และอินโฟกราฟิก", Age="อัปเดตเมื่อ 3 วันก่อน", Provider="ศรัณย์ กิตติศักดิ์", ProviderId="B6691455", Dorm="เทคโนโลยีสังคม", Category="ออกแบบและสื่อ", Price="180 บาท", Orders=42, Rating=4.9, Tint="#e2e8f0" },
        new() { Id="#SRV-3011", Title="ถ่ายภาพพอร์ตโฟลิโอและรับปริญญาในแคมปัส มทส.", Age="พักการรับงานโดยนักศึกษา", Provider="จิรภัทร วงศ์สุวรรณ", ProviderId="B6705411", Dorm="เทคโนโลยีดิจิทัล", Category="ถ่ายภาพ", Price="500 บาท", Orders=11, Rating=4.7, Compliance="ปิดชั่วคราว", Status="ถูกระงับ", Tint="#d1d5db" },
    };

    public static List<FlaggedReview> FlaggedReviews() => new()
    {
        new("#REV-8841", "1 ดาว", 1, "ชลิตา ม.", "B6710443", "ณัฐวุฒิ พ.", "B6639102", "\"ผู้รับจ้างหยุดตอบแชตก่อนถึงกำหนดส่งงานเพียง 2 ชั่วโมง และส่งไฟล์ DOCX ที่เนื้อหายังไม่สมบูรณ์\"", "0.96", "ระดับสูง", "24 ต.ค., 21:15 น."),
        new("#REV-8820", "2 ดาว", 2, "อนันต์ ท.", "B6800194", "ศิริกัญญา บ.", "B6745129", "\"เรียกเก็บค่าบริการแก้ไขงานเพิ่มเติม ทั้งที่ระบุไว้ในรายละเอียดบริการแล้วว่าแก้ไขฟรี\"", "0.91", "ระดับสูง", "23 ต.ค., 14:30 น."),
        new("#REV-8795", "1 ดาว", 1, "กิตติศักดิ์ ร.", "B6588210", "พงศกร ล.", "B6811234", "\"ผลการคำนวณในรายงานแล็บวิศวกรรมถูกแต่งขึ้นมาทั้งหมด และใส่หน่วยวัดผิดพลาดทุกจุด\"", "0.98", "วิกฤต", "22 ต.ค., 18:05 น."),
        new("#REV-8762", "2 ดาว", 2, "พิชญา ส.", "B6790012", "ธีรดล ว.", "B6622891", "\"ใช้น้ำเสียงและถ้อยคำก้าวร้าวมากเมื่อถูกทวงถามเรื่องความล่าช้าในการส่งมอบงาน\"", "0.89", "ระดับสูง", "21 ต.ค., 09:45 น."),
    };

    public static List<ModReview> ModerationReviews() => new()
    {
        new() { Id="#REV-8841", Date="24 ต.ค. 2567 · 21:15 น.", Waiting="รอตรวจ 2 ชม.", Gig="เขียนสคริปต์ Python อัตโนมัติ", Provider="CodeSUT Studio", Reviewer="ชลิตา ม.", ReviewerMeta="B6710443 · วิศวกรรมอุตสาหการ", Dorm="หอพัก 11 (โซน 3)", Stars=1,
            Pre="\"", Highlight="ผู้รับจ้างหยุดตอบแชตก่อนถึงกำหนดส่งงานเพียง 2 ชั่วโมง และส่งไฟล์ ZIP ที่ว่างเปล่ามาให้", Post=" ทำให้งานกลุ่มเสียหายหนักมาก\"", AiFlag="AI แจ้งเตือน: ข้อกล่าวหาเรื่องการเบี้ยวงานและมีถ้อยคำรุนแรง (94%)", Tag1="เชิงลบ", Tag2="ความไม่พอใจสูง" },
        new() { Id="#REV-8839", Date="24 ต.ค. 2567 · 19:40 น.", Waiting="รอตรวจ 4 ชม.", Gig="ติวสรุปก่อนสอบ Calculus 3", Provider="Tutor Nat Math", Reviewer="ผู้ใช้งานไม่ระบุตัวตน", ReviewerMeta="B6700812 · วิศวกรรมเครื่องกล", Dorm="หอพัก 4 (โซน 1)", Stars=2,
            Pre="\"ผู้ติวสัญญาว่าจะส่งแนวข้อสอบกลางภาคให้ ", Highlight="แต่ไม่ได้ให้แนวข้อสอบจริง มีเพียงการทบทวนแบบฝึกหัดท้ายบทเรียนเท่านั้น", Post=" ไม่คุ้มกับค่าเรียน 800 บาทเลย\"", AiFlag="แจ้งเตือนระเบียบ มทส.: สุ่มเสี่ยงการจูงใจทุจริตข้อสอบตามข้อบังคับ 14.b", Tag1="วินัยวิชาการ", Tag2="เชิงลบ" },
        new() { Id="#REV-8835", Date="24 ต.ค. 2567 · 16:02 น.", Waiting="รอตรวจ 7 ชม.", Gig="ปั้นโมเดล 3D และทำ Rigging ใน Unity", Provider="GraphicSUT Minimal", Reviewer="ปัณณทัต ว.", ReviewerMeta="B6723490 · วิศวกรรมคอมฯ", Dorm="หอพัก 8 (โซน 2)", Stars=1,
            Pre="\"นำไฟล์โมเดลจากเว็บ Sketchfab มาส่งโดยตรง ", Highlight="อ้างว่าเป็นคนปั้นโมเดลเองทั้งหมด แต่ตรวจสอบพบว่าคัดลอกจากไฟล์แจกฟรีแบบ 100%", Post=" ไม่แนะนำให้จ้างงานครับ\"", AiFlag="AI แจ้งเตือน: ข้อกล่าวหาการละเมิดลิขสิทธิ์และคัดลอกผลงาน", Tag1="ละเมิดลิขสิทธิ์", Tag2="เชิงลบ" },
        new() { Id="#REV-8828", Date="24 ต.ค. 2567 · 11:22 น.", Waiting="รอตรวจ 12 ชม.", Gig="รับซักรีดและทำความสะอาดห้องพักหอใน", Provider="CleanDorm SUT", Reviewer="กิตติพงศ์ ล.", ReviewerMeta="B6704518 · ฟิสิกส์", Dorm="หอพัก 2 (โซน 1)", Stars=2,
            Pre="\"", Highlight="ผู้ให้บริการคะยั้นคะยอให้โอนเงินผ่านพร้อมเพย์โดยตรงเพื่อหลีกเลี่ยงค่าธรรมเนียมแพลตฟอร์ม 5%", Post=" พอปฏิเสธก็ใช้คำพูดไม่สุภาพในแชต LINE\"", AiFlag="AI แจ้งเตือน: การหลีกเลี่ยงระบบชำระเงินกลาง (Escrow Circumvention)", Tag1="เชิงลบ", Tag2="ธุรกรรมนอกระบบ" },
    };

    public static List<MediaItem> Media() => new()
    {
        new() { Id="#IMG-8815", Kind="ความเสี่ยงละเมิดกฎ", Tag="AI ตรวจพบ: ข้อสอบเก่า/ส่อทุจริต มทส. (98.4%)", TagKind="risk", Ago="อัปโหลดเมื่อ 1 ชั่วโมงที่แล้ว", Title="บริการ: รับทำสรุปข้อสอบลับ แคลคูลัส 2 #GIG-108", Provider="ธนภัทร ส. (B6802189) • หอพัก 4", Gradient="linear-gradient(135deg,#cbd5e1,#94a3b8)", Selected=false },
        new() { Id="#IMG-8798", Kind="แจ้งเตือนเครื่องหมายการค้า", Tag="AI ตรวจพบ: ตราสัญลักษณ์ มทส. / QR ชวนคุยนอกระบบ (91.2%)", TagKind="warn", Ago="อัปโหลดเมื่อ 4 ชั่วโมงที่แล้ว", Title="เสื้อรับน้องและกระเป๋าผ้าตรามหาวิทยาลัย #GIG-319", Provider="อภิญญา ก. (B6714022) • สุรนิเวศ 2", Gradient="linear-gradient(135deg,#fde68a,#f59e0b)", Selected=true },
        new() { Id="#IMG-8821", Kind="ผ่านเกณฑ์ปลอดภัย", Tag="AI ผ่านเกณฑ์ 99.8%", TagKind="safe", Ago="อัปโหลดเมื่อ 35 นาทีที่แล้ว", Title="หมวดหมู่: ไอทีและโค้ดดิ้ง — สคริปต์ Python #GIG-204", Provider="ธนกร ประเสริฐ (B6802189) • หอพัก 4", Gradient="linear-gradient(135deg,#e2e8f0,#cbd5e1)", Selected=true },
        new() { Id="#IMG-8791", Kind="ตัวอย่างผลงานพอร์ตโฟลิโอ", Tag="AI ผ่านเกณฑ์ 99.5%", TagKind="safe", Ago="อัปโหลดเมื่อ 5 ชั่วโมงที่แล้ว", Title="หมวดหมู่: เขียนแบบวิศวกรรมโยธา 3D CAD #GIG-092", Provider="ณัฐพงศ์ ท. (B6589312) • เทคโนธานี", Gradient="linear-gradient(135deg,#bfdbfe,#60a5fa)" },
        new() { Id="#IMG-8809", Kind="ภาพปกบริการ", Tag="AI ผ่านเกณฑ์ 99.1%", TagKind="safe", Ago="อัปโหลดเมื่อ 2 ชั่วโมงที่แล้ว", Title="หมวดหมู่: ถ่ายภาพรับปริญญา มทส. #GIG-410", Provider="จิรภัทร วงศ์สุวรรณ (B6705411) • หอพัก 7", Gradient="linear-gradient(135deg,#fecaca,#fb923c)" },
        new() { Id="#IMG-8802", Kind="ไฟล์ส่งมอบงานในแชต", Tag="AI ผ่านเกณฑ์ 98.7%", TagKind="safe", Ago="อัปโหลดเมื่อ 3 ชั่วโมงที่แล้ว", Title="หมวดหมู่: ออกแบบสไลด์และแดชบอร์ด #ORD-8941", Provider="ศรัณย์ กิตติศักดิ์ (B6691455) • สุรนิเวศ 1", Gradient="linear-gradient(135deg,#334155,#0f172a)" },
    };

    public static List<DisputeCase> Disputes() => new()
    {
        new() { Id="#DISP-2024-089", Title="ส่งงานไม่ตรงสเปก / โค้ดใช้งานไม่ได้", Summary="ผู้ว่าจ้างระบุว่างานส่งมอบระบบ Web App มีข้อผิดพลาดร้ายแรง ไม่สามารถรันโปรเจกต์ได้ภายในเวลาที่ตกลง 48 ชม.", Reporter="ปิยะวัฒน์ ส. (B6710443)", Accused="ธนกร ป. (B6802189)", Type="ไม่ส่งมอบตามสเปก", Urgency="เร่งด่วนสูง", Age="24 นาทีที่แล้ว", Column="triage" },
        new() { Id="#DISP-2024-092", Title="ขอเงินคืนเนื่องจากส่งงานล่าช้ากว่ากำหนด 5 วัน", Summary="งานสรุปเล่มวิศวกรรมส่งเลยกำหนดส่งอาจารย์ ผู้ว่าจ้างต้องการยกเลิกสัญญาและขอคืนเงินในระบบ Escrow", Reporter="ณภัทร ช. (B6639102)", Accused="ศรัณย์ ก. (B6691455)", Type="ส่งงานล่าช้า", Urgency="ปานกลาง", Age="2 ชั่วโมงที่แล้ว", Column="triage" },
        new() { Id="#DISP-2024-078", Title="ข้อพิพาทขอบเขตการแก้ไขงานอินโฟกราฟิกเกินสัญญา", Summary="ผู้ว่าจ้างขอแก้ไขงานครั้งที่ 6 โดยไม่เพิ่มค่าจ้างตามที่ตกลงในเงื่อนไขเริ่มต้น", Reporter="พิมพ์มาดา ต. (B6814290)", Accused="จิรภัทร ว. (B6705411)", Type="ขอบเขตงาน", Urgency="ทั่วไป", Age="4 ชั่วโมงที่แล้ว", Column="triage" },
        new() { Id="#REP-1037", Title="ข้อสงสัยการคัดลอกผลงานโมเดล 3D / ละเมิดลิขสิทธิ์", Summary="ตรวจพบไฟล์ CAD 3D ตรงกับคลังโมเดลสาธารณะบน Sketchfab โดยไม่ได้รับอนุญาต", Reporter="วราภรณ์ บ. (B6814290)", Accused="กิตติพงศ์ ล. (B6704518)", Type="ละเมิดลิขสิทธิ์", Urgency="ปานกลาง", Age="กำลังตรวจสอบ", Column="investigation" },
        new() { Id="#DISP-2024-085", Title="การเรียกเก็บเงินนอกระบบ / ยกเลิกงานกะทันหัน", Summary="ฟรีแลนซ์ขอให้โอนมัดจำผ่านบัญชีส่วนตัวโดยตรงเพื่อหลีกเลี่ยงค่าธรรมเนียมแพลตฟอร์ม", Reporter="รัฐภูมิ น. (B6790012)", Accused="นพดล ว. (B6705411)", Type="ธุรกรรมนอกระบบ", Urgency="เร่งด่วนสูง", Age="3 ชั่วโมงที่แล้ว", Column="investigation" },
    };

    public static List<AuditEvent> AuditEvents() => new()
    {
        new("24 ต.ค. 14:32:10", "ดร. พรชัย ก.", "SUPER ADMIN", "USER_BAN_PERMANENT", "red", "นักศึกษา: B6790012", "ระงับบัญชีนักศึกษาถาวร (ละเมิดวินัยวิชาการ)", "202.28.68.104"),
        new("24 ต.ค. 14:15:02", "อ. ชิดชนก ม.", "MODERATOR", "VERIFY_PROVIDER_APPROVED", "green", "ร้านค้า: B6802950", "อนุมัติการเปิดร้านค้าฟรีแลนซ์ (ผ่าน KYC)", "202.28.68.104"),
        new("24 ต.ค. 13:50:44", "ระบบอัตโนมัติ", "SUT-VisionGuard", "CONTENT_IMAGE_QUARANTINE", "amber", "รูปภาพ: #IMG-8815", "ซ่อนรูปภาพผลงานสุ่มเสี่ยงผิดลิขสิทธิ์ตราสัญลักษณ์", "127.0.0.1 (Local)"),
        new("24 ต.ค. 13:22:18", "ไม่ทราบบัญชี", "AUTH GUARD", "AUTH_FAILED_LOCKOUT", "red", "เซสชัน IP: 171.96.220.12", "การยืนยันตัวตนล้มเหลวเกิน 4 ครั้ง (ล็อกบัญชีชั่วคราว)", "171.96.220.12"),
        new("24 ต.ค. 12:40:11", "ดร. พรชัย ก.", "SUPER ADMIN", "CONFIG_FEE_UPDATE", "purple", "พารามิเตอร์: GlobalFee", "ปรับอัตราค่าธรรมเนียมแพลตฟอร์มหมวดติววิชาการเป็น 3%", "10.0.4.15 (VPN)"),
    };

    public static readonly double[] DailyOrders = { 52, 88, 104, 142, 126, 112, 98 };
    public static readonly double[] WeeklyOrders = { 640, 720, 810, 790, 880, 920, 860 };
    public static readonly string[] Days = { "จันทร์", "อังคาร", "พุธ", "พฤหัสบดี", "ศุกร์", "เสาร์", "อาทิตย์" };

    public static readonly SentimentTrendPoint[] Trend =
    {
        new(1, 92, 4), new(2, 90, 6), new(3, 88, 9), new(4, 86, 22), new(5, 80, 14), new(6, 91, 3)
    };
}
