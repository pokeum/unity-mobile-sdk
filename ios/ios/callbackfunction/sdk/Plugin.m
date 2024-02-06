//
//  Plugin.m
//  ios
//
//  Created by Po Keum Cho on 2/6/24.
//

#import "Plugin.h"

@implementation Plugin

static int counter = 0;
static NSString *const TAG = @"Native";

+ (void)testFuncWithDelay:(int)delayMillis
                onSuccess:(UnitCallback)onSuccess
                onFailure:(ErrorCallback)onFailure {
    
    int id = counter++;
    NSLog(@"[Plugin] TestFunc Called #%d", id);
    
    dispatch_async(dispatch_get_global_queue(DISPATCH_QUEUE_PRIORITY_DEFAULT, 0), ^{
        
        [NSThread sleepForTimeInterval:delayMillis / 1000.0];
        
        // OnSuccess
        if (arc4random_uniform(2) == 0) {
            NSLog(@"[Plugin] TestFunc OnSuccess Called! #%d", id);
            onSuccess();
        }
        // OnFailure
        else {
            NSError *error = [NSError errorWithDomain:@"CustomDomain" 
                                                 code:0
                                             userInfo:@{NSLocalizedDescriptionKey: @"CUSTOM EXCEPTION"}];
            NSLog(@"[Plugin] TestFunc OnFailure Called! #%d : %@", id, [error localizedDescription]);
            onFailure(error);
        }
    });
}

@end
