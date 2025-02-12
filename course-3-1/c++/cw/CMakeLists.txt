cmake_minimum_required(VERSION 3.30)
project(cw)

set(CMAKE_SYSTEM_NAME Windows)  # Говорим CMake, что собираем под Windows
set(CMAKE_C_COMPILER x86_64-w64-mingw32-gcc)
#set(CMAKE_CXX_COMPILER x86_64-w64-mingw32-g++)
set(CMAKE_RC_COMPILER x86_64-w64-mingw32-windres)

set(CMAKE_CXX_STANDARD 23)
#set (CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -static-libstdc++ -static-libgcc")

add_executable(cw main.cpp
        deps/words.cpp
        deps/words.h
        deps/utils.h
        deps/utils.cpp)
