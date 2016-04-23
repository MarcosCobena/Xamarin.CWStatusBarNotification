XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/CWStatusBarNotification.xcodeproj
TARGET=CWStatusBarNotification

all: libCWStatusBarNotification.a

libCWStatusBarNotification-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libCWStatusBarNotification-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libCWStatusBarNotification-arm64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build 
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libCWStatusBarNotification.a: libCWStatusBarNotification-i386.a libCWStatusBarNotification-armv7.a libCWStatusBarNotification-arm64.a
	lipo -create -output $@ $^

clean: -rm -f *.a *.dll