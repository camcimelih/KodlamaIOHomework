using KodlamaIOHomework.Abstract;
using KodlamaIOHomework.Bussines;
using KodlamaIOHomework.Concreate;
using KodlamaIOHomework.Entity;

ICourseDal courseDal = new CourseDal();
Course java = new Course {Id=1,Name="java",CategoryId=1,InstructorId=2};
courseDal.Add(java);

CourseManager courseManager = new CourseManager(courseDal);
List<Course> courses = courseManager.GetAll();
ShowCourseList(courses);
courseDal.Delete(java);
courseDal.Update(java);

ShowCourseList(courses);
ICategoryDal categoryDal = new CategoryDal();
Category category2 = new Category { Id = 2, Name = "cyber security"};
categoryDal.Add(category2);

CategroyManager categoryManager = new CategroyManager(categoryDal);
List<Category> categories = categoryManager.GetAll();
ShowCategoryList(categories);


categoryDal.Delete(category2);
categoryDal.Update(category2);
ShowCategoryList(categories);

IInstructorDal instructorDal = new InstructorDal();
Instructor instructor2 = new Instructor { FirstName = "murat", LastName = "YÜCEDAĞ", Id = 3 };
instructorDal.Add(instructor2);

InstructorManager instructorManager = new InstructorManager(instructorDal);
List<Instructor> instructors = instructorManager.GetAll();
ShowInstructorList(instructors);


instructorDal.Delete(instructor2);
instructorDal.Update(instructor2);
ShowInstructorList(instructors);


void ShowCourseList(List<Course> courses)
{
    foreach (var course in courses)
    {
        Console.WriteLine(course.Name);
    }
}

void ShowCategoryList(List<Category> categories)
{
    foreach (var category in categories)
    {
        Console.WriteLine(category.Name);
    }
}

void ShowInstructorList(List<Instructor> instructors)
{
    foreach (var instructor in instructors)
    {
        Console.WriteLine(instructor.FirstName+" "+instructor.LastName);
    }
}

