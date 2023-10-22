//Parol
using Behruz27.Xafsizlik;

Parol parol = new Parol();
parol.Xafsizlik();
////malumot kiritish
Malumot malumot = new Malumot();
malumot.MalumoT();

//shaxsning tug'ulgan yilni aniqlash
malumot.YiliniAniqlash();

//shaxsning hamma ma'lumotni olish
//eslatma: bunda bizga Passport ID bilan murojat qilingandagina barcha malumotlarni olish imkoni bor
// bunda Passport ID bilan kursatilingan parol faqat malumotlarni olish uchun ishlatilsin.
//string password1 = "";
malumot.MalumotniOlish();

//shaxning qaysi yosh oralig'ida ekanini aniqlash
malumot.YoshOraligi();



