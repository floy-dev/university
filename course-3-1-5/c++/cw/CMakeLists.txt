cmake_minimum_required(VERSION 3.30)
project(cw)

set(CMAKE_CXX_STANDARD 23)

set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -static-libgcc -static-libstdc++ -static")

include_directories(${CMAKE_SOURCE_DIR}/library)
include_directories(./library)

add_executable(cw main.cpp)

add_custom_command(TARGET cw POST_BUILD
        COMMAND ${CMAKE_COMMAND} -E copy_directory
        ${CMAKE_SOURCE_DIR}/library $<TARGET_FILE_DIR:cw>/library
)