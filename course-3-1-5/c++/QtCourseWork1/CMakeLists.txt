cmake_minimum_required(VERSION 3.19)
project(QtCourseWork1 LANGUAGES CXX)

find_package(Qt6 6.5 REQUIRED COMPONENTS Core Widgets LinguistTools)

qt_standard_project_setup()

set(CMAKE_AUTORCC ON)

qt_add_executable(QtCourseWork1
    WIN32 MACOSX_BUNDLE
    main.cpp
    mainwindow.cpp
    mainwindow.h
    mainwindow.ui
    resources.qrc
)

qt_add_translations(
    TARGETS QtCourseWork1
    TS_FILES QtCourseWork1_ru_RU.ts
)

target_link_libraries(QtCourseWork1
    PRIVATE
        Qt::Core
        Qt::Widgets
)

install(TARGETS QtCourseWork1
    BUNDLE  DESTINATION .
    RUNTIME DESTINATION ${CMAKE_INSTALL_BINDIR}
    LIBRARY DESTINATION ${CMAKE_INSTALL_LIBDIR}
)

qt_generate_deploy_app_script(
    TARGET QtCourseWork1
    OUTPUT_SCRIPT deploy_script
    NO_UNSUPPORTED_PLATFORM_ERROR
)
install(SCRIPT ${deploy_script})
