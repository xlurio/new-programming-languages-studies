cmake_minimum_required(VERSION 3.14)
project(my_project)

# GoogleTest requires at least C++14
set(CMAKE_CXX_STANDARD 14)

include(FetchContent)
FetchContent_Declare(
  googletest
  GIT_REPOSITORY https://github.com/google/googletest.git
  GIT_TAG release-1.12.1
)
# For Windows: Prevent overriding the parent project's compiler/linker settings
set(gtest_force_shared_crt ON CACHE BOOL "" FORCE)
FetchContent_MakeAvailable(googletest)

enable_testing()

add_executable(
    test_merge_sort
    test_merge_sort.cc
)

target_link_libraries(
    test_merge_sort
    GTest::gtest_main
)

target_link_libraries(
    test_merge_sort
    gmock
)

include(GoogleTest)
gtest_discover_tests(test_merge_sort)