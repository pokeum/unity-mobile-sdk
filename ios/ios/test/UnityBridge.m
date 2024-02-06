//
//  UnityBridge.m
//  ios
//
//  Created by Po Keum Cho on 2/6/24.
//

#import "UnityBridge.h"

void framework_hello(void)
{
    [TestClass displayFrameworkHello];
}

void framework_message(const char* message)
{
    [TestClass displayFrameworkString:[NSString stringWithUTF8String:message]];
}

void framework_trigger_delegate(void) 
{
    [TestClass sendNumberToDelegate];
}

//==================================================

DelegateCallbackFunction delegate = NULL;

@interface UnityBridge : NSObject <TestDelegate>
@end

@implementation UnityBridge

- (void) newNumberAvalilable: (int) number
{
    if (delegate != NULL) { delegate(number); }
}
@end

//==================================================

static UnityBridge *__delegate = nil;

void framework_set_delegate(DelegateCallbackFunction callback)
{
    if (!__delegate) {
        __delegate = [[UnityBridge alloc] init];
    }
    [TestClass setDelegate:__delegate];
    
    delegate = callback;
}
