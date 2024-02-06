//
//  main.m
//  ios
//
//  Created by Po Keum Cho on 2/4/24.
//

#import <Foundation/Foundation.h>
#import "Plugin.h"

int main(int argc, const char * argv[]) {
    @autoreleasepool {
    
        dispatch_semaphore_t semaphore = dispatch_semaphore_create(0);
        
        [Plugin testFuncWithDelay:5000
                        onSuccess:^{ 
            NSLog(@"TestFunc OnSuccess Called!");
            dispatch_semaphore_signal(semaphore);
        }
                        onFailure:^(NSError *error) {
            NSLog(@"TestFunc OnFailure Called! : %@", [error localizedDescription]);
            dispatch_semaphore_signal(semaphore);
        }];
        
        // Wait for the callback
        dispatch_semaphore_wait(semaphore, DISPATCH_TIME_FOREVER);
    }
    
    return (0);
}
