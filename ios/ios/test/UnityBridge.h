//
//  UnityBridge.h
//  ios
//
//  Created by Po Keum Cho on 2/6/24.
//

#import "TestClass.h"

#ifdef __cplusplus
extern "C" {
#endif

void framework_hello(void);
void framework_message(const char* message);

void framework_trigger_delegate(void);

typedef void (*DelegateCallbackFunction)(int number);
void framework_set_delegate(DelegateCallbackFunction callback);

#ifdef __cplusplus
}
#endif
