import sqlite3

##### DATA TO TEST WITH ####
NULL = None

hospitals = [
    (12345, 'Seattle Grace', '432 Seattle Dr.', 'Seattle', 'WA', 53412),
    (54321, 'Mercy West', '603 Other Seattle Dr.', 'You guessed it...', 'Kansas', 90897),
    (11223, 'Grey/Sloan Memorial', '1738 Hey Whassup Hello Ln', 'Washington', 'D.C.', 56382),
    (24680, NULL, NULL, NULL, NULL, NULL)
]

patients = [
    (999999999, 'John', 'Doe', '01-01-1970', 'non-binary', 'BCBSM', '555-555-5555', '123 Main St', 'Novi', 'MI', 48374),
    (111111111, 'Jane', 'Doe', '01-01-1971', 'female', 'United', '555-565-5555', '345 Lane Ln', 'Sterling Heights', 'MI', 48310),
    (555555555, 'Some', 'Dude', '1-23-4567', 'male', NULL, '629-830-2345', '432 Sup Dr.', "A Town", "A State", 94823)
]

emergency_contacts = [
    (999999999, 'Jill', 'Wutshername', '248-555-5555'),
    (999999999, 'His', 'Kid', '123-456-7890'),
    (111111111, 'John', 'Doe', '789-456-1234')
]

chart = [
    (1, 'A101', 'Check-Up', 12345, 999999999, '4-7-2024', '4-8-2024', 487362, 73645),
    (5, 'A103', 'Admitted', 54321, 999999999, '4-8-2024', NULL, 487362, 73645),
    (14, 'C403', 'In-Patient', 11223, 111111111, '4-9-2024', '4-10-2024', 487362, 73645),
    (16, 'A103', 'Out-Patient', 54321, 111111111, '4-10-2024', '4-10-2024', NULL, 73645)
]

employees = [
    (123121231, 'Doc', 'McDoctor', '3-17-1995', '191 Doctor Ave', 'Doctor City', 'Doctor State', 11111, 12345, 95000),
    (456454564, 'Nurse', 'Nursington', '2-17-1991', '919 Nurse Blvd', 'Nurse City', 'Nurse State', 99999, 54321, 75000),
    (555445555, 'Generic', 'Employee', '6-18-2003', '555 Employee Dr', 'Company', 'State', 22222, 12345, 53250)
]

physicians = [
    (123121231, "Neuroscience", 487362)
]

nurses = [
    (456454564, 'Pediatrics, Emergency Room, Clinical', 73645, 'LPN')
]

####### END OF DATA ########

# connection to database
# open/create and connect to database
con = sqlite3.connect('database.db')

# cursor to execute queries
# "cursor" used to execute queries
c = con.cursor()

# create tables
def createTables():
    c.execute("""CREATE TABLE IF NOT EXISTS HOSPITAL (
        hos_id INT PRIMARY KEY,
        hos_name CHAR(50),
        street_address CHAR(50),
        city CHAR(50),
        st CHAR(15),
        zip INT
    );""")

    c.execute("""CREATE TABLE IF NOT EXISTS PATIENT (
        ssn INT PRIMARY KEY,
        first_name CHAR (50) NOT NULL,
        last_name CHAR (50) NOT NULL,
        birthdate CHAR(10) NOT NULL,
        gender CHAR(10) NOT NULL,
        insurance CHAR(50),
        phone_number CHAR(50) NOT NULL,
        street_address CHAR(50) NOT NULL,
        city CHAR(50) NOT NULL,
        st CHAR(15) NOT NULL,
        zip INT NOT NULL
    );""")

    c.execute("""CREATE TABLE IF NOT EXISTS PATIENT_ICE (
        patient_ssn INT,
        first_name CHAR(50),
        last_name CHAR(50),
        phone_number CHAR(50) NOT NULL UNIQUE,
        PRIMARY KEY (patient_ssn, first_name, last_name),
        FOREIGN KEY (patient_ssn) REFERENCES PATIENT(ssn)
    );""")

    c.execute("""CREATE TABLE IF NOT EXISTS CHART (
        chart_id INT PRIMARY KEY,
        room_number CHAR(4) NOT NULL,
        visit_type CHAR(50) NOT NULL,
        hosp_id INT NOT NULL,
        patient_ssn INT NOT NULL,
        admission_date CHAR(10) NOT NULL,
        discharge_date CHAR(10),
        physician_license INT,
        nurse_registration INT NOT NULL,
        FOREIGN KEY (hosp_id) REFERENCES HOSPITAL(hos_id),
        FOREIGN KEY (patient_ssn) REFERENCES PATIENT(ssn),
        FOREIGN KEY (physician_license) REFERENCES PHYSICIAN(license_num),
        FOREIGN KEY (nurse_registration) REFERENCES NURSE(registration_num)
    );""")

    c.execute("""CREATE TABLE IF NOT EXISTS EMPLOYEE (
        ssn INT PRIMARY KEY,
        first_name CHAR (50) NOT NULL,
        last_name CHAR (50) NOT NULL,
        birthdate CHAR(50) NOT NULL,
        street_address CHAR(50) NOT NULL,
        city CHAR(50) NOT NULL,
        st CHAR(15) NOT NULL,
        zip INT NOT NULL,
        hosp_id INT NOT NULL,
        salary INT NOT NULL
    );""")

    c.execute("""CREATE TABLE IF NOT EXISTS PHYSICIAN (
        social INT,
        specialization CHAR(50),
        license_num INT,
        PRIMARY KEY (social, license_num),
        FOREIGN KEY (social) REFERENCES EMPLOYEE(ssn)
    );""")

    c.execute("""CREATE TABLE IF NOT EXISTS NURSE (
        social INT,
        certifications CHAR(256) NOT NULL,
        registration_num INT,
        nurse_level CHAR(4) NOT NULL,
        PRIMARY KEY (social, registration_num),
        FOREIGN KEY (social) REFERENCES EMPLOYEE(ssn)
    );""")

