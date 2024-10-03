cmake_minimum_required(VERSION 3.27)
project(all)

set(CMAKE_CXX_STANDARD 17)

add_executable(main lab1/main.cpp)
add_executable(fio lab1/fio.cpp)

add_executable(lab2-for lab2/lab2-for.cpp)
add_executable(lab2-while lab2/lab2-while.cpp)

add_executable(lab3 lab3/lab3.cpp)

add_executable(lab4 lab4/lab4.cpp)
