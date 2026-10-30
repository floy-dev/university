#include "pch.h"

#include "printLibrary.h"

#include <Windows.h>
#include <lmcons.h>
#define SECURITY_WIN32
#include <security.h>
#include <secext.h>
#include <tchar.h>
#include <cstdlib>
#include <vector>

#pragma comment(lib, "secur32.lib")

BOOL PrintComputerName()
	{
		TCHAR buffer[MAX_COMPUTERNAME_LENGTH + 1];
	DWORD bufferSize = _countof(buffer);

	BOOL bRet = GetComputerName(buffer, &bufferSize);

	if (FALSE != bRet)
	{
		_tprintf(TEXT("Имя: %s\n"), buffer);
	}

	return bRet;
}

BOOL PrintDNSHostname()
{
	LPTSTR buffer = NULL;
	DWORD bufferSize = 0;

	GetComputerNameEx(ComputerNamePhysicalDnsHostname, NULL, &bufferSize);

	buffer = new TCHAR[bufferSize];

	BOOL functionResult = GetComputerNameEx(ComputerNamePhysicalDnsHostname, buffer, &bufferSize);

	if (FALSE != functionResult)
	{
		_tprintf(TEXT("Доменное имя: %s\n"), buffer);
	}

	delete[] buffer;

	return functionResult;
}

BOOL PrintUserName()
{
	TCHAR buffer[UNLEN + 1];
	DWORD bufferSize = _countof(buffer);

	BOOL functionResult = GetUserName(buffer, &bufferSize);

	if (FALSE != functionResult)
	{
		_tprintf(TEXT("Имя пользователя в текущем сеансе: %s\n"), buffer);
	}

	return functionResult;
}

BOOL PrintUserFullName()
{
	DWORD bufferSize = 0;
	GetUserNameEx(NameDisplay, NULL, &bufferSize);

	if (bufferSize == 0)
	{
		return FALSE;
	}

	std::vector<TCHAR> buffer(bufferSize);
	BOOL functionResult = GetUserNameEx(NameDisplay, buffer.data(), &bufferSize);

	if (FALSE != functionResult)
	{
		_tprintf(TEXT("Полное имя пользователя: %s\n"), buffer.data());
	}

	return functionResult;
}
