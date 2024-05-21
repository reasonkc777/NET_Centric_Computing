using Microsoft.AspNetCore.Mvc;
using AdoNetApp.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace AdoNetApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly IConfiguration _configuration;

        public StudentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {
            using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                con.Open();
                string query = "INSERT INTO Students (StudentName, Course, Semester) VALUES (@StudentName, @Course, @Semester)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StudentName", student.StudentName);
                cmd.Parameters.AddWithValue("@Course", student.Course);
                cmd.Parameters.AddWithValue("@Semester", student.Semester);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            return RedirectToAction("List");
        }

        public IActionResult List()
        {
            List<Student> students = new List<Student>();
            using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                con.Open();
                string query = "SELECT * FROM Students";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        StudentId = reader.GetInt32(0),
                        StudentName = reader.GetString(1),
                        Course = reader.GetString(2),
                        Semester = reader.GetString(3)
                    });
                }
                con.Close();
            }
            return View(students);
        }
    }
}
