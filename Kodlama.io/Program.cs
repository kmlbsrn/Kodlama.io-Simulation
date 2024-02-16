


using Kodlama.io.Business.Dtos.Category;
using Kodlama.io.Business.Dtos.Course;
using Kodlama.io.Business.Dtos.Instructor;
using Kodlama.io.Business.Managers;
using Kodlama.io.Business.Services;
using Kodlama.io.Models.Category;
using System.Runtime.CompilerServices;

Console.WriteLine("Kodlama.io'a Hoş Geldiniz ");
Console.WriteLine("1.)Kategori");
Console.WriteLine("2.)Eğitmen");
Console.WriteLine("3.)Kurs");

Console.WriteLine("Lütfen bir seçim yapınız: ");

int choice = Convert.ToInt32(Console.ReadLine());


switch (choice)
{
    case 1:
        Category();
        break;
    case 2:
        Instructor();
        break;
    case 3:
        Course();
        break;

    default:
        break;
}




void Category()
{
    ICategoryService categoryService = new CategoryManager();

again:

    Console.WriteLine("1.)Kategori Ekle");
    Console.WriteLine("2.)Kategori Güncelle");
    Console.WriteLine("3.)Kategori Sil");
    Console.WriteLine("4.)Kategorileri Listele");

    Console.WriteLine("Lütfen bir seçim yapınız: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("Kategori ismi girin:");
            string categoryName = Console.ReadLine();
            categoryService.AddCategory(new CategoryAddDto { Name = categoryName });
            goto case 4;

        case 2:

            Console.WriteLine("Kategori id girin:");
            int categoryId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kategori ismi girin:");
            string categoryNameUpdate = Console.ReadLine();
            categoryService.UpdateCategory(new CategoryUpdateDto { Id = categoryId, Name = categoryNameUpdate });
            goto case 4;
        case 3:
            Console.WriteLine("Kategori id girin:");
            int categoryIdDelete = Convert.ToInt32(Console.ReadLine());
            categoryService.DeleteCategory(categoryIdDelete);
            goto case 4;
        case 4:
            var categories = categoryService.GetCategories();
            foreach (var category in categories)
            {
                Console.WriteLine($"Id: {category.Id} Name: {category.Name}");
            }
            Console.WriteLine("----------------------------------------------------------");
            goto again;
        default:
            Console.WriteLine("Geçersiz İşlem");
            break;
    }
}


void Instructor()
{
    IInstructorService instructorService = new InstructorManager();


    Console.WriteLine("1.)Eğitmen Ekle");
    Console.WriteLine("2.)Eğitmen Güncelle");
    Console.WriteLine("3.)Eğitmen Sil");
    Console.WriteLine("4.)Eğitmenleri Listele");

    Console.WriteLine("Lütfen bir seçim yapınız: ");


    int choice = Convert.ToInt32(Console.ReadLine());

    again:
    switch (choice)
    {
        case 1:
            Console.WriteLine("Eğitmen ismi girin:");
            string instructorName = Console.ReadLine();
            Console.WriteLine("Eğitmen soyadı girin:");
            string instructorSurname = Console.ReadLine();
            instructorService.AddInstructor(new InstructorAddDto { FirstName = instructorName, LastName = instructorSurname });
            goto case 4;
        case 2:
            Console.WriteLine("Eğitmen id girin:");
            int instructorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Eğitmen ismi girin:");
            string instructorNameUpdate = Console.ReadLine();
            Console.WriteLine("Eğitmen soyadı girin:");
            string instructorSurnameUpdate = Console.ReadLine();
            instructorService.UpdateInstructor(new InstructorUpdateDto { Id = instructorId, FirstName = instructorNameUpdate, LastName = instructorSurnameUpdate });
            goto case 4;
        case 3:
            Console.WriteLine("Eğitmen id girin:");
            int instructorIdDelete = Convert.ToInt32(Console.ReadLine());
            instructorService.DeleteInstructor(instructorIdDelete);
            goto case 4;
        case 4:
            var instructors = instructorService.GetInstructors();
            foreach (var instructor in instructors)
            {
                Console.WriteLine($"Id: {instructor.Id} Name: {instructor.FirstName} Surname: {instructor.LastName}");
            }
            Console.WriteLine("----------------------------------------------------------");
            goto again;
        default:
            Console.WriteLine("Geçersiz İşlem");
            break;
    }
}


void Course()
{
    ICourseService courseService = new CourseManager();

    Console.WriteLine("Kurs");

    Console.WriteLine("1.)Kurs Ekle");
    Console.WriteLine("2.)Kurs Güncelle");
    Console.WriteLine("3.)Kurs Sil");
    Console.WriteLine("4.)Kursları Listele");

    int choice = Convert.ToInt32(Console.ReadLine());

    again:

   switch (choice)
    {
        case 1:
            Console.WriteLine("Kurs ismi girin:");
            string courseName = Console.ReadLine();

            Console.WriteLine("Kurs fiyatı girin:");
            int coursePrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kurs eğitmen id girin:");
            int instructorId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kurs kategori id girin:");
            int categoryId = Convert.ToInt32(Console.ReadLine());
            courseService.AddCourse(new CourseAddDto { Name = courseName, Price = coursePrice, InstructorId = instructorId, CategoryId = categoryId });
            goto case 4;
        case 2:
            Console.WriteLine("Kurs id girin:");
            int courseId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kurs ismi girin:");
            string courseNameUpdate = Console.ReadLine();
            Console.WriteLine("Kurs açıklaması girin:");
            string courseDescriptionUpdate = Console.ReadLine();
            Console.WriteLine("Kurs fiyatı girin:");
            int coursePriceUpdate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kurs eğitmen id girin:");
            int instructorIdUpdate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kurs kategori id girin:");
            int categoryIdUpdate = Convert.ToInt32(Console.ReadLine());
            courseService.UpdateCourse(new CourseUpdateDto { Id = courseId, Name = courseNameUpdate, Description = courseDescriptionUpdate, Price = coursePriceUpdate, InstructorId = instructorIdUpdate, CategoryId = categoryIdUpdate });
            goto case 4;
        case 3:
            Console.WriteLine("Kurs id girin:");
            int courseIdDelete = Convert.ToInt32(Console.ReadLine());
            courseService.DeleteCourse(courseIdDelete);
            goto case 4;
        case 4:
            var courses = courseService.GetCourses();
            foreach (var course in courses)
            {
                Console.WriteLine($"Id: {course.Id} Name: {course.Name}  Price: {course.Price} InstructorId: {course.InstructorName} CategoryId: {course.CategoryName}");
            }
            Console.WriteLine("----------------------------------------------------------");
            break;
        default:
            Console.WriteLine("Geçersiz İşlem");
            break;
    }

}