import psycopg2
from psycopg2 import Error


def create_connection(db_name, db_user, db_password, db_host, db_port):
    connection = psycopg2.connect(
        database=db_name,
        user=db_user,
        password=db_password,
        host=db_host,
        port=db_port,
    )
    print("Соединение установлено")

    return connection


def get_bookings(connection):
    try:
        cursor = connection.cursor()
        select_query = ("SELECT bookings.id, bookings.check_in, bookings.check_out,"
                        "clients.surname || ' ' || clients.first_name || ' ' || clients.last_name"
                        " FROM bookings"
                        " JOIN clients ON bookings.client_id = clients.id"
                        " ORDER BY id DESC"
                        )
        cursor.execute(select_query)
        rows = cursor.fetchall()

        print("---+----------------------------------+----------------------------------+---------------------------+")
        print("%-2s | %-32s | %-32s | %-25s |" % ('Id', 'Дата въезда', 'Дата выезда', 'ФИО клиента'))
        print("---+----------------------------------+----------------------------------+---------------------------+")
        for row in rows:
            print("%-2d | %-32s | %-32s | %-25s |" % (row[0], row[1], row[2], row[3]))
        cursor.close()

    except psycopg2.Error as e:
        print(e.diag.message_primary)
        connection.rollback()

def get_administrators(connection):
    try:
        cursor = connection.cursor()
        select_query = "Select first_name, last_name, surname, phone FROM administrators"
        cursor.execute(select_query)
        rows = cursor.fetchall()
        cursor.close()

        print("-----------+------------+------------+------------+---------------+-----------+")
        print("%-10s | %-10s | %-10s | %-10s" %
              ('Имя', 'Отчество', 'Фамилия', 'Телефон')
        )
        print("-----------+------------+------------+------------+---------------+-----------+")
        for row in rows:
            print("%-10s | %-10s | %-10s | %-10s" %
                  (row[0], row[1], row[2], row[3])
            )

    except psycopg2.Error as e:
        print(e.diag.message_primary)
        connection.rollback()

def get_clients(connection):
    try:
        cursor = connection.cursor()
        select_query = "Select first_name, last_name, surname, passport, birthday, citizenship FROM clients"
        cursor.execute(select_query)
        rows = cursor.fetchall()
        cursor.close()

        print("-----------+------------+------------+------------+---------------+-----------+")
        print("%-10s | %-10s | %-10s | %-10s | %-10s | %-10s" %
              ('Имя', 'Отчество', 'Фамилия', 'Паспорт', 'Дата рождения', 'Гражданство')
        )
        print("-----------+------------+------------+------------+---------------+-----------+")
        for row in rows:
            print("%-10s | %-10s | %-10s | %-10s | %-13s | %-10s" %
                  (row[0], row[1], row[2], row[3], row[4], row[5])
                  )

    except psycopg2.Error as e:
        print(e.diag.message_primary)
        connection.rollback()


def add_booking(connection):
    try:
        cursor = connection.cursor()

        check_in = input('Введите дату заезда: ')
        admin_id = int(input('Введите id администратора: '))
        client_id = int(input('Введите id клиента: '))
        room_id = int(input('Введите id номера: '))

        insert_query = "SELECT add_booking(%s, %s, %s, %s)"

        cursor.execute(insert_query, (check_in, admin_id, client_id, room_id))

        connection.commit()
    except psycopg2.Error as e:
        print(e.diag.message_primary)
        connection.rollback()


user = input("Введите имя пользователя:  ")
password = input("Введите пароль:  ")

try:
    connection = create_connection("Hotel_clone", user, password, "172.17.9.2", "5432")
    operation = 0
    while operation != '0':
        print()
        print('1 - Список бронирований | 2 - Список клиентов | 3 - Список администраторов | 4 - Добавить бронь | 0 - Выход')
        operation = input('Выберите операцию: ')

        if operation == '1':
            get_bookings(connection)
        if operation == '2':
            get_clients(connection)
        if operation == '3':
            get_administrators(connection)
        if operation == '4':
            add_booking(connection)
        if operation == '0':
            connection.close()

except (Exception, Error) as e:
    input('Ошибка соединения')