# dcit318-assignment4-11352458

 DCIT 318 Programming II — Assignment
This repository contains two separate Windows Forms Applications developed for DCIT 318: Programming II.

## 📂 1️⃣ Project 1: Medical Booking App
🔹###  Description:
A simple C# Windows Forms desktop app for booking medical appointments and viewing doctors.

## 🔹 Features:

MainForm: Landing form with buttons.

DoctorListForm: Shows all doctors in a DataGridView.

AppointmentForm: Lets a patient book an appointment with a doctor.

ManageAppointmentsForm: Lets admin view, update, or delete existing appointments.

## 🔹 Technologies:

C# Windows Forms (.NET 8)

Microsoft SQL Server (MedicalDB)

Microsoft.Data.SqlClient for DB connection

DataGridView for showing doctors & appointments

### 🔹 Database:

Tables: Doctors, Patients, Appointments

CRUD operations for booking and managing.

## 📂 2️⃣ Project 2: Pharmacy Inventory System
🔹 Description:
A Windows Forms desktop app for managing pharmacy stock and sales.

### 🔹 Features:

Add new medicines with name, category, price, and quantity.

Search medicines by name or category.

Update stock using UpdateStock stored procedure.

Record sales with RecordSale stored procedure.

View all medicines in a DataGridView.

## 🔹 Technologies:

C# Windows Forms (.NET 8)

Microsoft SQL Server (PharmacyDB)

Microsoft.Data.SqlClient for DB operations

DataGridView for inventory view

## 🔹 Database:

Database name: PharmacyDB

Tables:

Medicines (MedicineID, Name, Category, Price, Quantity)

Sales (SaleID, MedicineID, QuantitySold, SaleDate)

Stored Procedures:

AddMedicine

SearchMedicine

UpdateStock

RecordSale

GetAllMedicines

### ✅ 📌 How to run
1️⃣ Clone the repo or unzip.
2️⃣ Open the .sln file in Visual Studio 2022+.
3️⃣ Ensure SQL Server is running and your connection string matches your local server.
4️⃣ Run CREATE DATABASE and CREATE TABLE scripts if needed.
5️⃣ Start the project — use buttons to test all features.

### ✅ 📌 Dependencies
.NET 8 SDK

Microsoft SQL Server 2019/2022

Microsoft.Data.SqlClient NuGet package

Proper connection strings in App.config

### ✅ 📌 Author
Course: DCIT 318 Programming II



### ✅ 📌 Submission
✔️ This project is organized into separate folders per app:

/MedicalBookingApp

/PharmacyInventorySystem

✔️ Each is committed separately as per assignment instructions.