# get field values
def getFieldValues(name):
    fields = []
    formatted_fields = ''
    
    res = c.execute(f"PRAGMA table_info({name});")
    table_info = list(res.fetchall())

    for data in table_info:
        fields.append(data[1])

    formatted_fields += '('
    for i, field in enumerate(fields):
        if i == len(fields) - 1:
            formatted_fields += field + ')'
        else:
            formatted_fields += field + ', '
    
    return formatted_fields

# insert into tables
def insertIntoTable(table_name, rows):
    fields = getFieldValues(table_name)

    for row in rows:
        row = str(row)
        if 'None' in row:
            row = row.replace('None', 'NULL')   
        print(f"INSERT INTO {table_name.upper()} {fields} VALUES {row};")
        print()
        c.execute(f"INSERT INTO {table_name.upper()} {fields} VALUES {row};")

    # Commit after ANY changes to the database
    con.commit()

# printing table
def printTable(table_name):
    res = c.execute(f"PRAGMA table_info({table_name});")

    # fetchall() and fetchone() return tuples; cannot use list notation
    # cast as a list when you need access to specific indeces
    fields = list(res.fetchall())

    res = c.execute(f"SELECT * FROM {table_name};")
    table = res.fetchall()

    print(table_name)
    print('------------------------------')
    print("|", end = "")
    for header in fields:
       print(f"{str(list(header)[1]).ljust(25)}" + " |", end = "")
    print('\n')

    for row in table:
        print("|", end = "")
        for column in row:
            print(f"{str(column).ljust(25)}" + " |", end ="")
        print('\n')
    
    print('\n\n')

def main():
    # build tuples that contain (table name, table rows)
    data = [('HOSPITAL', hospitals), 
            ('PATIENT', patients),
            ('PATIENT_ICE', emergency_contacts),
            ('CHART', chart),
            ('EMPLOYEE', employees),
            ('PHYSICIAN', physicians),
            ('NURSE', nurses)
    ]

    # clean slate always
    c.execute("DROP TABLE HOSPITAL;")
    c.execute("DROP TABLE PATIENT;")
    c.execute("DROP TABLE PATIENT_ICE;")
    c.execute("DROP TABLE CHART;")
    c.execute("DROP TABLE EMPLOYEE;")
    c.execute("DROP TABLE PHYSICIAN;")
    c.execute("DROP TABLE NURSE;")

    # initialize and create tables, if they do not exist already
    createTables()

    # insert the table rows into their respective tables
    for table_tuple in data:
        table_name, fields = table_tuple
        insertIntoTable(table_name, list(fields))

    # print the tables by name
    printTable('HOSPITAL')
    printTable('PATIENT')
    printTable('PATIENT_ICE')
    printTable('CHART')
    printTable('EMPLOYEE')
    printTable('PHYSICIAN')
    printTable('NURSE')

if __name__ == '__main__':
    main()