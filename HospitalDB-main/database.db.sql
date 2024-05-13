SELECT * FROM PATIENT;

SELECT * FROM PATIENT_ICE;

SELECT * FROM EMPLOYEE;

SELECT * FROM PHYSICIAN;

SELECT * FROM NURSE;

SELECT * FROM CHART;

SELECT * FROM HOSPITAL;

--Update patient insurance info for patient with ssn 999999999
UPDATE PATIENT
SET insurance = 'Medicare Insurance'
WHERE ssn = '999999999';

--Insert ICE contact for patient 999999999
INSERT INTO PATIENT_ICE (patient_ssn, phone_number, first_name, last_name)
VALUES (999999999, '987-654-4321', 'Jane', 'Doe');

--Insert chart record for patient 999999999
INSERT INTO CHART (chart_id, patient_ssn, visit_type, admission_date, discharge_date, room_number, physician_license, nurse_registration, hosp_id)
VALUES (105, 999999999, 'Yearly Checkup', '2024-03-26', NULL, 'D310', NULL, 73645, 12345);

--List Physicians and all the patients they have worked on by first name and last name
SELECT DISTINCT e.first_name, e.last_name, p.first_name, p.last_name
FROM EMPLOYEE e
JOIN PHYSICIAN ON e.ssn = social
JOIN PATIENT p ON patient_ssn = p.ssn
JOIN CHART ON license_num = physician_license;

--List all nurses and their certifications
SELECT first_name, last_name, certifications
FROM EMPLOYEE
JOIN NURSE ON ssn = social;

--Update all physician salaries
UPDATE EMPLOYEE
SET salary = salary * 1.2
FROM PHYSICIAN
WHERE ssn = social;

--List all employees working at Hospital 12345
SELECT first_name, last_name
FROM EMPLOYEE
WHERE hosp_id = 12345;

--Display count of unique patients that have visited hospital 54321
SELECT COUNT(DISTINCT patient_ssn)
FROM CHART
WHERE hosp_id = 54321;

--Display count of unique employees at hosptial 54321
SELECT COUNT(DISTINCT ssn)
FROM EMPLOYEE
WHERE hosp_id = 54321;

--List all hospital by name, id, and address
SELECT hos_name, hos_id, street_address, city, st, zip
FROM HOSPITAL;

--List all charts that have a nurse assigned and no physician assigned
SELECT *
FROM CHART
WHERE physician_license IS NULL;