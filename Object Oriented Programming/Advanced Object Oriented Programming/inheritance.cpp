//
// Created by Admin on Dec 22 2022.
//

// SMH

/* NOTE:
 * public inheritance makes public members of the base class public in the derived class,
 * and the protected members of the base class remain protected in the derived class.
 *
 * protected inheritance makes the public and protected members of the base class protected in the derived class.
 *
 * private inheritance makes the public and protected members of the base class private in the derived class.
 *
 * Private members still are private regardless of the kind of inheritance.
 */
#include <iostream>
#include <string>
#include <utility>
#include <memory>
#include <cxxabi.h>

class Person {
private:
    std::string firstName, lastName;

public:
    Person(std::string firstName, std::string lastName) {
        this->setFirstName(std::move(firstName));
        this->setLastName(std::move(lastName));
    }

    virtual std::string getFirstName() {
        return this->firstName;
    }

    virtual void setFirstName(std::string firstName) {
        this->firstName = std::move(firstName);
    }

    virtual std::string getLastName() {
        return this->lastName;
    }

    virtual void setLastName(std::string lastName) {
        this->lastName = std::move(lastName);
    }

    virtual void Speak() {
        std::cout << "I am " << this->getFirstName() << " " << this->getLastName() << " and I am a "
                  << this->getClassName() << ".";
    }

protected:
    std::string demangle(char const *mangled) {
        auto ptr = std::unique_ptr<char, decltype(&std::free)>{
                abi::__cxa_demangle(mangled, nullptr, nullptr, nullptr),
                std::free
        };
        return ptr.get();
    }

    virtual std::string getClassName() {
        return this->demangle(typeid(this).name());
    }

    virtual std::string getBaseClassName() {
        return this->demangle(typeid(this).name());
    }
};

class PublicPerson : public Person {
protected:
    typedef Person base;

    std::string getClassName() override {
        return this->demangle(typeid(this).name());
    }

    std::string getBaseClassName() override {
        return this->demangle(typeid(base).name());
    }

    void Speak() override {
        std::cout << "I am " << this->getFirstName() << " " << this->getLastName() << " and I am a "
                  << this->getClassName() << "." << std::endl;
        std::cout << "\tMy base class is " << this->getBaseClassName() << std::endl;
    }

public:
    PublicPerson(std::string firstName, std::string lastName) : base(std::move(firstName), std::move(lastName)) {
        this->Speak();
    }
};

class ProtectedPerson : protected Person {
protected:
    typedef Person base;

    std::string getBaseClassName() override {
        return this->demangle(typeid(base).name());
    }

    std::string getClassName() override {
        return this->demangle(typeid(this).name());
    }

    void Speak() override {
        std::cout << "I am " << this->getFirstName() << " " << this->getLastName() << " and I am a "
                  << this->getClassName() << "." << std::endl;
        std::cout << "\tMy base class is " << this->getBaseClassName() << std::endl;
    }

public:
    ProtectedPerson(std::string firstName, std::string lastName) : base(std::move(firstName), std::move(lastName)) {
        this->Speak();
    }
};

class PrivatePerson : private Person {
protected:
    typedef Person base;

    std::string getBaseClassName() override {
        return this->demangle(typeid(base).name());
    }

    std::string getClassName() override {
        return this->demangle(typeid(this).name());
    }

    void Speak() override {
        std::cout << "I am " << this->getFirstName() << " " << this->getLastName() << " and I am a "
                  << this->getClassName() << "." << std::endl;
        std::cout << "\tMy base class is " << this->getBaseClassName() << std::endl;
    }

public:
    PrivatePerson(std::string firstName, std::string lastName) : base(std::move(firstName), std::move(lastName)) {
        this->Speak();
    }
};

int main(int argc, const char *argv[]) {
    std::string first = "John", last = "Doe";
    Person person(first, last);
    person.Speak();
    std::cout << std::endl << std::endl;
    PublicPerson publicPerson(first, last);
    //NOTE: publicPerson.getFirstName(); //OKAY: Public method is still public
    //NOTE: publicPerson.getClassName(); //ERROR: Protected method is still protected
    //NOTE: publicPerson.firstName; //ERROR: Private member is still private
    std::cout << std::endl;
    ProtectedPerson protectedPerson(first, last);
    //NOTE: protectedPerson.getFirstName(); //ERROR: Public method is now protected
    //NOTE: protectedPerson.getClassName(); //ERROR: Protected method is still protected
    //NOTE: protectedPerson.firstName; //ERROR: Private member is still private
    std::cout << std::endl;
    PrivatePerson privatePerson(first, last);
    //NOTE: privatePerson.getFirstName(); //ERROR: Public method is now private
    //NOTE: privatePerson.getClassName(); //ERROR: Protected method is now private
    //NOTE: protectedPerson.firstName //ERROR: Private member is still private
}