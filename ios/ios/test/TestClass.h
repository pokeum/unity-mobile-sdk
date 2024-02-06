//
//  TestClass.h
//  ios
//
//  Created by Po Keum Cho on 2/6/24.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@protocol TestDelegate <NSObject>
- (void) newNumberAvalilable: (int) number;
@end

@interface TestClass : NSObject

+ (void) displayFrameworkHello;
+ (void) displayFrameworkString: (NSString *)string;
+ (void) sendNumberToDelegate;

+ (void) setDelegate: (id<TestDelegate>) delegate;

@end

NS_ASSUME_NONNULL_END
